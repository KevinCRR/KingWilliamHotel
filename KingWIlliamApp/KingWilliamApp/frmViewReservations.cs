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

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmCreateCustomer formCreateCustomer = new frmCreateCustomer();
            formCreateCustomer.ShowDialog();
        }

        public static void OpenFormAsDialog(Form newForm)
        {
            newForm.ShowDialog();
        }

        
    }
}
