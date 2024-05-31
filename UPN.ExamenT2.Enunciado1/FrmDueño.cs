using System.Windows.Forms;
using UPN.ExamenT2.Enunciado1.Utiles;
using UPN.ExamenT2.Repository.Models;
using UPN.ExamenT2.Repository.Repository;

namespace UPN.ExamenT2.Enunciado1
{
    public partial class FrmDueño : Form
    {
        private readonly DuenhoRepository pdes_duenhoRepository;
        public FrmDueño()
        {
            pdes_duenhoRepository = new DuenhoRepository();
            InitializeComponent();
        }
        private bool Validaciones()
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Ingrese un nombre");
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                errorProvider2.SetError(txtDireccion, "Ingrese una dirección");
                txtDireccion.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(mkdTelefono.Text))
            {
                errorProvider3.SetError(mkdTelefono, "Ingrese un teléfono");
                mkdTelefono.Focus();
                return false;
            }
            if (!mkdTelefono.MaskCompleted)
            {
                errorProvider3.SetError(mkdTelefono, "Ingrese un teléfono válido");
                mkdTelefono.Focus();
                mkdTelefono.Select(0, mkdTelefono.Text.Length);
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            try
            {
                var pdes_duenho = pdes_duenhoRepository.BuscarPorNombre(txtBuscar.Text);
                RefreshData(pdes_duenho);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmDueño_Load(object sender, EventArgs e)
        {
            IniciarGrilla();
            Listar();
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtDireccion.Clear();
            mkdTelefono.Clear();

            dgLista.ClearSelection();

            txtNombre.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Listar()
        {
            try
            {
                var pdes_duenho = pdes_duenhoRepository.Listar();
                RefreshData(pdes_duenho);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshData(List<Duenho> duenhos)
        {
            BindingSource db = new BindingSource();
            db.DataSource = duenhos;
            dgLista.DataSource = db;
            dgLista.Refresh();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgLista.SelectedRows.Count > 0)
            {
                try
                {
                    var confirm = MessageBox.Show("¿Está seguro de eliminar?", "¡ALERTA!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        var id = Convert.ToInt32(dgLista.SelectedRows[0].Cells["txtId"].Value);
                        pdes_duenhoRepository.Eliminar(id);
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
                var pdes_duenho = pdes_duenhoRepository.BuscarPorId(id);

                txtNombre.Text = pdes_duenho.Nombre;
                txtDireccion.Text = pdes_duenho.Direccion;
                mkdTelefono.Text = pdes_duenho.Telefono;
            }
        }

        private void IniciarGrilla()
        {
            try
            {
                dgLista.Columns.Add(new DataGridViewTextBoxColumn() { Name = "txtId", HeaderText = "Id", ReadOnly = true, DataPropertyName = "Id", Visible = false });
                dgLista.Columns.Add(new DataGridViewTextBoxColumn() { Name = "txtNombre", HeaderText = "Nombre", ReadOnly = true, DataPropertyName = "Nombre" });
                dgLista.Columns.Add(new DataGridViewTextBoxColumn() { Name = "txtDireccion", HeaderText = "Direccion", ReadOnly = true, DataPropertyName = "Direccion" });
                dgLista.Columns.Add(new DataGridViewTextBoxColumn() { Name = "txtTelefono", HeaderText = "Telefono", ReadOnly = true, DataPropertyName = "Telefono" });

                dgLista.AutoGenerateColumns = true;
                dgLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                var pdes_selectedRows = dgLista.SelectedRows;
                if (pdes_selectedRows.Count > 0)
                {
                    var id = Convert.ToInt32(pdes_selectedRows[0].Cells["txtId"].Value);
                    var pdes_duenho = pdes_duenhoRepository.BuscarPorId(id);
                    if (pdes_duenho == null)
                    {
                        throw new Exception("No se encontro el registro, por favor limpie el formulario.");
                    }

                    pdes_duenho.Nombre = txtNombre.Text;
                    pdes_duenho.Direccion = txtDireccion.Text;
                    pdes_duenho.Telefono = mkdTelefono.Text;

                    pdes_duenhoRepository.Actualizar(pdes_duenho);
                }
                else
                {
                    var pdes_duenho = new Duenho(txtNombre.Text, txtDireccion.Text, mkdTelefono.Text);
                    pdes_duenhoRepository.Guardar(pdes_duenho);
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
    }
}
