namespace UPN.ExamenT2.Enunciado1
{
    partial class FrmMenu
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
            menuStrip1 = new MenuStrip();
            mantenimientosToolStripMenuItem = new ToolStripMenuItem();
            dueñosToolStripMenuItem = new ToolStripMenuItem();
            mascotasToolStripMenuItem = new ToolStripMenuItem();
            eToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mantenimientosToolStripMenuItem, eToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(823, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // mantenimientosToolStripMenuItem
            // 
            mantenimientosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dueñosToolStripMenuItem, mascotasToolStripMenuItem });
            mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            mantenimientosToolStripMenuItem.Size = new Size(84, 20);
            mantenimientosToolStripMenuItem.Text = "Enunciado 1";
            // 
            // dueñosToolStripMenuItem
            // 
            dueñosToolStripMenuItem.Name = "dueñosToolStripMenuItem";
            dueñosToolStripMenuItem.Size = new Size(181, 22);
            dueñosToolStripMenuItem.Text = "Registro de dueño";
            dueñosToolStripMenuItem.Click += dueñosToolStripMenuItem_Click;
            // 
            // mascotasToolStripMenuItem
            // 
            mascotasToolStripMenuItem.Name = "mascotasToolStripMenuItem";
            mascotasToolStripMenuItem.Size = new Size(181, 22);
            mascotasToolStripMenuItem.Text = "Registro de mascota";
            mascotasToolStripMenuItem.Click += mascotasToolStripMenuItem_Click;
            // 
            // eToolStripMenuItem
            // 
            eToolStripMenuItem.Name = "eToolStripMenuItem";
            eToolStripMenuItem.Size = new Size(84, 20);
            eToolStripMenuItem.Text = "Enunciado 2";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 623);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Evaluación de conocimientos T2";
            WindowState = FormWindowState.Maximized;
            Load += FrmMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mantenimientosToolStripMenuItem;
        private ToolStripMenuItem dueñosToolStripMenuItem;
        private ToolStripMenuItem mascotasToolStripMenuItem;
        private ToolStripMenuItem eToolStripMenuItem;
    }
}
