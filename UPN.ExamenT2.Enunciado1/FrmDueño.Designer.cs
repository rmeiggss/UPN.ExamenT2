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
            btnBuscar = new Button();
            btnCerrar = new Button();
            btnGuardar = new Button();
            txtRaza = new TextBox();
            txtBuscar = new TextBox();
            txtNombre = new TextBox();
            dgLista = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            mkdTelefono = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dgLista).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(213, 108);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(72, 25);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(609, 407);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(98, 45);
            btnCerrar.TabIndex = 16;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(609, 88);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(98, 43);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtRaza
            // 
            txtRaza.AcceptsReturn = true;
            txtRaza.Location = new Point(434, 10);
            txtRaza.Multiline = true;
            txtRaza.Name = "txtRaza";
            txtRaza.ScrollBars = ScrollBars.Vertical;
            txtRaza.Size = new Size(273, 57);
            txtRaza.TabIndex = 10;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 108);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(195, 23);
            txtBuscar.TabIndex = 11;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(80, 10);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(273, 23);
            txtNombre.TabIndex = 13;
            // 
            // dgLista
            // 
            dgLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLista.Location = new Point(12, 137);
            dgLista.Name = "dgLista";
            dgLista.Size = new Size(695, 264);
            dgLista.TabIndex = 9;
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
            mkdTelefono.TabIndex = 18;
            // 
            // FrmDueño
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 459);
            Controls.Add(mkdTelefono);
            Controls.Add(btnBuscar);
            Controls.Add(btnCerrar);
            Controls.Add(btnGuardar);
            Controls.Add(txtRaza);
            Controls.Add(txtBuscar);
            Controls.Add(txtNombre);
            Controls.Add(dgLista);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmDueño";
            Text = "Registro de dueño";
            ((System.ComponentModel.ISupportInitialize)dgLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private Button btnCerrar;
        private Button btnGuardar;
        private TextBox txtRaza;
        private TextBox txtBuscar;
        private TextBox txtNombre;
        private DataGridView dgLista;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox mkdTelefono;
    }
}