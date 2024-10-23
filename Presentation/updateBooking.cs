using PhumlaKamnandiHotel.Business;
using PhumlaKamnandiHotel.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhumlaKamnandiHotel.Presentation
{
    public partial class updateBooking : Form
    {
        private DatabaseManager d;
        private BookingC b;
        private Guest g;
        public static int days;
       // private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Rudolf\\Documents\\PhumlaKamnandiHotel\\KhumlaDatabase.mdf;Integrated Security=True";
        public static DateTime checkin;
        public static DateTime checkout;
        public static int roomn;
        public updateBooking()
        {
            InitializeComponent();
            d = new DatabaseManager();
            b = new BookingC(0, 0, dateTimePicker1.Value.Date, dateTimePicker2.Value.Date, 2);

            calculateDay();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            validate v = new validate();
            if (v.IsCheckoutGreaterThanCheckin(dateTimePicker1.Value, dateTimePicker2.Value) == true)
            {
                PriceBox.Clear();
                available.Clear();
                calculateDay();
                MessageBox.Show(days.ToString());

                string price = (b.totalPrice(days, dateTimePicker1.Value).ToString());
                PriceBox.AppendText(price);




                List<string> t = d.RoomAvailability(dateTimePicker1.Value);
                foreach (string s in t)
                {
                    available.AppendText(s);
                    available.AppendText("\n");

                }
            }
            else
            {
                MessageBox.Show("checkout time cannot be greater than checkin time");
            }
        }


        public void calculateDay()
        {
            DateTime checkInDate = dateTimePicker1.Value.Date;
            DateTime checkOutDate = dateTimePicker2.Value.Date;

            // Ensure the check-out date is after the check-in date

            // Calculate the number of days between the two dates
            TimeSpan duration = checkOutDate - checkInDate;
            int numberOfDays = duration.Days;
            days = numberOfDays;

            // Show the result in a label or messagebox


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string refe = refT.Text;
            d.UpdateBooking(refe, dateTimePicker1.Value, dateTimePicker2.Value);
            opti o = new opti();
            o.ShowDialog();
            this.Hide();
        }
    }
}
