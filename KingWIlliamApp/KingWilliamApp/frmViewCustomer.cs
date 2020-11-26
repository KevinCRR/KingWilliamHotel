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
using System.Data;

namespace KingWilliamApp
{
    public partial class frmViewCustomer : Form
    {
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        public frmViewCustomer()
        {
            InitializeComponent();
        }

        private void pnlColumn3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlColumn2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string phoneNum = txtPhone.Text;
            string errorMsg = null;

            int custID;
            string firstName1;
            string lastName1;
            string phoneNum1;
            int address;

            Customer customerRecord;

            if (firstName == "")
            {
                errorMsg = string.Concat("- You Must Enter a First Name!\n");
            }
            else if(firstName.Any(char.IsDigit))
            {
                errorMsg = string.Concat("- First Name Cannot Contain Numbers!\n");
            }

            if (lastName == "")
            {
                errorMsg = string.Concat("- You Must Enter a Last Name!\n");
            }
            else if (lastName.Any(char.IsDigit))
            {
                errorMsg = string.Concat("- Last Name Cannot Contain Numbers!\n");
            }

            if(phoneNum == "")
            {
                errorMsg = string.Concat("- Phone Number Cannot Be Empty!\n");
            }
            else if (!IsDigitsOnly(phoneNum))
            {
                errorMsg = string.Concat("- Phone Number Field Cannot Cotain Non-Numerical Characters!\nExample of Acceptible Phone Number: 9052223333\n");
            }


            if(errorMsg == null)
            {
                MessageBox.Show(phoneNum);
                long phone;
                if (long.TryParse(phoneNum, out phone))
                {
                    try
                    {
                        phoneNum = string.Format("{0:###-###-####}", phone);
                        //Marcelia
                        //Brain
                        //4055306195
                        string oString = "SELECT * FROM customers WHERE firstName=@firstName AND lastName=@lastName AND phoneNumber=@phoneNumber;";
                        using (SqlConnection myConnection = new SqlConnection(Properties.Settings.Default.connectionString))
                        {
                            SqlCommand oCmd = new SqlCommand(oString, myConnection);
                            oCmd.Parameters.AddWithValue("@firstName", firstName);
                            oCmd.Parameters.AddWithValue("@lastName", lastName);
                            oCmd.Parameters.AddWithValue("@phoneNumber", phoneNum);
                            myConnection.Open();
                            using (SqlDataReader oReader = oCmd.ExecuteReader())
                            {
                                if (oReader.Read())
                                {
                                    MessageBox.Show("Record Found!");
                                    custID = Convert.ToInt32(oReader["customerID"].ToString());
                                    firstName1 = oReader["FirstName"].ToString();
                                    lastName1 = oReader["LastName"].ToString();
                                    phoneNum1 = oReader["phoneNumber"].ToString();
                                    address = Convert.ToInt32(oReader["addressID"].ToString());

                                    customerRecord = new Customer(firstName1, lastName1, phoneNum1, address);
                                    MessageBox.Show("userMade!");

                                }
                                else
                                {
                                    MessageBox.Show("Record Not Found!");
                                    errorMsg = "Record Not Found!";
                                }

                                myConnection.Close();
                            }
                        }
                       frmCreateCustomer f = new frmCreateCustomer();

                        f.MdiParent = this;
                        f.StartPosition = FormStartPosition.CenterParent;
                        f.Show();
                        // //f.Visible = true;
                        // f.MdiParent = this.ParentForm;
                        // //f.Show();
                        // this.Hide();
                        // this.ParentForm.f.ShowDialog();
                        // this.Close();


                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error retrieving customer", ex);
                    }

                }
                else
                {
                    errorMsg = string.Concat("Weird error!?");
                }
                

            }

            if (errorMsg != null)
            {
                MessageBox.Show(errorMsg);
            }


        }
    }
}
