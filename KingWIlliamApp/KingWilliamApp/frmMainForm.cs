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

        private void btnReservations_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlReservations);
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlBills);
        }

        private void btnChargeableItems_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlChargeableItems);
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlRooms);
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlClients);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlStaff);
        }

        private void btnReservationView_Click(object sender, EventArgs e)
        {
            openChildForm(new frmViewReservations());
        }

        private void btnRoomView_Click(object sender, EventArgs e)
        {
            openChildForm(new frmViewRooms());
        }

        private void btnClientView_Click(object sender, EventArgs e)
        {
            openChildForm(new frmViewClients());
        }

        private void btnStaffView_Click(object sender, EventArgs e)
        {
            openChildForm(new frmViewStaff());
        }

        private void btnChargeableItemView_Click(object sender, EventArgs e)
        {
            openChildForm(new frmViewChargeableItems());
        }

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
            pnlRooms.Visible = false;
            pnlClients.Visible = false;
            pnlStaff.Visible = false;
        }

        private void hideSubMenu()
        {
            if (pnlReservations.Visible == true)
                pnlReservations.Visible = false;
            if (pnlBills.Visible == true)
                pnlBills.Visible = false;
            if (pnlChargeableItems.Visible == true)
                pnlChargeableItems.Visible = false;
            if (pnlRooms.Visible == true)
                pnlRooms.Visible = false;
            if (pnlClients.Visible == true)
                pnlClients.Visible = false;
            if (pnlStaff.Visible == true)
                pnlStaff.Visible = false;
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

        //public Form MainForm
        //{ 
        //    get { return this; }
        //}
    }
}
