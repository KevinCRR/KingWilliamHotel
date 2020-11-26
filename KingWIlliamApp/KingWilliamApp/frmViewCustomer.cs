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

        public void btnSearch_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string phoneNum = txtPhone.Text;
            string errorMsg = null;

            int custID = -1;
            string firstName1;
            string lastName1;
            string phoneNum1;
            int address = -1;

     
            string addressLine1;
            string addressLine2;
            string city;
            string provinceCode;
            string country;
            string postalCode;
            string provinceName;


            Customer customerRecord = null;

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
                        string oString2 = "SELECT * FROM address WHERE addressID=@addressId;";
                        string oString3 = "SELECT * FROM reservations WHERE customerID=@customerID";
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
                                    MessageBox.Show("User Record Found!");
                                    var custom = oReader;
                                    custID = Convert.ToInt32(oReader["customerID"].ToString());
                                    firstName1 = oReader["FirstName"].ToString();
                                    lastName1 = oReader["LastName"].ToString();
                                    phoneNum1 = oReader["phoneNumber"].ToString();
                                    address = Convert.ToInt32(oReader["addressID"].ToString());

                                    customerRecord = new Customer(firstName1, lastName1, phoneNum1, address);
                                }
                                else
                                {
                                    errorMsg = "Record Not Found!";
                                }

                                myConnection.Close();

                                if(address > -1)
                                {
                                    SqlCommand oCmd2 = new SqlCommand(oString2, myConnection);
                                    oCmd2.Parameters.AddWithValue("@addressId", address);
                                    myConnection.Open();
                                    using (SqlDataReader oReader2 = oCmd.ExecuteReader())
                                    {
                                        if (oReader2.Read())
                                        {
                                            var addressRecord = oReader2;
                                            MessageBox.Show("Address Records Found");
                                        }
                                        else
                                        {
                                            errorMsg = "Address Record Not Found!";
                                        }
                                    }
                                    myConnection.Close();
                                }

                                if (custID>-1)
                                {
                                    SqlCommand oCmd3 = new SqlCommand(oString3, myConnection);
                                    oCmd3.Parameters.AddWithValue("@customerID", custID);
                                    myConnection.Open();
                                    using (SqlDataReader oReader3 = oCmd.ExecuteReader())
                                    {
                                        if (oReader3.Read())
                                        {
                                            var reservationRecords = oReader3;
                                            MessageBox.Show("Reservation Records Found");

                                        }
                                        else
                                        {
                                            MessageBox.Show("Reservation Records Not Found!");
                                        }
                                    }
                                    myConnection.Close();
                                }

                            }
                        }

                        if(customerRecord!= null)
                        {
                            frmCreateCustomer f = new frmCreateCustomer(customerRecord);

                            f.MdiParent = this;
                            f.StartPosition = FormStartPosition.CenterParent;
                            f.Show();
                        }

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

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
