using PhumlaKamnandiHotel.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhumlaKamnandiHotel
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //  Application.Run(new Form1());
           // Application.Run(new MDIParent1());
            Application.Run(new Reservation());
            //Application.Run(new Create());
            //Application.Run(new Cancel());
            // Application.Run(new Booking());
           //Application.Run(new CreditCard());
        }
    }
}
