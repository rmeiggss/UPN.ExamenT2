using System.Data;
using System.Reflection;

namespace UPN.ExamenT2.Enunciado2.Utiles
{
    public static class Utilitario
    {
        private static Dictionary<Type, Form> openForms = new Dictionary<Type, Form>();
        public static void CreateMdiChildOrActivate<T>(Form form) where T : Form, new()
        {
            Form instance;
            openForms.TryGetValue(typeof(T), out instance);
            if (instance == null || instance.IsDisposed)
            {
                instance = new T();
                openForms[typeof(T)] = instance;
                instance.MdiParent = form;
                instance.Show();
            }
            else
            {
                instance.Activate();
            }
        }

        public static bool TextBoxEnter(KeyEventArgs e)
        {
            return (e.KeyCode == Keys.Enter);
        }

        public static bool TextBoxEnter(KeyPressEventArgs e)
        {
            return (e.KeyChar == (int)Keys.Enter);
        }

        public static void BuscarValorEnGria(string valor, DataGridView dgv, int? campoBuscar = null)
        {
            int celda = campoBuscar ?? 0;
            if (dgv.RowCount > 0)
            {
                BuscarValorEnGrilla(valor, dgv, celda);
            }
        }
        public static void BuscarValorEnGria(string valor, DataGridView dgv, string campoBuscar)
        {
            string celda = string.IsNullOrEmpty(campoBuscar) ? dgv.SortedColumn.Name : campoBuscar;

            if (dgv.RowCount > 0)
            {
                BuscarValorEnGrilla(valor, dgv, celda);
            }
        }
        private static bool BuscarValorEnGrilla(string valor, DataGridView dgv, object celda)
        {
            try
            {
                dynamic obj = null;
                switch (celda.GetType().Name)
                {
                    case "String":
                        obj = (string)celda;
                        break;
                    case "Int":
                        obj = (int)celda;
                        break;
                    default:
                        throw new Exception("");
                }

                int rowIndex = -1;

                DataGridViewRow row = dgv.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells[obj].Value.ToString().StartsWith(valor))
                    .First();

                rowIndex = row.Index;

                dgv.CurrentCell = dgv[obj, rowIndex];

                return dgv.Rows[rowIndex].Selected = true;
            }
            catch (Exception)
            {
                dgv.ClearSelection();
                return false;
            }
        }


        public static DataTable EnumerableADataTable<T>(IEnumerable<T> v)
        {
            /*Okay, we have some data. Time to work.*/

            //So dear record, what do you have?
            PropertyInfo[] infos = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            //PropertyInfo[] infos = firstRecord.GetType().GetProperties();

            //Our table should have the columns to support the properties
            DataTable table = new DataTable();

            //Add, add, add the columns
            foreach (var info in infos)
            {
                Type propType = info.PropertyType;
                if (propType.IsGenericType
                    && propType.GetGenericTypeDefinition() == typeof(Nullable<>)) //Nullable types should be handled too
                {
                    table.Columns.Add(info.Name, Nullable.GetUnderlyingType(propType));
                }
                else
                {
                    table.Columns.Add(info.Name, info.PropertyType);
                }
            }

            //Hmm... we are done with the columns. Let's begin with rows now.
            DataRow row;

            //We really want to know if there is any data at all
            var firstRecord = v.FirstOrDefault();
            if (firstRecord != null)
            {
                foreach (var record in v)
                {
                    row = table.NewRow();
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        row[i] = infos[i].GetValue(record) != null ? infos[i].GetValue(record) : DBNull.Value;
                    }

                    table.Rows.Add(row);
                }
            }

            //Table is ready to serve.
            table.AcceptChanges();

            return table;
        }
    }



}
