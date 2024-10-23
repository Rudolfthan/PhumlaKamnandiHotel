using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandiHotel.Business
{
    internal class Login : Person
    {
        //private Role role;
        // private string _username;
        // private string _password;
        private string _email;
        // private string _phone;



        public Login(string name, string id, string phone, string email) : base(name, id, phone)
        {
            this.name = name;
            this.id = id;
            this.phoneNumber = phone;
            this._email = email;


        }

        public string Email
        {
            
                get { return this._email; }
                set { this._email = value; }
            }

        public string password()
        {
            return ID;
        }

        public string userName()
        {
            return fullName;

        }




    }
}
