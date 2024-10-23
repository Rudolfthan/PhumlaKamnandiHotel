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
    public partial class CreditCard : Form
    {
        private DatabaseManager d;
        public CreditCard()
        {
            InitializeComponent();
            d= new DatabaseManager();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool b = d.CreditCardValidity(cardn.Text, ccv.Text, exp.Text);
            if (b == true)
            {
                MessageBox.Show("valid card , payment has been made");
                this.Hide();
                opti opt = new opti();
                opt.ShowDialog();
            }
            else
            {
                MessageBox.Show("card Not valid");
                this.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MDIParent1 o = new MDIParent1();
            o.ShowDialog();
            this.Hide();
        }
    }
}
