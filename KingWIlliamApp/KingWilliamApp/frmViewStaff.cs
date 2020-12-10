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
    public partial class frmViewStaff : Form
    {
        public frmViewStaff()
        {
            InitializeComponent();
        }

        private void frmViewStaff_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        public void RefreshList()
        {
            PopulateData(Staff.GetAll());
        }

        void PopulateData(List<Staff> staff)
        {
            dgvStaff.Rows.Clear();
            foreach (Staff s in staff)
            {
                dgvStaff.Rows.Add(new object[]
                {
                    s.StaffID,
                    s.FirstName,
                    s.LastName,
                    s.PhoneNumber,
                    s.AddressID,
                    s.PositionID,
                    s.Salary,
                    s.HiredDate,
                    s.TerminationDate,
                    "Edit",
                    "Delete"
                });
                dgvStaff.Rows[dgvStaff.RowCount - 1].Tag = s;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
