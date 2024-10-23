using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandiHotel.Business
{
    internal class Person
    {
        #region Instance Variables
        // The contents of the class Person 
        protected string ID;
        protected string fullName;
        protected string PhoneNumber;
        // protected string secondName;
        #endregion

        #region properties 
        // getters and setters of the preson class 
        public string name
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public string id
        {
            get { return ID; }
            set { ID = value; }
        }
        public string phoneNumber
        {
            get { return PhoneNumber; }
            set { PhoneNumber = value; }
        }

        #endregion
        #region Constructor
        public Person(string name, string idNumber, string phoneN)
        {
            // constructor with parameters
            this.fullName = name;
            ID = idNumber;
            PhoneNumber = phoneN;

        }
        public override string ToString()
        {
            // overriding the string to write my own presentation for the string 
            return $"Name: {fullName}, Phone: {PhoneNumber}";
        }
        #endregion

    }
}
