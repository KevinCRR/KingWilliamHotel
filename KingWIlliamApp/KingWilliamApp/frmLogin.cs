using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KingWilliamApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public bool IsLoggedIn { get; set; }

        public bool UserFullName { get; set; }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            String user = txtUsername.Text.Trim();
            String password = txtPassword.Text.Trim();

            if (User.GetUser(user, password) != null)
            {
                this.Close();
                IsLoggedIn = true;
            }
            else
            {
                MessageBox.Show("Incorrect username or password! Try again or contact an administrator.");
            }
        }
    }
}
