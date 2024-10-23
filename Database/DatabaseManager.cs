using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PhumlaKamnandiHotel.Business;
using System.Windows.Forms;

namespace PhumlaKamnandiHotel.Database
{
    internal class DatabaseManager
    {

        // what i added for acessing and using data
        #region initialize database 
        public static DataSet dataSet = new DataSet();
        public static SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        private CreditCard card;
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Rudolf\\Documents\\PhumlaKamnandiHotel\\KhumlaDatabase.mdf;Integrated Security=True";
        #endregion
        #region Constructor

        public DatabaseManager()
        {
            connection = new SqlConnection(connectionString);
        }
        #endregion
        #region Operations on Database 
        // add new booking 
        public void AddBooking(string bookingID, string guestID, DateTime checkin, DateTime checkout, int bookingStatus, decimal deposit, decimal totalpayment, decimal remaining,int roomNumber)
        {
            try
            {
                // adding a new booking with an sql query 
                command = new SqlCommand("INSERT INTO Booking (bookingID, GuestID, checkin, checkout,bookingStatus,deposit,totalpayment,remaining,roomNumber) VALUES (@bookingID, @GuestID, @checkin, @checkout,@bookingStatus,@deposit,@totalpayment,@remaining,@roomNumber)", connection);

                command.Parameters.AddWithValue("@bookingID", bookingID);
                command.Parameters.AddWithValue("@GuestID", guestID);
                command.Parameters.AddWithValue("@checkin", checkin);
                command.Parameters.AddWithValue("@checkout", checkout);
                command.Parameters.AddWithValue("@bookingStatus", bookingStatus);
                command.Parameters.AddWithValue("@deposit", deposit);
                command.Parameters.AddWithValue("@totalpayment", totalpayment);
                command.Parameters.AddWithValue("@remaining", remaining);
                command.Parameters.AddWithValue("@roomNumber", roomNumber);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();


            }
            catch (SqlException e)
            {
                Console.WriteLine("SQL Exception: " + e.Message);
            }
            catch (Exception e)
            {

                Console.WriteLine("Exception: " + e.Message);

            }
        }

        public void UpdateBooking(string bookingID, DateTime checkin, DateTime checkout)
        {
            // Update the checkin and checkout dates in the Booking table
            using (SqlCommand command = new SqlCommand("UPDATE Booking SET checkin = @checkin, checkout = @checkout WHERE bookingID = @bookingID", connection))
            {
                command.Parameters.AddWithValue("@bookingID", bookingID);
                command.Parameters.AddWithValue("@checkin", checkin);
                command.Parameters.AddWithValue("@checkout", checkout);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error while updating booking");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        /*
         CREATE TABLE [dbo].[Booking] (
    [bookingID]     INT          NOT NULL,
    [GuestID]       NCHAR (15)   NOT NULL,
    [checkin]       DATETIME     NOT NULL,
    [checkout]      DATETIME     NOT NULL,
    [bookingStatus] NCHAR (10)   NOT NULL,
    [deposit]       DECIMAL (18) NULL,
    [totalpayment]  DECIMAL (18) NOT NULL,
    [remaining]     DECIMAL (18) NOT NULL,
    [roomNumber] INT NULL, 
    PRIMARY KEY CLUSTERED ([bookingID] ASC),
    CONSTRAINT [FK_Booking_guest] FOREIGN KEY ([GuestID]) REFERENCES [dbo].[Guest] ([GuestID]), 
    CONSTRAINT [FK_Booking_Rooms] FOREIGN KEY ([roomNumber]) REFERENCES [Rooms]([room Number])
);

*/
        public List<string> RoomAvailability(DateTime CheckDate)
        {

            connection.Open();
            List<string> availableRooms = new List<string>();
            
            
            command = new SqlCommand("SELECT Rooms.[room Number] FROM Rooms LEFT JOIN Booking ON Rooms.[room Number] = Booking.[roomNumber] WHERE Booking.[roomNumber] IS NULL OR ((@CheckDate NOT BETWEEN Booking.checkin AND Booking.checkout ) AND Booking.bookingStatus != 1) ", connection);
            command.Parameters.AddWithValue("@CheckDate", CheckDate);
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                // 
                int Id = (int)reader["room Number"];
                string details = "Room number " + Id + " is Available";
                availableRooms.Add(details);
            }

            reader.Close();
            connection.Close();
            return availableRooms;

        }


        // add new account 
        public void AddAccount(int roomNumber, string ID, decimal ExtraFee, decimal addon)
        {
            try
            {
                command = new SqlCommand("INSERT INTO Account (roomNumber, ID, ExtraFee, addon) VALUES (@roomNumber, @ID, @ExtraFee, @addon)", connection);


                command.Parameters.AddWithValue("@roomNumber", roomNumber);
                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@ExtraFee", ExtraFee);
                command.Parameters.AddWithValue("@addon", addon);


                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error while adding account " );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding account ");
            }

        }

