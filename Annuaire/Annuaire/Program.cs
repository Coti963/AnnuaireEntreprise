using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Annuaire
{
    class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        public static Appli Fenetre;
        [STAThread]
        static void Main()
        {
            ManagerPerson managerPerson = new ManagerPerson();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Fenetre = new Appli();
                        
            Application.Run(Fenetre);
        }
    }
}
