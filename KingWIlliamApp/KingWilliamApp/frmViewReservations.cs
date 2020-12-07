using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingWilliamApp
{
    public partial class frmViewReservations : Form
    {
        public frmViewReservations()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //if (this.Parent == null)
            //    return;

            //frmCreateReservation createForm = new frmCreateReservation();

            //createForm.TopLevel = false;
            //createForm.FormBorderStyle = FormBorderStyle.None;
            //createForm.Dock = DockStyle.Fill;

            ////Panel pnlChildForm = (this.Parent as frmMainForm).Controls["pnlChildForm"] as Panel;
            ////pnlChildForm.Controls.Add(createForm);
            ////pnlChildForm.Tag = createForm;

            //Panel pnlContainer = (Parent.Controls["pnlChildForm"] as Panel);
            //pnlContainer.Controls.Add(createForm);
            //pnlContainer.Tag = createForm;

            //createForm.BringToFront();
            //createForm.Show();
        }

        private void frmViewReservations_Load(object sender, EventArgs e)
        {
            dtFromDate.Value = DateTime.Today;
            PopulateData(Reservation.GetAll(dtFromDate.Value));
        }

        private void dtFromDate_ValueChanged(object sender, EventArgs e)
        {
            PopulateData(Reservation.GetAll(dtFromDate.Value));
        }

        void PopulateData(List<Reservation> reservations)
        {
            dgvReservations.Rows.Clear();
            foreach (Reservation r in reservations)
            {
                dgvReservations.Rows.Add(new object[]
                {
                    r.ReservationID,
                    r.StartDate,
                    r.EndDate,
                    r.RoomNumber,
                    r.NumberOfGuests,
                    r.CustomerID,
                    r.BillID,
                    r.Notes,
                    "Edit",
                    "Delete"
                });
                dgvReservations.Rows[dgvReservations.RowCount - 1].Tag = r;
            }
        }

        private void dgvReservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8) // edit
            {
                // edit form
            }
            if (e.ColumnIndex == 9)
            {
                // delete
            }
        }
    }
}
