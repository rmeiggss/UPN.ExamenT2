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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dgLista = new DataGridView();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            cmbDueño = new ComboBox();
            txtRaza = new TextBox();
            btnGuardar = new Button();
            btnCerrar = new Button();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgLista).BeginInit();
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
            // dgLista
            // 
            dgLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLista.Location = new Point(12, 142);
            dgLista.Name = "dgLista";
            dgLista.Size = new Size(695, 264);
            dgLista.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(80, 15);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(273, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(80, 49);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(273, 23);
            txtEdad.TabIndex = 2;
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
            // btnGuardar
            // 
            btnGuardar.Location = new Point(609, 93);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(98, 43);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
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
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(213, 113);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(72, 25);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // FrmMascota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 469);
            Controls.Add(btnBuscar);
            Controls.Add(btnCerrar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbDueño);
            Controls.Add(txtRaza);
            Controls.Add(txtBuscar);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(dgLista);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMascota";
            Text = "Registro de mascota";
            ((System.ComponentModel.ISupportInitialize)dgLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dgLista;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private ComboBox cmbDueño;
        private TextBox txtRaza;
        private Button btnGuardar;
        private Button btnCerrar;
        private TextBox txtBuscar;
        private Button btnBuscar;
    }
}