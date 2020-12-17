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
    public partial class frmViewChargeableItems : Form
    {
        public frmViewChargeableItems()
        {
            InitializeComponent();
        }

        private void frmViewChargeableItems_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        public void RefreshList()
        {
            PopulateData(ChargeableItem.GetAll());
        }

        void PopulateData(List<ChargeableItem> items)
        {
            dgvItems.Rows.Clear();
            foreach (ChargeableItem i in items)
            {
                dgvItems.Rows.Add(new object[]
                {
                    i.ItemID,
                    i.ItemName,
                    i.ItemDescription,
                    i.ItemPrice,
                    "Delete"
                });
                dgvItems.Rows[dgvItems.RowCount - 1].Tag = i;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmCreateChargeableItem form = new frmCreateChargeableItem();
            form.ShowDialog();
            RefreshList();
        }

        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                // Delete
                ChargeableItem selectedItem = (ChargeableItem)dgvItems.CurrentRow.Tag;

                string message = "Are you sure you want to delete item (ItemID = " + selectedItem.ItemID + ")?";
                string title = "Delete User";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    // Delete reservation
                    try
                    {
                        if (selectedItem.Delete())
                        {
                            MessageBox.Show("Item successfully deleted!", "Success");
                            RefreshList();
                        }
                        else
                        {
                            MessageBox.Show("An error occured and the item could not be deleted!", "Failure");
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
    }
}
