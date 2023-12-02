using System;
using System.Windows.Forms;

namespace StoreTask.Views
{
    public partial class LoginView : Form, ILoginView
    {
        private string message;
        public LoginView()
        {
            InitializeComponent();
            btnLogin.Click += delegate { LoginEvent?.Invoke(this, EventArgs.Empty); };
            btnExit.Click += delegate { ExitEvent?.Invoke(this, EventArgs.Empty); };
            btnClear.Click += delegate { ClearEvent?.Invoke(this, EventArgs.Empty); };
        }

        public string UserName
        {
            get { return txtUserName.Text; }
            set { txtUserName.Text = value; }
        }
        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public event EventHandler LoginEvent;
        public event EventHandler ClearEvent;
        public event EventHandler ExitEvent;

        public void CloseForm()
        {
            this.Hide();
        }
    }
}
