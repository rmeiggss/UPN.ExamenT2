namespace UPN.ExamenT2.Enunciado1
{
    partial class FrmDueño
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnBuscar = new Button();
            btnCerrar = new Button();
            btnGuardar = new Button();
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            dgLista = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            mkdTelefono = new MaskedTextBox();
            btnEliminar = new Button();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            btnNuevo = new Button();
            txtBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgLista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(213, 108);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(72, 25);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(609, 407);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(98, 45);
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(505, 96);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(98, 35);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.AcceptsReturn = true;
            txtDireccion.Location = new Point(434, 10);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.ScrollBars = ScrollBars.Vertical;
            txtDireccion.Size = new Size(248, 57);
            txtDireccion.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(80, 10);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(243, 23);
            txtNombre.TabIndex = 1;
            // 
            // dgLista
            // 
            dgLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLista.Location = new Point(12, 137);
            dgLista.MultiSelect = false;
            dgLista.Name = "dgLista";
            dgLista.Size = new Size(695, 264);
            dgLista.TabIndex = 8;
            dgLista.CellClick += dgLista_CellContentClick;
            dgLista.DataBindingComplete += dgLista_DataBindingComplete;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(365, 14);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 6;
            label3.Text = "Direccion: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 47);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 7;
            label2.Text = "Telefono: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 14);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 8;
            label1.Text = "Nombre: ";
            // 
            // mkdTelefono
            // 
            mkdTelefono.Location = new Point(99, 47);
            mkdTelefono.Mask = "000000000";
            mkdTelefono.Name = "mkdTelefono";
            mkdTelefono.Size = new Size(100, 23);
            mkdTelefono.TabIndex = 3;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(609, 96);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(98, 35);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(401, 96);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(98, 35);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 108);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(195, 23);
            txtBuscar.TabIndex = 5;
            txtBuscar.KeyPress += txtBuscar_KeyPress;
            // 
            // FrmDueño
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 459);
            Controls.Add(mkdTelefono);
            Controls.Add(btnBuscar);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(btnGuardar);
            Controls.Add(txtDireccion);
            Controls.Add(txtBuscar);
            Controls.Add(txtNombre);
            Controls.Add(dgLista);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmDueño";
            Text = "Registro de dueño";
            Load += FrmDueño_Load;
            ((System.ComponentModel.ISupportInitialize)dgLista).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private Button btnCerrar;
        private Button btnGuardar;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private DataGridView dgLista;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox mkdTelefono;
        private Button btnEliminar;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private Button btnNuevo;
        private TextBox txtBuscar;
    }
}