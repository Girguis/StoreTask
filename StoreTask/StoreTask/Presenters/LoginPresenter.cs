using StoreTask._Repository;
using StoreTask.Helpers;
using StoreTask.Models;
using StoreTask.Views;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace StoreTask.Presenters
{
    class LoginPresenter
    {
        private ILoginView view;
        private IUserRepo repository;

        public LoginPresenter(ILoginView view, IUserRepo repository)
        {
            this.view = view;
            this.repository = repository;
            this.view.ExitEvent += ExitApp;
            this.view.LoginEvent += Login;
            this.view.ClearEvent += Clear;
        }

        private void ExitApp(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(view.UserName))
            {
                MessageBox.Show("UserName is required");
                return;
            }
            if (string.IsNullOrEmpty(view.Password))
            {
                MessageBox.Show("Password is required");
                return;
            }
            bool isUserFound = repository.Login(new LoginModel
            {
                UserName = view.UserName,
                Password = PasswordHelper.Hash(view.Password)
            });
            if (!isUserFound)
            {
                MessageBox.Show("Invalid UserName or Password");
                return;
            }
            IHomeView homeView = new HomeView();
            string connectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            IProductRepo productRepo = new ProductRepo(connectionString);
            ICategoryRepo categoryRepo = new CategoryRepo(connectionString);
            var homePresenter = new HomePresenter(categoryRepo, productRepo, homeView);
            homePresenter.Show();
            view.CloseForm();
        }

        private void Clear(object sender, EventArgs e)
        {
            view.UserName = string.Empty;
            view.Password = string.Empty;
        }
    }
}
