using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPN.ExamenT2.Enunciado1.Utiles
{
    public static class Utilitario
    {
        private static Dictionary<Type, Form> openForms = new Dictionary<Type, Form>();
        public static void CreateMdiChildOrActivate<T>(Form form) where T : Form, new()
        {
            Form instance;
            openForms.TryGetValue(typeof(T), out instance);
            if (instance == null || instance.IsDisposed)
            {
                instance = new T();
                openForms[typeof(T)] = instance;
                instance.MdiParent = form;
                instance.Show();
            }
            else
            {
                instance.Activate();
            }
        }
    }
}
