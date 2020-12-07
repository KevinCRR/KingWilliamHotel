﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.Linq;

namespace KingWilliamApp
{
    class DBL
    {
        #region "Connection String"

        /// <summary>
        /// Return connection string
        /// </summary>
        /// <returns>Connection string</returns>
        private static string GetConnectionString()
        {
            return Properties.Settings.Default.connectionString;
        }

        #endregion

        //***********************************************************************************************************
        // INSERTS
        //***********************************************************************************************************

        #region "Insert Methods"  

        internal static int InsertNewAddress(Address insertAddress)
        {
            // Create return value
            int returnValue = 0;

            // Declare the connection
            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            // Create new SQL command and assign it paramaters
            SqlCommand command = new SqlCommand("INSERT INTO address VALUES(@addressLine1, @addressLine2, @city, @provinceID, @country, @postalCode)", dbConnection);
            command.Parameters.AddWithValue("@addressLine1", insertAddress.Address1);
            command.Parameters.AddWithValue("@addressLine2", insertAddress.Address2);
            command.Parameters.AddWithValue("@city", insertAddress.City);
            command.Parameters.AddWithValue("@provinceID", insertAddress.Province);
            command.Parameters.AddWithValue("@country", insertAddress.Country);
            command.Parameters.AddWithValue("@postalCode", insertAddress.PostalCode);

            // Try to insert the new record, return result
            try
            {
                dbConnection.Open();
                // Try to insert the new record, return result
                returnValue = (int)command.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw new DataException("Error in InsertNewAddress", ex);
            }
            finally
            {
                dbConnection.Close();
            }

            return returnValue;
        }

        internal static int InsertNewCustomer(Customer insertCustomer)
        {
            // Create return value
            int returnValue = 0;

            // Declare the connection
            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            // Create new SQL command and assign it paramaters
            SqlCommand command = new SqlCommand("INSERT INTO customers VALUES(@firstName, @lastName, @phoneNumber, @addressID)", dbConnection);
            command.Parameters.AddWithValue("@firstName", insertCustomer.FirstName);
            command.Parameters.AddWithValue("@lastName", insertCustomer.LastName);
            command.Parameters.AddWithValue("@phoneNumber", insertCustomer.PhoneNumber);
            command.Parameters.AddWithValue("@addressID", insertCustomer.AddressID);

            // Try to insert the new record, return result
            try
            {
                dbConnection.Open();
                // Try to insert the new record, return result
                returnValue = (int)command.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw new DataException("Error in InsertNewCustomer", ex);
            }
            finally
            {
                dbConnection.Close();
            }

            return returnValue;
        }

        internal static int InsertNewReservation(Reservation insertReservation)
        {
            // Create return value
            int returnValue = 0;

            // Declare the connection
            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            // Create new SQL command and assign it paramaters
            SqlCommand command = new SqlCommand("INSERT INTO reservations VALUES(@numberOfGuests, @startDate, @endDate, @notes, @customerID, @billID, @roomNumber)", dbConnection);
            command.Parameters.AddWithValue("@numberOfGuests", insertReservation.NumberOfGuests);
            command.Parameters.AddWithValue("@startDate", insertReservation.StartDate);
            command.Parameters.AddWithValue("@endDate", insertReservation.EndDate);
            command.Parameters.AddWithValue("@notes", insertReservation.Notes);
            command.Parameters.AddWithValue("@customerID", insertReservation.CustomerID);
            command.Parameters.AddWithValue("@billID", insertReservation.BillID);
            command.Parameters.AddWithValue("@roomNumber", insertReservation.RoomNumber);

            // Try to insert the new record, return result
            try
            {
                dbConnection.Open();
                // Try to insert the new record, return result
                returnValue = (int)command.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw new DataException("Error in InsertNewReservation", ex);
            }
            finally
            {
                dbConnection.Close();
            }

            return returnValue;
        }

