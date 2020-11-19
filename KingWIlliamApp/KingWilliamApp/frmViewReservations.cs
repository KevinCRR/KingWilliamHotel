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

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {

        }

        public frmMainForm Parent { get; set; }
    }
}
