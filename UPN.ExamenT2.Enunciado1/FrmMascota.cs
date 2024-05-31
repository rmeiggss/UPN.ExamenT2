using System.Data;
using UPN.ExamenT2.Enunciado1.Utiles;
using UPN.ExamenT2.Repository.Models;
using UPN.ExamenT2.Repository.Repository;

namespace UPN.ExamenT2.Enunciado1
{
    public partial class FrmMascota : Form, IDisposable
    {
        private readonly DuenhoRepository pd_duenhoRepository;
        private readonly MascotaRepository pd_mascotaRepository;
        private readonly RazaRepository pd_razaRepository;
        public FrmMascota()
        {
            pd_duenhoRepository = new DuenhoRepository();
            pd_mascotaRepository = new MascotaRepository();
            pd_razaRepository = new RazaRepository();

            InitializeComponent();
        }

        private void FrmMascota_Load(object sender, EventArgs e)
        {
            IniciarGrilla();
            LlenarComboDuenho();
            LlenarComboRaza();

            Listar();
        }

        private void LlenarComboRaza()
        {
            cmbRaza.DisplayMember = "Nombre";
            cmbRaza.ValueMember = "Id";

            var pd_lista = Utilitario.EnumerableADataTable(pd_razaRepository.Listar()).DefaultView;
            var pd_defaultRow = pd_lista.Table!.NewRow();
            pd_defaultRow["Id"] = 0;
            pd_defaultRow["Nombre"] = "-Seleccione-";
            pd_lista.Table.Rows.InsertAt(pd_defaultRow, 0);

            cmbRaza.DataSource = pd_lista;
            cmbRaza.BindingContext = BindingContext;
        }

        private void LlenarComboDuenho()
        {
            cmbDueño.DisplayMember = "Nombre";
            cmbDueño.ValueMember = "Id";

            var des_lista = Utilitario.EnumerableADataTable(pd_duenhoRepository.Listar()).DefaultView;
            var defaultRow = des_lista.Table!.NewRow();
            defaultRow["Id"] = 0;
            defaultRow["Nombre"] = "-Seleccione-";
            des_lista.Table.Rows.InsertAt(defaultRow, 0);
            
            cmbDueño.DataSource = des_lista;
            cmbDueño.BindingContext = BindingContext;
        }

