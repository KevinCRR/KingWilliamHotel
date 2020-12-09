﻿using System;
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
    public partial class frmEditReservations : Form
    {
        private Reservation EditReservation;
        public frmEditReservations(Reservation editReservation)
        {
            InitializeComponent();
            EditReservation = editReservation;
        }

        private void frmEditReservations_Load(object sender, EventArgs e)
        {
            DataTable dt = Room.GetAllRooms();

            cbxRoom.DataSource = dt;
            cbxRoom.ValueMember = "roomNumber";

            int index = -1;
            string search = "roomNumber = " + EditReservation.RoomNumber.ToString();

            DataRow[] rows = dt.Select(search);
            if (rows.Count() > 0)
                index = dt.Rows.IndexOf(rows[0]);

            cbxRoom.SelectedIndex = index;


            dateStart.Value = EditReservation.StartDate;
            dateEnd.Value = EditReservation.EndDate;
            nudGuests.Value = EditReservation.NumberOfGuests;
            txtNotes.Text = EditReservation.Notes;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                lblMessage.Text = "";

                Reservation updateReservation = new Reservation(EditReservation.ReservationID, dateStart.Value, dateEnd.Value, 
                    int.Parse(cbxRoom.SelectedValue.ToString()), int.Parse(nudGuests.Value.ToString()), txtNotes.Text.Trim(), 
                    EditReservation.CustomerID, EditReservation.BillID);
                updateReservation.UpdateReservation();

                MessageBox.Show("Reservation updated successfully!", "Success");
                this.Close();
            }
            catch (ArgumentNullException ex)
            {
                lblMessage.Text = ex.Message;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                lblMessage.Text = ex.Message;
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
        }
    }
}
