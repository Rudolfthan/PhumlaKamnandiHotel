using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhumlaKamnandiHotel.Business
{
    internal class CreditCard
    {
        private string creditnumber { get; set; }
        private string cvv { get; set; }
        private string expirationDate { get; set; }

        public CreditCard(string creditcardNumber, string cvv, string expirationDate)
        {
            this.creditnumber = creditcardNumber;
            this.cvv = cvv;
            this.expirationDate = expirationDate;

        }


        public bool VerifyCard()
        {


            if (creditnumber.Length != 16)
            {
                //MessageBox.Show("Invalid credit card number. Number must be 16 digits");
                return false;
            }
            if (cvv.Length != 3)
            {
                //  MessageBox.Show("Invalid cvv. Number must be 3 digits");
                return false;
            }
            if (expirationDate.Length!=5)
            {
              //  MessageBox.Show("Card has expired");
              return false;
            }

            return true;
           
        }
    }
}
