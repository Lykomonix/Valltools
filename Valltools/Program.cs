using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Valltools.formulaire;

namespace Valltools
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MenuHome());
            //Application.Run(new MenuMap());
            //Application.Run(new MenuAgent());
            Application.Run(new MenuRandom());
        }
    }
}
