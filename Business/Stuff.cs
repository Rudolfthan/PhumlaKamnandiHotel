using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandiHotel.Business
{
    internal class Stuff : Person
    {
        private Role role;


        public Stuff(Role role, string name, string guestID, string phoneNumber) : base(name, guestID, phoneNumber)
        {

        }

    }
}
