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
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
            customizeDesign();
        }

        #region Event Handlers
        private void frmMainForm_Load(object sender, EventArgs e)
        {

        }

        #region Reservations
        private void btnReservations_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlReservations);
        }

        private void btnReservationView_Click(object sender, EventArgs e)
        {
            openChildForm(new frmViewReservations());
        }

        private void btnReservationCreate_Click(object sender, EventArgs e)
        {
            openChildForm(new frmEditReservation());
        }

        private void btnReservationEdit_Click(object sender, EventArgs e)
        {
            openChildForm(new frmEditReservations());
        }

        private void btnReservationDelete_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDeleteReservation());
        }
        #endregion Reservations

        #region Bills
        private void btnBills_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlBills);
        }

        private void btnBillView_Click(object sender, EventArgs e)
        {

        }

        private void btnBillEdit_Click(object sender, EventArgs e)
        {

        }
        #endregion Bills

        #region Chargeable Items 
        private void btnChargeableItems_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlChargeableItems);
        }

        private void btnChargeableItemView_Click(object sender, EventArgs e)
        {
            openChildForm(new frmViewChargeableItems());
        }

        private void btnChargeableItemCreate_Click(object sender, EventArgs e)
        {

        }

        private void btnChargeableItemEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnChargeableItemDelete_Click(object sender, EventArgs e)
        {

        }
        #endregion Chargeable Items

        #region Transactions
        private void btnTransactions_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlTransactions);
        }

        private void btnTransactionsView_Click(object sender, EventArgs e)
        {

        }

        private void btnTransactionCreate_Click(object sender, EventArgs e)
        {

        }

        private void btnTransactionEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnTransactionDelete_Click(object sender, EventArgs e)
        {

        }
        #endregion Transactions

        #region Rooms
        private void btnRooms_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlRooms);
        }

        private void btnRoomView_Click(object sender, EventArgs e)
        {
            openChildForm(new frmViewRooms());
        }

        private void btnRoomCreate_Click(object sender, EventArgs e)
        {

        }

        private void btnRoomEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnRoomDelete_Click(object sender, EventArgs e)
        {

        }
        #endregion Rooms

        #region Room Types
        private void btnRoomTypes_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlRoomTypes);
        }

        private void btnRoomTypeView_Click(object sender, EventArgs e)
        {

        }

        private void btnRoomTypeCreate_Click(object sender, EventArgs e)
        {

        }

        private void btnRoomTypeEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnRoomTypeDelete_Click(object sender, EventArgs e)
        {

        }
        #endregion Room Types

        #region Clients
        private void btnClients_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlClients);
        }

        private void btnClientView_Click(object sender, EventArgs e)
        {
            openChildForm(new frmViewClients());
        }

        private void btnClientCreate_Click(object sender, EventArgs e)
        {

        }

        private void btnClientEdit_Click(object sender, EventArgs e)
        {

        }
        #endregion Clients

        #region Staff
        private void btnStaff_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlStaff);
        }

        private void btnStaffView_Click(object sender, EventArgs e)
        {
            openChildForm(new frmViewStaff());
        }

        private void btnStaffCreate_Click(object sender, EventArgs e)
        {

        }

        private void btnStaffEdit_Click(object sender, EventArgs e)
        {

        }
        #endregion Staff

        #region Employment Positions
        private void btnEmploymentPositions_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlEmploymentPositions);
        }

        private void btnEmploymentPositionView_Click(object sender, EventArgs e)
        {

        }

        private void btnEmploymentPositionCreate_Click(object sender, EventArgs e)
        {

        }

        private void btnEmploymentPositionEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnEmploymentPositionDelete_Click(object sender, EventArgs e)
        {

        }
        #endregion Employment Positions

        #region Users
        private void btnUsers_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlUsers);
        }

        private void btnUserView_Click(object sender, EventArgs e)
        {

        }
        #endregion Users

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Application.Restart();  // Closes the program and starts a new instance which defaults to the login page. More secure option
        }

        #endregion Event Handlers

        #region Methods

        private void customizeDesign()
        {
            pnlReservations.Visible = false;
            pnlBills.Visible = false;
            pnlChargeableItems.Visible = false;
            pnlTransactions.Visible = false;
            pnlRooms.Visible = false;
            pnlRoomTypes.Visible = false;
            pnlClients.Visible = false;
            pnlStaff.Visible = false;
            pnlEmploymentPositions.Visible = false;
            pnlUsers.Visible = false;
        }

        private void hideSubMenu()
        {
            if (pnlReservations.Visible == true)
                pnlReservations.Visible = false;
            if (pnlBills.Visible == true)
                pnlBills.Visible = false;
            if (pnlChargeableItems.Visible == true)
                pnlChargeableItems.Visible = false;
            if (pnlTransactions.Visible == true)
                pnlTransactions.Visible = false;
            if (pnlRooms.Visible == true)
                pnlRooms.Visible = false;
            if (pnlRoomTypes.Visible == true)
                pnlRoomTypes.Visible = false;
            if (pnlClients.Visible == true)
                pnlClients.Visible = false;
            if (pnlStaff.Visible == true)
                pnlStaff.Visible = false;
            if (pnlEmploymentPositions.Visible == true)
                pnlEmploymentPositions.Visible = false;
            if (pnlUsers.Visible == true)
                pnlUsers.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #endregion Methods

        private void btnUserCreate_Click(object sender, EventArgs e)
        {

        }

        private void btnUserEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
