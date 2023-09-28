using System;

using System.Windows.Forms;

using SattaTigerTS.WinApp.Operations;
using SattaTigerTS.Entities;

namespace SattaTigerTS.WinApp.Formlar
{
    public partial class frmLogin : Form
    {
        public bool isLoggedin = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtUsername.Text;
            string password = txtPassword.Text;

            ApiOperations ops = new ApiOperations();
            Globals.LoggedInApiUser = ops.AuthenticateUser(email, password);
            if (Globals.LoggedInApiUser == null || Globals.LoggedInApiUser.status != "200")
            {
                lblLoginStatus.Text= "Hatalı kullanıcı adı/parola ya da İnternet erişiminizi kontrol ediniz";
                //MessageBox.Show("Hatalı kullanıcı adı ya da parola");
                return;
            }

            if (Globals.LoggedInApiUser.status == "200")
            {
                lblLoginStatus.Text = Globals.LoggedInApiUser.response_message;
                //MessageBox.Show("Login successful");
                frmCenterFlu frmCenterFlu = new frmCenterFlu();
                frmCenterFlu.WindowState = FormWindowState.Maximized;
                frmCenterFlu.ShowDialog();
                isLoggedin = true;
                this.Close();
            }
        }
    }
}
