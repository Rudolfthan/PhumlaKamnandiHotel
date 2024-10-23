using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandiHotel.Business
{
    internal class Room
    {
        public int RoomNumber { get; set; }           // Unique room number
        public decimal PricePerNight { get; set; }  // Cost per night for the room
        public Availability IsAvailable { get; set; }     // Availability status
        public List<BookingC> Bookings { get; set; }  //for multiple bookings

        //Constructor for room with no bookings yet

        public enum Availability
        {
            occupied = 1,
            available= 0 
        }
        public Room(int roomNumber, decimal pricePerNight, Availability isAvailable)
        {
            RoomNumber = roomNumber;
            PricePerNight = pricePerNight;
            IsAvailable = isAvailable;
            Bookings = new List<BookingC>();
        }

        //constructor with bookings
        public Room(int roomNumber, decimal pricePerNight, List<BookingC> bookings)
        {
            RoomNumber = roomNumber;
            PricePerNight = pricePerNight;
            IsAvailable = Availability.available;
            Bookings = bookings;
        }
        public Room(int roomNumber,Availability Availability)
        {
            RoomNumber = roomNumber;
            //this.Availability = Availability;

        }

        //compares checkIn dates & checkOut dates for bookings
      /*  public bool AvailabilityCheck(DateTime checkIn, DateTime checkOut)
        {
            foreach (var booking in Bookings)
            {
                if ((checkIn >= booking.checkin && checkIn < booking.checkout) ||
                    (checkOut > booking.checkin && checkOut <= booking.checkout))
                {
                    return false; // Room not available
                }
            }
            return true; // Room is available

        }*/

        public void AddBooking(BookingC booking)
        {
            Bookings.Add(booking);
            IsAvailable = Availability.occupied; //set availability to false once room is booked
        }
    }
}
