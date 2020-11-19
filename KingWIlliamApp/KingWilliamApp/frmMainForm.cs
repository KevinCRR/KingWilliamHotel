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
        }

        #region Event Handlers
        private void frmMainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            openChildForm(new frmViewReservations());
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            openChildForm(new frmViewRooms());
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            openChildForm(new frmViewClients());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            openChildForm(new frmViewStaff());
        }

        private void btnChargeableItems_Click(object sender, EventArgs e)
        {
            openChildForm(new frmViewChargeableItems());
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Application.Restart();  // Closes the program and starts a new instance which defaults to the login page. More secure option
        }

        #endregion Event Handlers

        #region Methods

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
