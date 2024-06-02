namespace UPN.ExamenT2.Enunciado2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNumero = new NumericUpDown();
            btnAgregar = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            txtBuscar = new TextBox();
            listView1 = new ListView();
            ((System.ComponentModel.ISupportInitialize)txtNumero).BeginInit();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(12, 12);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(120, 23);
            txtNumero.TabIndex = 1;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(138, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "&Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(309, 390);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "&Cerrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(264, 79);
            button2.Name = "button2";
            button2.Size = new Size(120, 23);
            button2.TabIndex = 3;
            button2.Text = "A&scendente";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(264, 108);
            button3.Name = "button3";
            button3.Size = new Size(120, 23);
            button3.TabIndex = 4;
            button3.Text = "&Descendente";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(264, 137);
            button4.Name = "button4";
            button4.Size = new Size(120, 23);
            button4.TabIndex = 5;
            button4.Text = "&Eliminar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 50);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar número:";
            txtBuscar.Size = new Size(246, 23);
            txtBuscar.TabIndex = 6;
            txtBuscar.KeyPress += textBox1_KeyPress;
            // 
            // listView1
            // 
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(12, 79);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(246, 334);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 425);
            Controls.Add(listView1);
            Controls.Add(txtBuscar);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnAgregar);
            Controls.Add(txtNumero);
            Name = "Form1";
            Text = "Enunciado2";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)txtNumero).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown txtNumero;
        private Button btnAgregar;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox txtBuscar;
        private ListView listView1;
    }
}
