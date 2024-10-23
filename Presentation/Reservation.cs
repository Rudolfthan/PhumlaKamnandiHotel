using PhumlaKamnandiHotel.Business;
using PhumlaKamnandiHotel.Database;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PhumlaKamnandiHotel.Presentation
{
    public partial class Reservation : Form
    {
        private DatabaseManager d;
        private BookingC b;
        private Guest g;
        public static int days;
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Rudolf\\Documents\\PhumlaKamnandiHotel\\KhumlaDatabase.mdf;Integrated Security=True";
        public static DateTime checkin;
        public static DateTime checkout;
        public static int roomn;
        
        public Reservation()
        {
            InitializeComponent();
            d=new DatabaseManager();
            
            
            calculateDay();
            //dateTimePicker1.Value= checkin;
            //dateTimePicker2.Value= checkout;
            //this.checkin = checkin;
           // this.checkout = checkout;   

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PriceBox.Clear();
            textBox1.Clear();
            calculateDay();
            // MessageBox.Show(days.ToString());
            validate v = new validate();
            if (v.IsCheckoutGreaterThanCheckin(dateTimePicker1.Value, dateTimePicker2.Value) == true)
            {
                DatabaseManager dd = new DatabaseManager();
                BookingC b= new BookingC(0,0,dateTimePicker1.Value.Date,dateTimePicker2.Value.Date,2);
                string price = (b.totalPrice(days, dateTimePicker1.Value).ToString());
                PriceBox.AppendText(price);




                List<string> t = dd.RoomAvailability(dateTimePicker1.Value);
                foreach (string s in t)
                {
                    textBox1.AppendText(s);
                    textBox1.AppendText(" \n");
                }
            }
            else
            {
                MessageBox.Show("checkout time cannot be greater than checkin time");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          

        }

        public void calculateDay()
        {
            DateTime checkInDate = dateTimePicker1.Value.Date;
            DateTime checkOutDate = dateTimePicker2.Value.Date;

            // Ensure the check-out date is after the check-in date
          
                // Calculate the number of days between the two dates
                TimeSpan duration = checkOutDate - checkInDate;
                int numberOfDays = duration.Days+1;
                days= numberOfDays;

                // Show the result in a label or messagebox
       
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkin = dateTimePicker1.Value.Date;
            checkout = dateTimePicker2.Value.Date;
            if (roomN.Text != null)
            {
                roomn = Convert.ToInt32(roomN.Text);
                Booking c = new Booking();
                c.StartPosition = FormStartPosition.Manual;
                c.Location = this.Location;


                c.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("enter room rumber");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MDIParent1 o = new MDIParent1();
            o.ShowDialog();
            this.Hide();
        }
    }
}
