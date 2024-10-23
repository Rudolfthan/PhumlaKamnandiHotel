using PhumlaKamnandiHotel.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhumlaKamnandiHotel.Presentation
{
    public partial class Cancel : Form
    {
        // private opti opt; 
        // private 
        private DatabaseManager d;
        public Cancel()
        {
            InitializeComponent();
            d=new DatabaseManager();
            // opt = new opti();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string id  = bookingBox.Text;    
            d.AddBookingToHistory(id);
            MessageBox.Show("booking canceled");
           // Thread.Sleep(2000);
            d.deleteBooking(id);
            MessageBox.Show("booking deleted");
        

            opti opti = new opti();
            opti.ShowDialog();
            this.Hide();
            //opt.ShowDialog();

        }
    }
}