        private void IniciarGrilla()
        {
            try
            {
                dgLista.Columns.Add(new DataGridViewTextBoxColumn() { Name = "txtId", HeaderText = "Id", ReadOnly = true, DataPropertyName = "Id", Visible = false });
                dgLista.Columns.Add(new DataGridViewTextBoxColumn() { Name = "txtNombre", HeaderText = "Nombre", ReadOnly = true, DataPropertyName = "Nombre" });
                dgLista.Columns.Add(new DataGridViewTextBoxColumn() { Name = "txtRaza", HeaderText = "Raza", ReadOnly = true, DataPropertyName = "Raza" });
                dgLista.Columns.Add(new DataGridViewTextBoxColumn() { Name = "txtEdad", HeaderText = "Edad", ReadOnly = true, DataPropertyName = "Edad" });
                dgLista.Columns.Add(new DataGridViewTextBoxColumn() { Name = "txtDuenho", HeaderText = "Dueño", ReadOnly = true, DataPropertyName = "NombreDuenho" });
                dgLista.Columns.Add(new DataGridViewTextBoxColumn() { Name = "txtDuenhoId", HeaderText = "", ReadOnly = true, DataPropertyName = "DuenhoId", Visible = false });
                dgLista.Columns.Add(new DataGridViewTextBoxColumn() { Name = "txtDuenhoObj", HeaderText = "", ReadOnly = true, DataPropertyName = "Duenho", Visible = false });

                dgLista.AutoGenerateColumns = true;
                dgLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Listar()
        {
            try
            {
                var pd_mascota = pd_mascotaRepository.Listar();
                if (pd_mascota.Count > 0)
                {
                    RefreshData(pd_mascota);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshData(List<Mascota> mascotas)
        {
            BindingSource db = new BindingSource();
            db.DataSource = mascotas;
            dgLista.DataSource = db;
            dgLista.Refresh();
        }


        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Utilitario.TextBoxEnter(e))
            {
                Buscar();
            }
        }

        private void Guardar()
        {
            try
            {
                if (!Validaciones())
                {
                    return;
                }
                var pd_selectedRows = dgLista.SelectedRows;
                if (pd_selectedRows.Count > 0)
                {
                    var id = Convert.ToInt32(pd_selectedRows[0].Cells["txtId"].Value);
                    var pd_duenho = pd_mascotaRepository.BuscarPorId(id);
                    if (pd_duenho == null)
                    {
                        throw new Exception("No se encontro el registro, por favor limpie el formulario.");
                    }

                    pd_duenho.Nombre = txtNombre.Text;
                    pd_duenho.Edad = Convert.ToInt32(txtEdad.Text);
                    pd_duenho.Raza = cmbRaza.Text;
                    pd_duenho.DuenhoId = Convert.ToInt32(cmbDueño.SelectedValue);

                    pd_mascotaRepository.Actualizar(pd_duenho);
                }
                else
                {
                    var pd_existeMascota = pd_mascotaRepository.BuscarPorNombre(txtNombre.Text);
                    if(pd_existeMascota is not null && pd_existeMascota.Count > 0)
                    {
                        throw new Exception("Ya existe una mascota con ese nombre");
                    }

                    var pd_duenho = new Mascota(txtNombre.Text, cmbRaza.Text, Convert.ToInt32(txtEdad.Text), Convert.ToInt32(cmbDueño.SelectedValue));
                    pd_mascotaRepository.Guardar(pd_duenho);
                }
                MessageBox.Show("Se guardo correctamente", "¡MENSAJE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgLista.ClearSelection();
        }

        private void Buscar()
        {
            try
            {
                var pdes_mascota = pd_mascotaRepository.BuscarPorNombre(txtBuscar.Text);
                RefreshData(pdes_mascota);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            cmbRaza.SelectedIndex = 0;
            txtEdad.ResetText();
            cmbDueño.SelectedIndex = 0;

            dgLista.ClearSelection();

            txtNombre.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool Validaciones()
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Ingrese un nombre");
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtEdad.Text))
            {
                errorProvider1.SetError(txtEdad, "Ingrese la edad");
                txtEdad.Focus();
                return false;
            }
            if (txtEdad.Value == 0)
            {
                errorProvider1.SetError(txtEdad, "Ingrese una edad válida");
                txtEdad.Focus();
                return false;
            }

            if (cmbRaza.SelectedIndex <= 0)
            {
                errorProvider1.SetError(cmbRaza, "Seleccione una raza");
                cmbRaza.Focus();
                return false;
            }

            if (cmbDueño.SelectedIndex <= 0)
            {
                errorProvider1.SetError(cmbDueño, "Seleccione un dueño");
                cmbDueño.Focus();
                return false;
            }

            return true;
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgLista.SelectedRows.Count > 0)
            {
                try
                {
                    var pd_confirm = MessageBox.Show("¿Está seguro de eliminar?", "¡ALERTA!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (pd_confirm == DialogResult.Yes)
                    {
                        var id = Convert.ToInt32(dgLista.SelectedRows[0].Cells["txtId"].Value);
                        pd_mascotaRepository.Eliminar(id);
                        MessageBox.Show("Se eliminó correctamente", "¡MENSAJE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        Listar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void dgLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var id = Convert.ToInt32(dgLista.Rows[e.RowIndex].Cells["txtId"].Value);
                var pd_duenho = pd_mascotaRepository.BuscarPorId(id);
                if(pd_duenho != null)
                {
                    txtNombre.Text = pd_duenho.Nombre;
                    cmbRaza.Text = pd_duenho.Raza;
                    txtEdad.Text = pd_duenho.Edad.ToString();
                    cmbDueño.SelectedValue = pd_duenho.DuenhoId;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
