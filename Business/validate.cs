using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PhumlaKamnandiHotel.Business
{
    public class validate
    {

        public bool IsValidID(string id)
        {
            // Check if the input is not null or empty and matches exactly 13 digits
            return !string.IsNullOrEmpty(id) && Regex.IsMatch(id, @"^\d{13}$");
        }

        // Method to validate if a name contains no digits
        public bool IsValidName(string name)
        {

            return !string.IsNullOrEmpty(name) && Regex.IsMatch(name, @"^[a-zA-Z\s]+$");
        }

        public bool IsCheckoutGreaterThanCheckin(DateTime checkin, DateTime checkout)
        {
            return checkout > checkin;
        }
    }
}
