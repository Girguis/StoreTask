using StoreTask._Repository;
using StoreTask.Models;
using StoreTask.Presenters;
using StoreTask.Views;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace StoreTask
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string connectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;

            ILoginView loginView = new LoginView();
            IUserRepo userRepo = new UserRepo(connectionString);
            new LoginPresenter(loginView, userRepo);
            Application.Run((Form)loginView);
        }
    }
}
