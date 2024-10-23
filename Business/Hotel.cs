using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandiHotel.Business
{
    internal class Hotel
    {
        // Fields (private)
        private string name;
        private string location;
        private double rating;
        private string manager; // Corrected spelling
        private string contact;

        // Constructor
        public Hotel()
        {
        }

        // Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public double Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public string Manager
        {
            get { return manager; } // Corrected spelling
            set { manager = value; }
        }

        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }
    }
}
