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
            cbxRoom.ValueMember = "roomNumber";
            cbxRoom.DataSource = Room.GetAllRooms();

            dateStart.Value = EditReservation.StartDate;
            dateEnd.Value = EditReservation.EndDate;
            cbxRoom.SelectedValue = EditReservation.RoomNumber;
            nudGuests.Value = EditReservation.NumberOfGuests;
            txtNotes.Text = EditReservation.Notes;
        }
    }
}
