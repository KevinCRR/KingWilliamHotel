using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingWilliamApp
{
    public partial class frmViewUsers : Form
    {
        public frmViewUsers()
        {
            InitializeComponent();
        }

        private void frmViewUsers_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        public void RefreshList()
        {
            PopulateData(User.GetAll());
        }

        void PopulateData(List<User> user)
        {
            dgvUsers.Rows.Clear();
            foreach (User u in user)
            {
                dgvUsers.Rows.Add(new object[]
                {
                    u.Username,
                    u.RoleID,
                    u.StaffID,
                    "Delete"
                });
                dgvUsers.Rows[dgvUsers.RowCount - 1].Tag = u;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmCreateUsers form = new frmCreateUsers();
            form.ShowDialog();
            RefreshList();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                // Delete
                User selectedUser = (User)dgvUsers.CurrentRow.Tag;

                string message = "Are you sure you want to delete user (Username = " + selectedUser.Username + ")?";
                string title = "Delete User";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    // Delete reservation
                    try
                    {
                        if (User.DeleteUser(selectedUser.Username, selectedUser.StaffID))
                        {
                            MessageBox.Show("User successfully deleted!", "Success");
                            RefreshList();
                        }
                        else
                        {
                            MessageBox.Show("An error occured and the user could not be deleted!", "Failure");
                        }
                    }
                    catch (DataException ex)
                    {
                        MessageBox.Show("Database error! " + ex.Message + "\n\n" +
                            ex.InnerException.Message + "\n\n" + ex.Source + "\n\n" + ex.Message +
                            "\n\n" + ex.StackTrace);
                    }
                    // Catch other unanticipated exceptions and provide as much debugging info as possible.
                    catch (Exception ex)
                    {
                        MessageBox.Show("An unknown error has occurred in " + ex.Source +
                            "! Please contact your IT department and provide the following details:\n\n" + ex.Message + "\n\n" + ex.StackTrace + "\n\nUnknown Error!");
                    }

                }
            }
        }
    }
}
