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
                    "Edit",
                    "Delete"
                });
                dgvUsers.Rows[dgvUsers.RowCount - 1].Tag = u;
            }
        }
    }
}
