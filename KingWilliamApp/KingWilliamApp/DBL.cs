using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

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

        #region "Methods"

        internal static int InsertNewAddress(Address insertAddress)
        {
            // Create return value
            int returnValue = 0;

            // Declare the connection
            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            // Create new SQL command and assign it paramaters
            SqlCommand command = new SqlCommand("INSERT INTO tblAddresses VALUES(@addressLine1, @addressLine2, @city, @provinceID, @country, @postalCode)", dbConnection);
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
            SqlCommand command = new SqlCommand("INSERT INTO tblCustomers VALUES(@firstName, @lastName, @phoneNumber, @addressID)", dbConnection);
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

        internal static bool InsertNewReservation(Reservation insertReservation)
        {
            // Create return value
            bool returnValue = false;

            // Declare the connection
            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            //Check if customer exists

            // Create new SQL command and assign it paramaters
            SqlCommand command = new SqlCommand("INSERT INTO tblReservations VALUES(@numberOfGuests, @startDate, @endDate, @notes, @customerID, @billID, @roomNumber)", dbConnection);
            //command.Parameters.AddWithValue("@firstName", insertWorker.FirstName);
            //command.Parameters.AddWithValue("@lastName", insertWorker.LastName);
            //command.Parameters.AddWithValue("@messages", insertWorker.Messages);
            //command.Parameters.AddWithValue("@pay", insertWorker.Pay);
            //command.Parameters.AddWithValue("@type", insertWorker.Type);
            //command.Parameters.AddWithValue("@entryDate", insertWorker.EntryDate);
            //command.Parameters.AddWithValue("@createdBy", insertWorker.CreatedBy);

            // Try to insert the new record, return result
            try
            {
                dbConnection.Open();
                // Try to insert the new record, return result
                returnValue = (command.ExecuteNonQuery() == 1);

            }
            catch (Exception ex)
            {
                throw new DataException("Error in InsertNewRecord", ex);
            }
            finally
            {
                dbConnection.Close();
            }

            // Return the true if this worked, false if it failed
            return returnValue;
        }

        

        internal static Customer GetOneRow(int workerId)
        {
            // Declare new worker object
            Worker returnWorker = new PieceworkWorker();

            // Declare new SQL connection
            SqlConnection dbConnection = new SqlConnection(GetConnectionString());

            // Create new SQL command
            SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM [tblEntries] WHERE [EntryId] = " + workerId, dbConnection);

            // Try to connect to the database, create a datareader. If successful, read from the database and fill created row
            // with information from matching record
            try
            {
                dbConnection.Open();
                IDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (reader.GetString(5) == "Senior")
                    {
                        returnWorker = new SeniorWorker(reader.GetString(1), reader.GetString(2), reader.GetString(3));
                    }
                    else
                    {
                        returnWorker = new PieceworkWorker(reader.GetString(1), reader.GetString(2), reader.GetString(3));
                    }
                    returnWorker.Id = workerId;
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error in GetOneRow", ex);
            }
            finally
            {
                dbConnection.Close();
            }

            // Return the populated row
            return returnWorker;

        }

        #endregion

    }
}
