using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandiHotel.Business
{
    internal class BookingC
    {
        private int bookingID;
        private decimal fee;
        private decimal deposit;
        private string address;
        private List<String> service;
        private DateTime checkIn;
        private DateTime checkOut;
        public static  int days { get; set;}
        private Price price;
        private BookingStatus status;
        private Guest guest;
        private decimal totalPayment;

        public int Room { get; set; }

        public enum BookingStatus
        {
            confirmed,
            pending,
            cancelled,

        }

        public BookingC(decimal fee, decimal deposit, DateTime checkin, DateTime checkout, int room)
        {
            this.fee = fee;
            this.deposit = deposit;
           // this.address = address;
           // this.service = Service;

            this.checkIn = checkin;
            this.checkOut = checkout;
            //this.guest = guest;
            price = new Price();

            // guest = new Guest(guest);
            Room = room;
            //CalculateDays();

        }
      
        //public DateTime checkin
        //{
        //    get { return checkin; }
        //    set { checkin = value; }
        //}
        public decimal Fee
        {
            get { return fee; }
            set { fee = value; }
        }
        public decimal Deposit
        {
            get { return deposit; }
            set { deposit = value; }
        }

        //public DateTime checkout
        //{
        //    get { return checkout; }
        //    set { checkout = value; }

        //}
        public int CalculateDays()
        {
            TimeSpan duration = checkOut - checkIn;
            int numberOfDays = duration.Days;
            return numberOfDays;

        }

        public decimal totalPrice(int days,DateTime check)
        {
            return days * price.TotalFee(check);

        }

        public decimal  CalculateDeposit(int days, DateTime check)
        {
            return totalPrice(days,check) * 10/100;
        }

    }
}