        internal static int InsertNewBill(Bill insertBill)
        {
            // Create return value
            int returnValue = 0;

            // Declare the connection
            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            // Create new SQL command and assign it paramaters
            SqlCommand command = new SqlCommand("INSERT INTO customerBilling VALUES(@billAmount, @paymentType, @amountOwing)", dbConnection);
            command.Parameters.AddWithValue("@billAmount", insertBill.BillAmount);
            command.Parameters.AddWithValue("@paymentType", insertBill.PaymentType);
            command.Parameters.AddWithValue("@amountOwing", insertBill.AmountOwing);

            // Try to insert the new record, return result
            try
            {
                dbConnection.Open();
                // Try to insert the new record, return result
                returnValue = (int)command.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw new DataException("Error in InsertNewBill", ex);
            }
            finally
            {
                dbConnection.Close();
            }

            return returnValue;
        }

        internal static bool InsertNewUser(User insertUser)
        {
            // Create return value
            bool returnValue = false;

            // Declare the connection
            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            // Hashing
            Byte[] inputBytes = Encoding.UTF8.GetBytes(insertUser.Password);
            SHA512 shaM = new SHA512Managed();
            Byte[] hashedBytes = shaM.ComputeHash(inputBytes);

            string hashedpassword = Convert.ToBase64String(hashedBytes);

            // Create new SQL command and assign it paramaters
            SqlCommand command = new SqlCommand("INSERT INTO users VALUES(@username, @password, @roleID, @staffID)", dbConnection);
            command.Parameters.AddWithValue("@username", insertUser.Username);
            command.Parameters.AddWithValue("@password", hashedpassword);
            command.Parameters.AddWithValue("@roleID", insertUser.RoleID);
            command.Parameters.AddWithValue("@staffID", insertUser.StaffID);

            // Try to insert the new record, return result
            try
            {
                dbConnection.Open();
                // Try to insert the new record, return result
                returnValue = (command.ExecuteNonQuery() == 1);

            }
            catch (Exception ex)
            {
                throw new DataException("Error in InsertNewUser", ex);
            }
            finally
            {
                dbConnection.Close();
            }

            return returnValue;
        }

        #endregion "Insert Methods"  

        //***********************************************************************************************************
        // SELECTS
        //***********************************************************************************************************

        #region "Select Methods"

        internal static User SelectUser(string username, string password)
        {
            User returnUser = new User();

            // Declare new SQL connection
            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            // Hashing
            Byte[] inputBytes = Encoding.UTF8.GetBytes(password);
            SHA512 shaM = new SHA512Managed();
            Byte[] hashedBytes = shaM.ComputeHash(inputBytes);

            string hashedpassword = Convert.ToBase64String(hashedBytes);

            // Create new SQL command
            SqlCommand command = new SqlCommand("SELECT * FROM users WHERE userName = @username AND password = @password", dbConnection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", hashedpassword);

            // Try to connect to the database, create a datareader. If successful, read from the database and fill created row
            // with information from matching record
            try
            {
                dbConnection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        returnUser = new User(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3).ToString());
                    }
                }                
                else  //showing the error message if user credential is wrong  
                {
                    throw new ArgumentException("User does not Exist", "Not Found");
                }
                reader.Close();
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException("User does not Exist", "Not Found");
            }
            catch (Exception ex)
            {
                throw new DataException("Error in GetUser", ex);
            }
            finally
            {
                dbConnection.Close();
            }

