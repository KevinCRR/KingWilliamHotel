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
            RefreshList();
        }

        private void dtFromDate_ValueChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        public void RefreshList()
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
            if (e.ColumnIndex == 5)
            {
                // Edit Customer
                Reservation temp = (Reservation)dgvReservations.CurrentRow.Tag;
                frmEditCustomer formEditCustomer = new frmEditCustomer(temp.CustomerID);
                formEditCustomer.ShowDialog();
            }
            if (e.ColumnIndex == 6)
            {
                // Edit Bill
                Reservation temp = (Reservation)dgvReservations.CurrentRow.Tag;
                frmEditBill formEditBill = new frmEditBill(temp.BillID);
                formEditBill.ShowDialog();
            }
            if (e.ColumnIndex == 8)
            {
                // Edit
                frmEditReservations formEditReservation = new frmEditReservations((Reservation)dgvReservations.CurrentRow.Tag);
                formEditReservation.ShowDialog();
                RefreshList();
            }
            if (e.ColumnIndex == 9)
            {
                // Delete
                Reservation selectedReservation = (Reservation)dgvReservations.CurrentRow.Tag;

                string message = "Are you sure you want to delete reservation (ID = " + selectedReservation.ReservationID + ")?";
                string title = "Delete Reservation";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    // Delete reservation
                    try
                    {
                        if (selectedReservation.DeleteReservation())
                        {
                            MessageBox.Show("Reservation successfully deleted!", "Success");
                            RefreshList();
                        }
                        else
                        {
                            MessageBox.Show("An error occured and the reservation could not be deleted!", "Failure");
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
            frmCreateCustomer formCreateCustomer = new frmCreateCustomer();
            frmFindCustomer formFindCustomer = new frmFindCustomer();

            DialogResult dr = new DialogResult();
            dr = formCreateCustomer.ShowDialog();
            if (dr == DialogResult.OK)
                formFindCustomer.ShowDialog();

            RefreshList();
        }        
    }
}
