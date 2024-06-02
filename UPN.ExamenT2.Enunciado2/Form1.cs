using UPN.ExamenT2.CrossCutting.Utiles;
using UPN.ExamenT2.Enunciado2.Utiles;

namespace UPN.ExamenT2.Enunciado2
{
    public partial class Form1 : Form
    {
        List<int> pd_listaNumeros;
        public Form1()
        {
            pd_listaNumeros = new List<int>();
            InitializeComponent();
        }
        private void Agregar()
        {
            try
            {
                var existeNumero = AlgoritmosBusqueda.BusquedaSecuencial(pd_listaNumeros.ToArray(), int.Parse(txtNumero.Text));
                if (existeNumero != -1)
                {
                    throw new Exception("El número ya existe");
                }
                var numero = int.Parse(txtNumero.Text);

                pd_listaNumeros.Add(numero);
                txtNumero.Value = 0;
                txtNumero.Focus();

                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }
        private void Listar()
        {
            try
            {
                //list pd_lsitarNumeros in listview
                listView1.Items.Clear();
                foreach (var item in pd_listaNumeros)
                {
                    listView1.Items.Add(item.ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Utilitario.TextBoxEnter(e))
            {
                Agregar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pd_arrayOrdenado = AlgoritmosOrdenamiento.burbuja([.. pd_listaNumeros]);
            pd_listaNumeros = pd_arrayOrdenado.ToList();
            Listar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var pd_arrayOrdenado = AlgoritmosOrdenamiento.burbujaReverse([.. pd_listaNumeros]);
            pd_listaNumeros = pd_arrayOrdenado.ToList();
            Listar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un número");
                return;
            }

            var pd_selectedItem = listView1.SelectedItems[0].Text;

            var pd_index = AlgoritmosBusqueda.BusquedaSecuencial([..pd_listaNumeros], int.Parse(pd_selectedItem));
            pd_listaNumeros.RemoveAt(pd_index);
            Listar();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Utilitario.TextBoxEnter(e))
            {
                Buscar();
            }
        }

        private void Buscar()
        {
            var pd_index = AlgoritmosBusqueda.BusquedaSecuencial([.. pd_listaNumeros], int.Parse(txtBuscar.Text));
            if (pd_index != -1)
            {
                listView1.Items[pd_index].Selected = true;
                listView1.Select();
            }
            else
            {
                MessageBox.Show("No se encontró el número");
            }
        }
    }
}
