using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecursosHumanosGithub.Model;
using RecursosHumanosGithub._Repository;
using RecursosHumanosGithub.View;
using RecursosHumanosGithub.Presenter;
using System.Configuration;



namespace RecursosHumanosGithub
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString;
            IMainView view = new MainView();
            new MainPresenter(view,sqlConnectionString);
            Application.Run((Form)view);
        }
    }
}
