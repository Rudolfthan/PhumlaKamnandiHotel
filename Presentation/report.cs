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
    public partial class report : Form
    {
        private DatabaseManager d;
        public report()
        {
            InitializeComponent();
            d = new DatabaseManager();
        }

        private void genR_Click(object sender, EventArgs e)
        {
            repB.Clear();
            int t =d.OccupancyCheck(dateTimePicker1.Value, dateTimePicker2.Value);
            repB.AppendText("Available Rooms: "+t.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            opti o = new opti();
            o.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MDIParent1 o = new MDIParent1();
            o.ShowDialog();
            this.Hide();
        }
    }
}
