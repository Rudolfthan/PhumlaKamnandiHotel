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
    public partial class opti : Form
    {
        private Cancel cancel;
        private Reservation reservation;
        private updateBooking b;
        private DatabaseManager d;
        public opti()
        {
            InitializeComponent();
            cancel = new Cancel();
            reservation = new Reservation();
            b = new updateBooking();
            d = new DatabaseManager();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reservation c = new Reservation();
            c.StartPosition = FormStartPosition.Manual;
            c.Location = this.Location;


            c.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.
            cancel.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //updateBooking b= new updateBooking();
            updateBooking c = new updateBooking();
            c.StartPosition = FormStartPosition.Manual;
            c.Location = this.Location;


            c.Show();
            //b.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //d.OccupancyCheck();
            report report = new report();
            report.ShowDialog();
        }
    }
}