            // Return the populated row
            return returnUser;
        }

        internal static bool UserExists(string username)
        {
            bool returnValue = false;

            // Declare new SQL connection
            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            // Create new SQL command
            SqlCommand command = new SqlCommand("SELECT * FROM users WHERE userName = @username", dbConnection);
            command.Parameters.AddWithValue("@username", username);

            // Try to connect to the database, create a datareader. If successful, read from the database and fill created row
            // with information from matching record
            try
            {
                dbConnection.Open();

                returnValue = (command.ExecuteNonQuery() == 1);
            }
            catch (Exception ex)
            {
                throw new DataException("Error in GetUser", ex);
            }
            finally
            {
                dbConnection.Close();
            }

            // Return the populated row
            return returnValue;
        }

        internal static Staff SelectStaff(int staffID)
        {
            Staff returnStaff = new Staff();

            // Declare new SQL connection
            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            string sql = "SELECT * FROM staff WHERE staffID = '" + staffID + "'";

            // Create new SQL command
            SqlCommand command = new SqlCommand(sql, dbConnection);

            // Try to connect to the database, create a datareader. If successful, read from the database and fill created row
            // with information from matching record
            try
            {
                dbConnection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        returnStaff = new Staff(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), 
                            reader.GetString(3), reader.GetDouble(4), reader.GetDateTime(5), reader.GetDateTime(6),
                            reader.GetString(7), reader.GetInt32(8), reader.GetInt32(9));
                    }
                }
                else
                {
                    //throw new DataException("No records found", ex);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new DataException("Error in GetUser", ex);
            }
            finally
            {
                dbConnection.Close();
            }

            // Return the populated row
            return returnStaff;

        }

        internal static string SelectRoleTitle(string roleID)
        {
            string returnRole;

            // Declare new SQL connection
            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            string sql = "SELECT (roleTitle) FROM roles WHERE roleID = '" + roleID + "'";

            // Create new SQL command
            SqlCommand command = new SqlCommand(sql, dbConnection);

            // Try to connect to the database, create a datareader. If successful, read from the database and fill created row
            // with information from matching record
            try
            {
                dbConnection.Open();

                returnRole = (String)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new DataException("Error in GetRoleTitle", ex);
            }
            finally
            {
                dbConnection.Close();
            }

            // Return the populated row
            return returnRole;
        }

        internal static List<Reservation> SelectAllReservations(DateTime fromDate)
        {
            List<Reservation> returnList = new List<Reservation> { };

            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            SqlCommand command = new SqlCommand("SELECT * FROM reservations WHERE startDate > @fromDate ORDER BY startDate ASC", dbConnection);
            command.Parameters.AddWithValue("@fromDate", fromDate);

            try
            {
                dbConnection.Open();

                Reservation temp = new Reservation();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read() && returnList.Count() < 25)
                    {
                        //temp.ReservationID = reader.GetInt32(0);
                        //temp.StartDate = reader.GetDateTime(5);
                        //temp.EndDate = reader.GetDateTime(6);
                        //temp.NumberOfGuests = reader.GetInt32(4);
                        //temp.RoomNumber = reader.GetInt32(1);
                        //temp.CustomerID = reader.GetInt32(2);
                        //temp.BillID = reader.GetInt32(3);
                        //temp.Notes = "null";

                        temp = new Reservation(
                            reader.GetInt32(0),         // id
                            reader.GetDateTime(5),      // startDate
                            reader.GetDateTime(6),      // endDate
                            reader.GetInt32(4),         // numberOfGuests
                            reader.GetInt32(1),         // roomNumber
                            reader.GetInt32(2),         // customerID
                            reader.GetInt32(3),         // billID
                            "null");  //reader.GetString(7));      // notes

                        returnList.Add(temp);

                        //returnList.Add(new Reservation(
                        //    reader.GetInt32(0),         // id
                        //    reader.GetDateTime(5),      // startDate
                        //    reader.GetDateTime(6),      // endDate
                        //    reader.GetInt32(4),         // numberOfGuests
                        //    reader.GetInt32(1),         // roomNumber
                        //    reader.GetInt32(2),         // customerID
                        //    reader.GetInt32(3),         // billID
                        //    reader.GetString(7)));      // notes
                    }
                }
                
            }
            catch (Exception ex)
            {
                throw new DataException("Error in GetAllReservations", ex);
            }
            finally
            {
                dbConnection.Close();
            }

            return returnList;
        }

        #endregion

        #region "Delete Methods"

        internal static bool DeleteUser(string username, int staffID)
        {
            // Create return value
            bool returnValue = false;

            // Declare the connection
            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            // Create new SQL command and assign it paramaters
            SqlCommand command = new SqlCommand("DELETE FROM users WHERE userName = @username AND staffID = @staffID", dbConnection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@staffID", staffID);

            // Try to insert the new record, return result
            try
            {
                dbConnection.Open();
                // Try to insert the new record, return result
                returnValue = (command.ExecuteNonQuery() == 1);

            }
            catch (Exception ex)
            {
                throw new DataException("Error in DeleteUser", ex);
            }
            finally
            {
                dbConnection.Close();
            }

            return returnValue;
        }

        #endregion

    }
}
