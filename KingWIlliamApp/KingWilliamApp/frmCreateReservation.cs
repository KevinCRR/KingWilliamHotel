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
    public partial class frmCreateReservation : Form
    {
        private Customer UseCustomer;

        public frmCreateReservation(Customer useCustomer)
        {
            InitializeComponent();
            UseCustomer = useCustomer;
        }

        private void frmCreateReservation_Load(object sender, EventArgs e)
        {
            lblCustomerName.Text = UseCustomer.FirstName + " " + UseCustomer.LastName;

            try
            {
                string pastRoomsMessage = "";
                List<String> pastRooms = UseCustomer.GetPastRooms();

                if (pastRooms.Count > 1)
                {
                    pastRoomsMessage = "This customer previously stayed in rooms:  ";

                    foreach (string p in pastRooms)
                    {
                        pastRoomsMessage = pastRoomsMessage + p + "  ";
                    }
                }

                lblPastRooms.Text = pastRoomsMessage;
            }
            catch (Exception)
            {
                lblPastRooms.Text = "";
            }

            cbxRoom.ValueMember = "roomNumber";
            cbxRoom.DataSource = Room.GetAllRooms();

            ShowRoomPrice();
        }

        private void cbxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowRoomPrice();
        }

        private void ShowRoomPrice()
        {
            int selectedRoom = int.Parse(cbxRoom.SelectedValue.ToString());
            try
            {
                txtCost.Text = Room.GetRoomPrice(selectedRoom).ToString("#,0.00");
            }
            catch (Exception)
            {
                txtCost.Text = "";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                lblMessage.Text = "";

                Reservation newReservation = new Reservation(dateStart.Value, dateEnd.Value, int.Parse(cbxRoom.SelectedValue.ToString()), int.Parse(nudGuests.Value.ToString()), txtNotes.Text.Trim(), UseCustomer.CustomerID);
                newReservation.InsertReservation();

                MessageBox.Show("Reservation created successfully!", "Success");
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
