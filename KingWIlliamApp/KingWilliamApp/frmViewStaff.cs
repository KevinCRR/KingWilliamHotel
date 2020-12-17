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
                string termination;
                if (s.TerminationDate < s.HiredDate)
                    termination = "";
                else
                    termination = s.TerminationDate.ToString();


                dgvStaff.Rows.Add(new object[]
                {
                    s.StaffID,
                    s.FirstName,
                    s.LastName,
                    s.PhoneNumber,
                    s.Salary,
                    s.HiredDate,
                    termination,
                    "Edit",
                    "Delete"
                });
                dgvStaff.Rows[dgvStaff.RowCount - 1].Tag = s;
            }
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                // Edit
                frmEditStaff formEditStaff = new frmEditStaff((Staff)dgvStaff.CurrentRow.Tag);
                formEditStaff.ShowDialog();
                RefreshList();
            }
            if (e.ColumnIndex == 8)
            {
                // Delete
                Staff selectedStaff = (Staff)dgvStaff.CurrentRow.Tag;

                string message = "Are you sure you want to delete staff (ID = " + selectedStaff.StaffID + ")?";
                string title = "Delete Staff";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    // Delete reservation
                    try
                    {
                        if (selectedStaff.DeleteStaff())
                        {
                            MessageBox.Show("Staff successfully deleted!", "Success");
                            RefreshList();
                        }
                        else
                        {
                            MessageBox.Show("An error occured and the staff could not be deleted!", "Failure");
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmCreateStaff formCreateStaff = new frmCreateStaff();
            formCreateStaff.ShowDialog();
            RefreshList();
        }
    }
}
