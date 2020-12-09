using System;
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
        // Reservation
        //***********************************************************************************************************

        #region Reservation

        internal static List<Reservation> SelectAllReservations(DateTime fromDate)
        {
            List<Reservation> returnList = new List<Reservation> { };

            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            SqlCommand command = new SqlCommand("SELECT * FROM reservations WHERE startDate >= @fromDate ORDER BY startDate ASC", dbConnection);
            command.Parameters.AddWithValue("@fromDate", fromDate);

            try
            {
                dbConnection.Open();

                Reservation temp = new Reservation();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read() && returnList.Count() < 25)
                    {
                        temp = new Reservation(
                            reader.GetInt32(0),         // id
                            reader.GetDateTime(5),      // startDate
                            reader.GetDateTime(6),      // endDate
                            reader.GetInt32(1),         // roomNumber
                            reader.GetInt32(4),         // numberOfGuests
                            SafeGetString(reader, 7),        // notes
                            reader.GetInt32(2),         // customerID
                            reader.GetInt32(3));        // billID
                            

                        returnList.Add(temp);
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

        internal static int InsertNewReservation(Reservation insertReservation)
        {
            // Create return value
            int returnValue = 0;

            // Declare the connection
            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            // Create new SQL command and assign it paramaters
            SqlCommand command = new SqlCommand("INSERT INTO reservations OUTPUT INSERTED.reservationID VALUES(@roomNumber, @customerID, @billID, @numberOfGuests, @startDate, @endDate, @notes)", dbConnection);
            command.Parameters.AddWithValue("@roomNumber", insertReservation.RoomNumber);
            command.Parameters.AddWithValue("@customerID", insertReservation.CustomerID);
            command.Parameters.AddWithValue("@billID", insertReservation.BillID);
            command.Parameters.AddWithValue("@numberOfGuests", insertReservation.NumberOfGuests);
            command.Parameters.AddWithValue("@startDate", insertReservation.StartDate);
            command.Parameters.AddWithValue("@endDate", insertReservation.EndDate);
            command.Parameters.AddWithValue("@notes", insertReservation.Notes);

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

        internal static bool UpdateReservation(Reservation updateReservation)
        {
            // Create return value
            bool returnValue = false;

            // Declare the connection
            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            // Create new SQL command and assign it paramaters
            SqlCommand command = new SqlCommand("UPDATE reservations SET roomNumber = @roomNumber, " +
                "numberOfGuests = @numberOfGuests, startDate = @startDate, endDate = @endDate, notes = @notes " +
                "WHERE reservationID = @reservationID", dbConnection);
            command.Parameters.AddWithValue("@roomNumber", updateReservation.RoomNumber);
            command.Parameters.AddWithValue("@numberOfGuests", updateReservation.NumberOfGuests);
            command.Parameters.AddWithValue("@startDate", updateReservation.StartDate);
            command.Parameters.AddWithValue("@endDate", updateReservation.EndDate);
            command.Parameters.AddWithValue("@notes", updateReservation.Notes);
            command.Parameters.AddWithValue("@reservationID", updateReservation.ReservationID);

            // Try to insert the new record, return result
            try
            {
                dbConnection.Open();
                // Try to insert the new record, return result
                returnValue = (command.ExecuteNonQuery() == 1);
            }
            catch (Exception ex)
            {
                throw new DataException("Error in UpdateReservation", ex);
            }
            finally
            {
                dbConnection.Close();
            }

            return returnValue;
        }

        internal static bool DeleteReservation(int reservationIDValue)
        {
            // Create return value
            bool returnValue = false;

            // Declare the connection
            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            // Create new SQL command and assign it paramaters
            SqlCommand command = new SqlCommand("DELETE FROM reservations WHERE reservationID = @id", dbConnection);
            command.Parameters.AddWithValue("@id", reservationIDValue);

            // Try to insert the new record, return result
            try
            {
                dbConnection.Open();
                // Try to insert the new record, return result
                returnValue = (command.ExecuteNonQuery() == 1);

            }
            catch (Exception ex)
            {
                throw new DataException("Error in DeleteReservation", ex);
            }
            finally
            {
                dbConnection.Close();
            }

            return returnValue;
        }

        internal static List<String> SelectPastRooms(int customerID)
        {
            List<String> returnList = new List<String> { };

            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            SqlCommand command = new SqlCommand("SELECT DISTINCT roomNumber FROM reservations WHERE customerID = @customerID", dbConnection);
            command.Parameters.AddWithValue("@customerID", customerID);

            try
            {
                dbConnection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read() && returnList.Count() < 5)
                    {
                        returnList.Add(reader.GetInt32(0).ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                throw new DataException("Error in GetPastRooms", ex);
            }
            finally
            {
                dbConnection.Close();
            }

            return returnList;
        }

        #endregion

        //***********************************************************************************************************
        // Customer
        //***********************************************************************************************************

        #region Customer

        internal static int InsertNewCustomer(Customer insertCustomer)
        {
            // Create return value
            int returnValue = 0;

            // Declare the connection
            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            // Create new SQL command and assign it paramaters
            SqlCommand command = new SqlCommand("INSERT INTO customers OUTPUT INSERTED.customerID VALUES(@firstName, @lastName, @phoneNumber, @addressID)", dbConnection);
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

        internal static int FindCustomer(Customer findCustomer)
        {
            // Create return value
            int returnValue = 0;

            // Declare the connection
            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            // Create new SQL command and assign it paramaters
            SqlCommand command = new SqlCommand("SELECT customerID FROM customers WHERE firstName = @firstName " +
                "AND lastName = @lastName AND phoneNumber = @phoneNumber", dbConnection);
            command.Parameters.AddWithValue("@firstName", findCustomer.FirstName);
            command.Parameters.AddWithValue("@lastName", findCustomer.LastName);
            command.Parameters.AddWithValue("@phoneNumber", findCustomer.PhoneNumber);

            // Try to insert the new record, return result
            try
            {
                dbConnection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        returnValue = reader.GetInt32(0);
                    }
                }
                else  //showing the error message if not found 
                {
                    ArgumentException ex = new ArgumentException("Not Found", "Customer does not exist");
                    throw ex;
                }
                reader.Close();
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new DataException("Error in FindCustomer", ex);
            }
            finally
            {
                dbConnection.Close();
            }

            return returnValue;
        }

        internal static Customer SelectCustomer(int customerIDValue)
        {
            // Create return value
            Customer returnCustomer = new Customer();

            // Declare new SQL connection
            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            // Create new SQL command
            SqlCommand command = new SqlCommand("SELECT * FROM customers WHERE customerID = @customerID", dbConnection);
            command.Parameters.AddWithValue("@customerID", customerIDValue);

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
                        returnCustomer = new Customer(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4));
                    }
                }
                else  //showing the error message if not found 
                {
                    ArgumentException ex = new ArgumentException("Not Found", "Customer was not found");
                    throw ex;
                }
                reader.Close();
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new DataException("Error in GetCustomer", ex);
            }
            finally
            {
                dbConnection.Close();
            }

            // Return the populated row
            return returnCustomer;
        }

        internal static bool UpdateCustomer(Customer updateCustomer)
        {
            // Create return value
            bool returnValue = false;

            // Declare the connection
            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            // Create new SQL command and assign it paramaters
            SqlCommand command = new SqlCommand("UPDATE customers SET firstName = @firstName, " +
                "lastName = @lastName, phoneNumber = @phoneNumber " +
                "WHERE customerID = @customerID", dbConnection);
            command.Parameters.AddWithValue("@firstName", updateCustomer.FirstName);
            command.Parameters.AddWithValue("@lastName", updateCustomer.LastName);
            command.Parameters.AddWithValue("@phoneNumber", updateCustomer.PhoneNumber);
            command.Parameters.AddWithValue("@customerID", updateCustomer.CustomerID);

            // Try to insert the new record, return result
            try
            {
                dbConnection.Open();
                // Try to insert the new record, return result
                returnValue = (command.ExecuteNonQuery() == 1);
            }
            catch (Exception ex)
            {
                throw new DataException("Error in UpdateCustomer", ex);
            }
            finally
            {
                dbConnection.Close();
            }

            return returnValue;
        }

        #endregion

        //***********************************************************************************************************
        // Address
        //***********************************************************************************************************

        #region Address

        internal static int InsertNewAddress(Address insertAddress)
        {
            // Create return value
            int returnValue = 0;

            // Declare the connection
            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            // Create new SQL command and assign it paramaters
            SqlCommand command = new SqlCommand("INSERT INTO address OUTPUT INSERTED.addressID VALUES(@addressLine1, @addressLine2, @city, @provinceCode, @country, @postalCode)", dbConnection);
            command.Parameters.AddWithValue("@addressLine1", insertAddress.Address1);
            command.Parameters.AddWithValue("@addressLine2", insertAddress.Address2);
            command.Parameters.AddWithValue("@city", insertAddress.City);
            command.Parameters.AddWithValue("@provinceCode", insertAddress.Province);
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

        internal static Address SelectAddress(int addressIDValue)
        {
            // Create return value
            Address returnAddress = new Address();

            // Declare new SQL connection
            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            // Create new SQL command
            SqlCommand command = new SqlCommand("SELECT * FROM address WHERE addressID = @addressID", dbConnection);
            command.Parameters.AddWithValue("@addressID", addressIDValue);

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
                        returnAddress = new Address(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
                    }
                }
                else  //showing the error message if not found 
                {
                    ArgumentException ex = new ArgumentException("Not Found", "Address was not found");
                    throw ex;
                }
                reader.Close();
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new DataException("Error in GetAddress", ex);
            }
            finally
            {
                dbConnection.Close();
            }

            // Return the populated row
            return returnAddress;
        }

        internal static bool UpdateAddress(Address updateAddress)
        {
            // Create return value
            bool returnValue = false;

            // Declare the connection
            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            // Create new SQL command and assign it paramaters
            SqlCommand command = new SqlCommand("UPDATE address SET addressLine1 = @addressLine1, " +
                "addressLine2 = @addressLine2, city = @city, provinceCode = @provinceCode, country = @country, postalCode = @postalCode " +
                "WHERE addressID = @addressID", dbConnection);
            command.Parameters.AddWithValue("@addressLine1", updateAddress.Address1);
            command.Parameters.AddWithValue("@addressLine2", updateAddress.Address2);
            command.Parameters.AddWithValue("@city", updateAddress.City);
            command.Parameters.AddWithValue("@provinceCode", updateAddress.Province);
            command.Parameters.AddWithValue("@country", updateAddress.Country);
            command.Parameters.AddWithValue("@postalCode", updateAddress.PostalCode);
            command.Parameters.AddWithValue("@addressID", updateAddress.AddressID);

            // Try to insert the new record, return result
            try
            {
                dbConnection.Open();
                // Try to insert the new record, return result
                returnValue = (command.ExecuteNonQuery() == 1);
            }
            catch (Exception ex)
            {
                throw new DataException("Error in UpdateAddress", ex);
            }
            finally
            {
                dbConnection.Close();
            }

            return returnValue;
        }

        internal static DataTable SelectAllProvinces()
        {
            DataTable returnDataTable = new DataTable();

            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            SqlCommand command = new SqlCommand("SELECT (provinceName) FROM provinces", dbConnection);

            try
            {
                dbConnection.Open();

                SqlDataReader readerProvinces;
                readerProvinces = command.ExecuteReader();

                returnDataTable.Columns.Add("provinceName", typeof(string));
                returnDataTable.Load(readerProvinces);

            }
            catch (Exception ex)
            {
                throw new DataException("Error in GetAllProvinces", ex);
            }
            finally
            {
                dbConnection.Close();
            }

            return returnDataTable;
        }

        #endregion

        //***********************************************************************************************************
        // Bill
        //***********************************************************************************************************

        #region Bill

        internal static int InsertNewBill(Bill insertBill)
        {
            // Create return value
            int returnValue = 0;

            // Declare the connection
            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            // Create new SQL command and assign it paramaters
            SqlCommand command = new SqlCommand("INSERT INTO customerBilling OUTPUT INSERTED.billID VALUES(@billAmount, @paymentType, @amountOwing)", dbConnection);
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

        internal static Bill SelectBill(int billIDValue)
        {
            // Create return value
            Bill returnBill = new Bill();

            // Declare new SQL connection
            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            // Create new SQL command
            SqlCommand command = new SqlCommand("SELECT * FROM customerBilling WHERE billID = @billID", dbConnection);
            command.Parameters.AddWithValue("@billID", billIDValue);

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
                        returnBill = new Bill(reader.GetInt32(0), reader.GetDecimal(1).ToString(), reader.GetString(2), reader.GetDecimal(3).ToString());
                    }
                }
                else  //showing the error message if not found 
                {
                    ArgumentException ex = new ArgumentException("Not Found", "Bill was not found");
                    throw ex;
                }
                reader.Close();
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new DataException("Error in GetBill", ex);
            }
            finally
            {
                dbConnection.Close();
            }

            // Return the populated row
            return returnBill;
        }

        internal static bool UpdateBill(Bill updateBill)
        {
            // Create return value
            bool returnValue = false;

            // Declare the connection
            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            // Create new SQL command and assign it paramaters
            SqlCommand command = new SqlCommand("UPDATE customerBilling SET billAmount = @billAmount, " +
                "paymentType = @paymentType, amountOwing = @amountOwing " +
                "WHERE billID = @billID", dbConnection);
            command.Parameters.AddWithValue("@billAmount", updateBill.BillAmount);
            command.Parameters.AddWithValue("@paymentType", updateBill.PaymentType);
            command.Parameters.AddWithValue("@amountOwing", updateBill.AmountOwing);
            command.Parameters.AddWithValue("@billID", updateBill.BillID);

            // Try to insert the new record, return result
            try
            {
                dbConnection.Open();
                // Try to insert the new record, return result
                returnValue = (command.ExecuteNonQuery() == 1);
            }
            catch (Exception ex)
            {
                throw new DataException("Error in UpdateBill", ex);
            }
            finally
            {
                dbConnection.Close();
            }

            return returnValue;
        }


        #endregion

        //***********************************************************************************************************
        // User
        //***********************************************************************************************************

        #region User

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
                    ArgumentException ex = new ArgumentException("Not Found", "User and/or password is incorrect");
                    throw ex;
                }
                reader.Close();
            }
            catch (ArgumentException ex)
            {
                throw ex;
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

        //***********************************************************************************************************
        // Transaction
        //***********************************************************************************************************

        #region Transaction

        internal static List<Transaction> SelectAllTransactions(int billID)
        {
            List<Transaction> returnList = new List<Transaction> { };

            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            SqlCommand command = new SqlCommand("SELECT * FROM transactions WHERE billID = @billID ORDER BY date DESC", dbConnection);
            command.Parameters.AddWithValue("@billID", billID);

            try
            {
                dbConnection.Open();

                Transaction temp = new Transaction();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        temp = new Transaction(
                            reader.GetInt32(0),         // id
                            reader.GetInt32(1),         // billID
                            reader.GetInt32(2),         // itemID
                            reader.GetInt32(3),         // amountOfItems
                            reader.GetDateTime(4));     // date

                        // Search for chargeable item
                        temp.ChargeableItem = SelectChargeableItem(temp.ItemID);

                        returnList.Add(temp);
                    }
                }

            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException(ex.Message);
            }
            catch (Exception ex)
            {
                throw new DataException("Error in GetAllTransactions", ex);
            }
            finally
            {
                dbConnection.Close();
            }

            return returnList;
        }

        internal static bool DeleteTransaction(int transactionIDValue)
        {
            // Create return value
            bool returnValue = false;

            // Declare the connection
            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            // Create new SQL command and assign it paramaters
            SqlCommand command = new SqlCommand("DELETE FROM transactions WHERE transactionID = @id", dbConnection);
            command.Parameters.AddWithValue("@id", transactionIDValue);

            // Try to insert the new record, return result
            try
            {
                dbConnection.Open();
                // Try to insert the new record, return result
                returnValue = (command.ExecuteNonQuery() == 1);

            }
            catch (Exception ex)
            {
                throw new DataException("Error in DeleteTransaction", ex);
            }
            finally
            {
                dbConnection.Close();
            }

            return returnValue;
        }

        #endregion

        //***********************************************************************************************************
        // Chargeable Items
        //***********************************************************************************************************

        #region Chargeable Items

        internal static ChargeableItem SelectChargeableItem(int itemID)
        {
            // Create return value
            ChargeableItem returnItem = new ChargeableItem();

            // Declare new SQL connection
            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            // Create new SQL command
            SqlCommand command = new SqlCommand("SELECT * FROM chargeableItems WHERE ItemID = @itemID", dbConnection);
            command.Parameters.AddWithValue("@itemID", itemID);

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
                        returnItem = new ChargeableItem(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDecimal(3));
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new DataException("Error in GetChargeableItem", ex);
            }
            finally
            {
                dbConnection.Close();
            }

            // Return the populated row
            return returnItem;
        }

        #endregion

        //***********************************************************************************************************
        // Staff
        //***********************************************************************************************************

        #region Staff

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

        #endregion

        //***********************************************************************************************************
        // Room
        //***********************************************************************************************************

        #region Room

        internal static DataTable SelectAllRooms()
        {
            DataTable returnDataTable = new DataTable();

            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            SqlCommand command = new SqlCommand("SELECT (roomNumber) FROM rooms", dbConnection);

            try
            {
                dbConnection.Open();

                SqlDataReader reader;
                reader = command.ExecuteReader();

                returnDataTable.Columns.Add("roomNumber", typeof(Int32));
                returnDataTable.Load(reader);

            }
            catch (Exception ex)
            {
                throw new DataException("Error in GetAllRooms", ex);
            }
            finally
            {
                dbConnection.Close();
            }

            return returnDataTable;
        }

        #endregion

        //***********************************************************************************************************
        // Other
        //***********************************************************************************************************

        #region Other

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

        public static string SafeGetString(SqlDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetString(colIndex);
            return string.Empty;
        }

        #endregion

    }
}
