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
            //btnReservations.Visible = false;
            //btnBills.Visible = false;
            //btnChargeableItems.Visible = false;
            //btnCustomers.Visible = false;
            //btnStaff.Visible = false;
            //btnTransactions.Visible = false;
            //btnUsers.Visible = false;
            //btnRoomTypes.Visible = false;
            //btnRooms.Visible = false;
            //btnEmploymentPositions.Visible = false;
            //IsMdiContainer = true;


        }

        #region Event Handlers
        private void frmMainForm_Load(object sender, EventArgs e)
        {
            //Staff currentStaff = DBL.SelectStaff(User.CurrentUser.StaffID);
            //lblUserName.Text = currentStaff.FirstName + " " + currentStaff.LastName;n   

            lblUserRole.Text = DBL.SelectRoleTitle(User.CurrentUser.RoleID);

            if (User.CurrentUser.ToString() == "Admin")
            {
                btnReservations.Visible = true;
                btnBills.Visible = true;
                btnChargeableItems.Visible = true;
                btnCustomers.Visible = true;
                btnStaff.Visible = true;
                btnTransactions.Visible = true;
                btnUsers.Visible = true;
                btnRoomTypes.Visible = true;
                btnRooms.Visible = true;
                btnEmploymentPositions.Visible = true;
            }
            else if (User.CurrentUser.ToString() == "Manager")
            {
                btnReservations.Visible = true;
                btnBills.Visible = true;
                btnCustomers.Visible = true;
                btnStaff.Visible = true;
                btnTransactions.Visible = true;
                btnUsers.Visible = true;
                btnRoomTypes.Visible = true;
                btnRooms.Visible = true;
            }
            else if (User.CurrentUser.ToString() == "FrontD")
            {
                btnReservations.Visible = false;
                btnBills.Visible = false;
                btnChargeableItems.Visible = false;
                btnCustomers.Visible = false;
                btnStaff.Visible = false;
                btnTransactions.Visible = false;
                btnUsers.Visible = false;
                btnRoomTypes.Visible = false;
                btnRooms.Visible = false;
                btnEmploymentPositions.Visible = false;
                btnReservations.Visible = true;
                btnBills.Visible = true;
                btnCustomers.Visible = true;
            }
            else if (User.CurrentUser.ToString() == "roomS")
            {
                btnReservations.Visible = true;
                btnBills.Visible = true;
            }
            else if (User.CurrentUser.ToString() == "KitchenS")
            {
                btnReservations.Visible = true;
                btnBills.Visible = true;
            }
            else if (User.CurrentUser.ToString() == "accountingAndStock")
            {
                btnReservations.Visible = true;
                btnBills.Visible = true;
            }


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

        #endregion Reservations

        #region Bills
        private void btnBills_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlBills);
        }

        private void btnBillView_Click(object sender, EventArgs e)
        {
            openChildForm(new frmViewBill());
            
        }

        private void btnBillEdit_Click(object sender, EventArgs e)
        {
            openChildForm(new frmEditBill());
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
            openChildForm(new frmCreateChargeableItem());
        }

        private void btnChargeableItemEdit_Click(object sender, EventArgs e)
        {
            openChildForm(new frmEditChargeableItem());
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
            openChildForm(new frmViewTransactions());
        }

        private void btnTransactionCreate_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCreateTransactions());
        }

        private void btnTransactionEdit_Click(object sender, EventArgs e)
        {
            openChildForm(new frmEditTransactions());
        }

        #endregion Transactions

        #region Rooms
        private void btnRooms_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlRooms);
        }

        private void btnRoomView_Click(object sender, EventArgs e)
        {
            openChildForm(new frmViewRoom());
        }

        private void btnRoomEdit_Click(object sender, EventArgs e)
        {
            openChildForm(new frmEditRoom());
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
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlClients);
        }

        private void btnCustomerView_Click(object sender, EventArgs e)
        {
            openChildForm(new frmViewCustomer());
        }

        private void btnCustomerCreate_Click(object sender, EventArgs e)
        {
            Customer customer = null;
            openChildForm(new frmCreateCustomer(customer));
        }

        private void btnCustomerEdit_Click(object sender, EventArgs e)
        {
            openChildForm(new frmEditCustomer());
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
            openChildForm(new frmCreateStaff());
        }

        private void btnStaffEdit_Click(object sender, EventArgs e)
        {
            openChildForm(new frmEditStaff());
        }
        #endregion Staff

        #region Employment Positions
        private void btnEmploymentPositions_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlEmploymentPositions);
        }

        private void btnEmploymentPositionView_Click(object sender, EventArgs e)
        {
            openChildForm(new frmViewEmployementPositions());
        }

        private void btnEmploymentPositionCreate_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCreateEmploymentPositions());
        }

        private void btnEmploymentPositionEdit_Click(object sender, EventArgs e)
        {
            openChildForm(new frmEditEmployementPositions());
        }
        #endregion Employment Positions

        #region Users
        private void btnUsers_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlUsers);
        }

        private void btnUserView_Click(object sender, EventArgs e)
        {
            openChildForm(new frmViewUsers());
        }

        private void btnUserCreate_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCreateUsers());
        }

        private void btnUserEdit_Click(object sender, EventArgs e)
        {
            openChildForm(new frmEditUsers());

        }
        #endregion Users

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            User.CurrentUser = null;
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

    }
}
