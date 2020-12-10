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
    public partial class frmCreateTransactions : Form
    {
        private int BillID;

        public frmCreateTransactions(int billID)
        {
            InitializeComponent();

            BillID = billID;
        }

        private void frmCreateTransactions_Load(object sender, EventArgs e)
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
                    false,
                    i.ItemID,
                    i.ItemName,
                    i.ItemDescription,
                    i.ItemPrice
                });
                dgvItems.Rows[dgvItems.RowCount - 1].Tag = i;
            }
        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                row.Cells["Select"].Value = false;
            }

            //check select row
            dgvItems.CurrentRow.Cells["Select"].Value = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int selectedItem = 0;

            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                if ((bool)row.Cells["Select"].Value == true)
                {
                    selectedItem = (int)row.Cells["ID"].Value;
                }
            }

            if (selectedItem != 0)
            {
                try
                {
                    Transaction newTransaction = new Transaction(BillID, selectedItem, int.Parse(nudItems.Value.ToString()), DateTime.Now);
                    newTransaction.Insert();

                    MessageBox.Show("Transaction added successfully!", "Success");
                    this.Close();
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
