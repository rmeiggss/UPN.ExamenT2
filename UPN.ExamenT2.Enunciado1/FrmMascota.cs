using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPN.ExamenT2.CrossCutting.Utiles;
using UPN.ExamenT2.Enunciado1.Utiles;
using UPN.ExamenT2.Repository.Models;
using UPN.ExamenT2.Repository.Repository;

namespace UPN.ExamenT2.Enunciado1
{
    public partial class FrmMascota : Form, IDisposable
    {
        private readonly DuenhoRepository des_duenhoRepository;
        private readonly MascotaRepository des_mascotaRepository;
        public FrmMascota()
        {
            des_duenhoRepository = new DuenhoRepository();
            des_mascotaRepository = new MascotaRepository();

            InitializeComponent();
        }

        private void FrmMascota_Load(object sender, EventArgs e)
        {
            IniciarGrilla();
            LlenarCombo();
            Listar();
        }

        private void LlenarCombo()
        {
            cmbDueño.DisplayMember = "Nombre";
            cmbDueño.ValueMember = "Id";

            var lista = Utilitario.EnumerableADataTable(des_duenhoRepository.Listar()).DefaultView;
            cmbDueño.DataSource = lista;
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
                var pdes_mascota = des_mascotaRepository.Listar();
                if (pdes_mascota.Count > 0)
                {
                    RefreshData(pdes_mascota);
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
                var pdes_selectedRows = dgLista.SelectedRows;
                if (pdes_selectedRows.Count > 0)
                {
                    var id = Convert.ToInt32(pdes_selectedRows[0].Cells["txtId"].Value);
                    var pdes_duenho = des_mascotaRepository.BuscarPorId(id);
                    if (pdes_duenho == null)
                    {
                        throw new Exception("No se encontro el registro, por favor limpie el formulario.");
                    }

                    pdes_duenho.Nombre = txtNombre.Text;
                    pdes_duenho.Edad = Convert.ToInt32(txtEdad.Text);
                    pdes_duenho.Raza = txtRaza.Text;
                    pdes_duenho.DuenhoId = Convert.ToInt32(cmbDueño.SelectedValue);

                    des_mascotaRepository.Actualizar(pdes_duenho);
                }
                else
                {
                    var pdes_duenho = new Mascota(txtNombre.Text, txtRaza.Text, Convert.ToInt32(txtEdad.Text), Convert.ToInt32(cmbDueño.SelectedValue));
                    des_mascotaRepository.Guardar(pdes_duenho);
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
                var pdes_mascota = des_mascotaRepository.BuscarPorNombre(txtBuscar.Text);
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
            txtRaza.Clear();
            txtEdad.ResetText();
            cmbDueño.SelectedIndex = -1;

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

            if (string.IsNullOrEmpty(txtRaza.Text))
            {
                errorProvider1.SetError(txtRaza, "Ingrese una raza");
                txtRaza.Focus();
                return false;
            }


            if (string.IsNullOrEmpty(txtEdad.Text))
            {
                errorProvider1.SetError(txtRaza, "Ingrese la edad");
                txtRaza.Focus();
                return false;
            }
            if (txtEdad.Value == 0)
            {
                errorProvider1.SetError(txtEdad, "Ingrese una edad válida");
                txtEdad.Focus();
                return false;
            }
            

            if (cmbDueño.SelectedIndex == -1)
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
                    var confirm = MessageBox.Show("¿Está seguro de eliminar?", "¡ALERTA!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        var id = Convert.ToInt32(dgLista.SelectedRows[0].Cells["txtId"].Value);
                        des_mascotaRepository.Eliminar(id);
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
                var pdes_duenho = des_mascotaRepository.BuscarPorId(id);
                if(pdes_duenho != null)
                {
                    txtNombre.Text = pdes_duenho.Nombre;
                    txtRaza.Text = pdes_duenho.Raza;
                    txtEdad.Text = pdes_duenho.Edad.ToString();
                    cmbDueño.SelectedValue = pdes_duenho.DuenhoId;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
