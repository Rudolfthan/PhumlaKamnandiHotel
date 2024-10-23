using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandiHotel.Business
{
    internal class Guest : Person
    {
        public string Email { get; set; }         // Guest's email
        public string Address { get; set; }       // Guest's address
        public List<BookingC> Bookings { get; set; }



        // Constructor with no booking
        //public Guest(string email, string address):base(name,idNumber,phoneN)
        //{
        //    Email = email;
        //    Address = address;
        //    Bookings = new List<Booking>(); // Initialize an empty list of bookings
        //}

        // Constructor with bookings
        public Guest(string guestID, string name, string email, string phoneNumber, string address, List<BookingC> bookings)
            : base(name, guestID, phoneNumber)
        {
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            Bookings = bookings ?? new List<BookingC>(); // Handle potential null values for bookings
        }
        //public Guest(Guest guest):base()
        //{

        //}

        // Method to add a booking for the guest
        public void AddBooking(BookingC booking)
        {
            Bookings.Add(booking);
        }

        // Method to retrieve guest's details
        public string GuestDetails()
        {
            string bookingsInfo = string.Join(", ", Bookings.Select(b => b.ToString()));
            return $"Name: {fullName}, Phone: {PhoneNumber}, Email: {Email}, Address: {Address}, Bookings: [{bookingsInfo}]";
        }
    }
}