        public void AddGuest(string GuestID, string fullName, string Email, string phoneNumber, string address)
        {
            try
            {
                // add new guest when they check in 

                SqlCommand command = new SqlCommand("INSERT INTO Guest (GuestID, fullName, Email, phoneNumber, address) VALUES (@GuestID, @fullName, @Email, @phoneNumber, @address)", connection);

                command.Parameters.AddWithValue("@GuestID", GuestID);
                command.Parameters.AddWithValue("@fullName", fullName);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@address", address);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public bool CreditCardValidity(string creditCardNumber, string cvv, string expirationDate)
        {
            card = new CreditCard(creditCardNumber, cvv, expirationDate);
            if (card.VerifyCard()== true)
            {
                connection.Open();
                command = new SqlCommand("SELECT * FROM CreditCard WHERE creditcardnumber = @CreditCardNumber AND CVV = @CVV AND expirationdate = @ExpirationDate", connection);
                command.Parameters.AddWithValue("@creditcardnumber", creditCardNumber);
                command.Parameters.AddWithValue("@CVV", cvv);
                command.Parameters.AddWithValue("@expirationdate", expirationDate);
     
                SqlDataReader reader = command.ExecuteReader();

                // Check if the credit card details are valid
                // Check if the credit card details are valid
                if (reader.HasRows)
                {
                    connection.Close();
                    return true;
                }
                else
                {
                    connection.Close();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("incorrect card number / cvv /exp.date");
                return false;
            }
        }





        //}
        public void AddNewStaff(string name, string email, string phone, string id, string role)
        {
            using ( command = new SqlCommand("INSERT INTO Staff (emp_id, role, name, phoneNumber, Email) VALUES (@emp_id, @role, @name, @phone, @Email)", connection))
            {
                command.Parameters.AddWithValue("@emp_id", id);
                command.Parameters.AddWithValue("@role", role);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@Email", email);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    // Handle SQL exceptions here (e.g., log the error)
                    Console.WriteLine("Error while adding new staff: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void AddLogin(string username, string password, string name, string id)
        {
            using ( command = new SqlCommand("INSERT INTO Login (username, password, name, id) VALUES (@username, @password, @name, @id)", connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password); // Consider hashing this in real applications
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    // Handle SQL exceptions here (e.g., log the error)
                    MessageBox.Show("Error occured while adding New receptionist");
                }
                finally
                {
                    connection.Close();
                }
            }

        }


        public void changeBooking(string bookingID, string guestID, DateTime checkin, DateTime checkout, string bookingStatus, decimal deposit, decimal totalpayment, decimal remaining)
        {
            try
            {
                command = new SqlCommand("UPDATE Bookings SET GuestID = @guestID, checkin = @checkin, checkout = @checkout, BookingStatus = @bookingStatus, deposit = @deposit, TotalPayment = @totalpayment, remaining = @remaining WHERE BookingID = @bookingID", connection);
                // command = new SqlCommand("UPDATE Bookings SET GuestID = @guestID, checkin = @checkin, checkout = @checkout, BookingStatus = @bookingStatus, deposit = @deposit, TotalPayment = @totalpayment, remaining = @remaining WHERE BookingID = @bookingID", connection);
                command.Parameters.AddWithValue("@bookingID", bookingID);
                command.Parameters.AddWithValue("@guestID", guestID);
                command.Parameters.AddWithValue("@checkin", checkin);
                command.Parameters.AddWithValue("@checkout", checkout);
                command.Parameters.AddWithValue("@bookingStatus", bookingStatus);
                command.Parameters.AddWithValue("@deposit", deposit);
                command.Parameters.AddWithValue("@totalpayment", totalpayment);
                command.Parameters.AddWithValue("@remaining", remaining);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error occured while updating booking");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured while updating booking");


            }




        }

        public void AddBookingToHistory(string bookingID)
        {
            // Retrieve the booking details from the Booking table
            using (SqlCommand command = new SqlCommand("SELECT * FROM Booking WHERE bookingID = @bookingID", connection))
            {
                command.Parameters.AddWithValue("@bookingID", bookingID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Retrieve the booking details
                        string retrievedGuestID = (string)reader["GuestID"];
                        DateTime retrievedCheckin = (DateTime)reader["checkin"];
                        DateTime retrievedCheckout = (DateTime)reader["checkout"];
                        int retrievedBookingStatus = (int)reader["bookingStatus"];
                        decimal retrievedDeposit = (decimal)reader["deposit"];
                        decimal retrievedTotalPayment = (decimal)reader["totalpayment"];
                        decimal retrievedRemaining = (decimal)reader["remaining"];
                        int retrievedRoomNumber = (int)reader["roomNumber"];

                        reader.Close(); // Close the reader before running the history command

                        // Add the booking details to the History table
                        using (SqlCommand historyCommand = new SqlCommand("INSERT INTO History (bookingID,GuestID, checkin, checkout, bookingStatus, deposit, totalpayment, remaining,roomNumber) VALUES (@bookingID,@GuestID, @checkin, @checkout, @bookingStatus, @deposit, @totalpayment, @remaining,@roomNumber)", connection))
                        {
                            historyCommand.Parameters.AddWithValue("@bookingID", bookingID);
                            historyCommand.Parameters.AddWithValue("@GuestID", retrievedGuestID);
                            historyCommand.Parameters.AddWithValue("@checkin", retrievedCheckin);
                            historyCommand.Parameters.AddWithValue("@checkout", retrievedCheckout);
                            historyCommand.Parameters.AddWithValue("@bookingStatus", retrievedBookingStatus);
                            historyCommand.Parameters.AddWithValue("@deposit", retrievedDeposit);
                            historyCommand.Parameters.AddWithValue("@totalPayment", retrievedTotalPayment);
                            historyCommand.Parameters.AddWithValue("@remaining", retrievedRemaining);
                            historyCommand.Parameters.AddWithValue("@roomNumber", retrievedRoomNumber);

                            try
                            {
                                historyCommand.ExecuteNonQuery();
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show("Error occured while moving booking");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Booking not found");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error while retrieving booking");
                }
                finally
                {
                    connection.Close(); // Close the connection in the finally block
                }
            }
        }


        public void deleteBooking(string bookingID)
        {
            using (SqlCommand deleteCommand = new SqlCommand("DELETE FROM Booking WHERE BookingID = @bookingID", connection))
            {
                deleteCommand.Parameters.AddWithValue("@bookingID", bookingID);

                try
                {
                    connection.Open();
                    deleteCommand.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Invalid booking id ");
                }
                finally
                {
                    connection.Close();
                }
            }
        }


        public int OccupancyCheck(DateTime startDay, DateTime endDay)
        {
            connection.Open();

            SqlCommand command = new SqlCommand(@"SELECT Rooms.[room Number] 
                                        FROM Rooms 
                                        LEFT JOIN Booking 
                                        ON Rooms.[room Number] = Booking.[roomNumber] 
                                        WHERE Booking.[roomNumber] IS NULL 
                                        OR (NOT (@startDay <= Booking.checkout AND @endDay >= Booking.checkin) 
                                            AND Booking.bookingStatus != 1)", connection);

            command.Parameters.AddWithValue("@startDay", startDay);
            command.Parameters.AddWithValue("@endDay", endDay);

            SqlDataReader reader = command.ExecuteReader();

            int availableRooms = 0;

            while (reader.Read())
            {
                availableRooms++;
            }

            reader.Close();
            connection.Close();

            return availableRooms;
        }



    }  
    
    
}
    #endregion



