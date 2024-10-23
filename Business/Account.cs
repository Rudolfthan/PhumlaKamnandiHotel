using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandiHotel.Business
{
    internal class Account
    {
        #region Instance Variables 
        //The instance variables for the Account 
        protected decimal fee;
        protected string addOn;
        protected decimal deposit;
        protected int roomNumber;
        protected string guestName;
        //protected int LoyaltyPoints;
        private string id;
        // theres history to be added here 
        #endregion

        #region properties 
        public decimal Fee
        {
            get { return fee; }
            set { fee = value; }
        }

        public string AddOn
        {
            get { return addOn; }
            set { addOn = value; }
        }

        public decimal Deposit
        {
            get { return deposit; }
            set { deposit = value; }
        }

        public int RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }
        #endregion

        #region Constructor 
        public Account(Person idd, decimal extrafee, string addon, int roomNumber)
        {

            id = idd.id;
            this.fee = extrafee;
            addOn = addon;
            this.roomNumber = roomNumber;
            // LoyaltyPoints = loyaltypoints;
        }
        #endregion
        #region methods
        public void UpdateAddon(decimal transaction)
        {
            // record the transaction when the guest buys while in the hotel 
            if (fee > 0)
            {
                fee = fee + transaction;
            }
            else
            {
                fee = transaction;
            }
        }
        public void updateLoyaltyPoints()
        {

        }
        #endregion
    }
}
