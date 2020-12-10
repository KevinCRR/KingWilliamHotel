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
    public partial class frmViewBill : Form
    {
        private Bill currentBill = new Bill();

        public frmViewBill(int billID)
        {
            InitializeComponent();

            currentBill.BillID = billID;
        }

        private void frmViewBill_Load(object sender, EventArgs e)
        {
            // Try to get bill from database
            try
            {
                currentBill = Bill.GetBill(currentBill.BillID);

                RefreshList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occured! Could not open Bill. " + ex.ToString(), "Error");
                this.Close();
            }

            txtAmountOwing.Text = currentBill.AmountOwing.ToString();
            //txtBillAmount.Text = currentBill.BillAmount.ToString();       // this is calcualted based on transactions
            txtPaymentType.Text = currentBill.PaymentType;
        }

        public void RefreshList()
        {
            List<Transaction> trans;
            trans = Transaction.GetAllTransactions(currentBill.BillID);
            if (!trans.Equals(null))
            {
                PopulateData(trans, currentBill);
            }
            else
            {
                PopulateData(null, currentBill);
            }
        }

        void PopulateData(List<Transaction> transactions,Bill currentBill)
        {
            decimal billAmount = 0;
            decimal roomPrice;
            int index = 1;
            DateTime date = DateTime.Today;

            if (!transactions.Equals(null))
            {
                dgvTransactions.Rows.Clear();
                foreach (Transaction t in transactions)
                {
                    dgvTransactions.Rows.Add(new object[]
                    {
                        t.TransactionID,
                        t.ChargeableItem.ItemName,
                        t.ChargeableItem.ItemDescription,
                        t.ChargeableItem.ItemPrice,
                        t.AmountOfItems,
                        t.Date,
                        "Delete"
                    });
                    dgvTransactions.Rows[dgvTransactions.RowCount - 1].Tag = t;

                    // Calculate sum of transactions
                    billAmount += (t.ChargeableItem.ItemPrice * t.AmountOfItems);

                    if(t.TransactionID.ToString() != "" | t.TransactionID > 0 | !t.TransactionID.Equals(null))
                    {
                        date = transactions.First().Date;
                        index = transactions.Last().TransactionID + 1;
                    }
                }

               
                
            } 

            roomPrice = Convert.ToDecimal(currentBill.BillAmount) - billAmount;
            dgvTransactions.Rows.Add(new object[]
            {
                    index,
                    "Room Cost",
                    "Room",
                    roomPrice,
                    1,
                    date
            });



           
            txtBillAmount.Text = currentBill.BillAmount.ToString();
        }

        private void dgvTransactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                // Delete
                Transaction selectedTransaction = (Transaction)dgvTransactions.CurrentRow.Tag;

                string message = "Are you sure you want to delete transaction (ID = " + selectedTransaction.TransactionID + ")?";
                string title = "Delete Transaction";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    // Delete reservation
                    try
                    {
                        if (selectedTransaction.DeleteTransaction())
                        {
                            MessageBox.Show("Transaction successfully deleted!", "Success");
                            RefreshList();
                        }
                        else
                        {
                            MessageBox.Show("An error occured and the transaction could not be deleted!", "Failure");
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                lblMessage.Text = "";

                Bill updateBill = new Bill(currentBill.BillID, txtBillAmount.Text.Trim(), txtPaymentType.Text.Trim(),
                    txtAmountOwing.Text.Trim());
                updateBill.UpdateBill();

                MessageBox.Show("Bill updated successfully!", "Success");
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmCreateTransactions formCreateTransaction = new frmCreateTransactions(currentBill.BillID);
            formCreateTransaction.ShowDialog();

            RefreshList();
        }
    }
}
