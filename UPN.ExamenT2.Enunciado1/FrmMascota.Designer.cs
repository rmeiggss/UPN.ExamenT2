namespace UPN.ExamenT2.Enunciado1
{
    partial class FrmMascota
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            cmbDueño = new ComboBox();
            txtRaza = new TextBox();
            btnCerrar = new Button();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            errorProvider1 = new ErrorProvider(components);
            dgLista = new DataGridView();
            btnEliminar = new Button();
            btnNuevo = new Button();
            button1 = new Button();
            txtEdad = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgLista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEdad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 19);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 52);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 0;
            label2.Text = "Edad: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(375, 15);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 0;
            label3.Text = "Raza: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(375, 53);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 0;
            label4.Text = "Dueño: ";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(80, 15);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(273, 23);
            txtNombre.TabIndex = 2;
            // 
            // cmbDueño
            // 
            cmbDueño.FormattingEnabled = true;
            cmbDueño.Location = new Point(434, 50);
            cmbDueño.Name = "cmbDueño";
            cmbDueño.Size = new Size(273, 23);
            cmbDueño.TabIndex = 3;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(434, 12);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(273, 23);
            txtRaza.TabIndex = 2;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(609, 412);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(98, 45);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 113);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(195, 23);
            txtBuscar.TabIndex = 2;
            txtBuscar.KeyPress += txtBuscar_KeyPress;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(213, 113);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(72, 25);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // dgLista
            // 
            dgLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLista.Location = new Point(12, 144);
            dgLista.MultiSelect = false;
            dgLista.Name = "dgLista";
            dgLista.Size = new Size(695, 264);
            dgLista.TabIndex = 9;
            dgLista.CellClick += dgLista_CellContentClick;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(606, 101);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(98, 35);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(398, 101);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(98, 35);
            btnNuevo.TabIndex = 11;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(502, 101);
            button1.Name = "button1";
            button1.Size = new Size(98, 35);
            button1.TabIndex = 12;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(80, 51);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(120, 23);
            txtEdad.TabIndex = 14;
            // 
            // FrmMascota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 469);
            Controls.Add(txtEdad);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(button1);
            Controls.Add(dgLista);
            Controls.Add(btnBuscar);
            Controls.Add(btnCerrar);
            Controls.Add(cmbDueño);
            Controls.Add(txtRaza);
            Controls.Add(txtBuscar);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMascota";
            Text = "Registro de mascota";
            Load += FrmMascota_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgLista).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEdad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private ComboBox cmbDueño;
        private TextBox txtRaza;
        private Button btnCerrar;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private ErrorProvider errorProvider1;
        private DataGridView dgLista;
        private Button btnEliminar;
        private Button btnNuevo;
        private Button button1;
        private NumericUpDown txtEdad;
    }
}