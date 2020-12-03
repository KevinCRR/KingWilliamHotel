using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingWilliamApp
{
    public partial class frmCreateUsers : Form
    {
        public frmCreateUsers()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                User newUser;
                lblMessage.Text = "";

                newUser = new User(txtUsername.Text.Trim(), txtPassword.Text.Trim(), cbxRoles.Text.Trim(), txtStaffID.Text.Trim());
                newUser.InsertUser();
            }
            catch (ArgumentNullException ex)
            {
                lblMessage.Text = "No entry! " + ex.Message;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                lblMessage.Text = "Entry out-of-range! " + ex.Message;
            }
            catch (ArgumentException ex)
            {
                lblMessage.Text = ex.Message;
            }
            // Respond to DataExceptions referencing the database and the inner exception thrown during the database operation
            catch (DataException ex)
            {
                lblMessage.Text = "Database error! " + ex.Message + "\n\n" +
                    ex.InnerException.Message + "\n\n" + ex.Source + "\n\n" + ex.Message +
                    "\n\n" + ex.StackTrace;
            }
            // Catch other unanticipated exceptions and provide as much debugging info as possible.
            catch (Exception ex)
            {
                lblMessage.Text = "An unknown error has occurred in " + ex.Source + "! Please contact your IT department and provide the following details:\n\n" + ex.Message + "\n\n" + ex.StackTrace + "\n\nUnknown Error!";
            }
            finally
            {
                if (lblMessage.Text == "")
                    lblMessage.Text = "Success!";
            }
        }

        private void frmCreateUsers_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(Properties.Settings.Default.connectionString);

            try
            {
                sqlcon.Open();

                SqlCommand sqlRoles = new SqlCommand("SELECT (roleID) FROM roles", sqlcon);
                SqlDataReader readerRoles;
                readerRoles = sqlRoles.ExecuteReader();
                DataTable dtRoles = new DataTable();
                dtRoles.Columns.Add("roleID", typeof(string));
                dtRoles.Load(readerRoles);
                cbxRoles.ValueMember = "roleID";
                cbxRoles.DataSource = dtRoles;

                sqlcon.Close();
            }
            catch (Exception) { }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
