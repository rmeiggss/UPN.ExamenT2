using UPN.ExamenT2.Enunciado1.Utiles;

namespace UPN.ExamenT2.Enunciado1
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void due�osToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilitario.CreateMdiChildOrActivate<FrmDue�o>(this);
        }

        private void mascotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilitario.CreateMdiChildOrActivate<FrmMascota>(this);
        }
    }
}
