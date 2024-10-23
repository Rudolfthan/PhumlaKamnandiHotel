using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandiHotel.Business
{
    internal class Role
    {
        //the different role for the staff at the hotel 
        public enum RoleType
        {
            noRole = 0,
            Manager = 1,
            Security = 2,
            HouseKeeper = 3,
            Receptionist = 4,
            Chef = 5,
        }


        #region Instance Variables
        // These are the instance variables of the Role class
        protected RoleType role;
        protected string description;
        #endregion

        #region Properties 
        public RoleType roleType
        {
            get { return role; }
            set { role = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        #endregion

        #region Constructor
        // the constructors of the role class 
        public Role()
        {
            role = RoleType.noRole;
            description = "no role ";
        }
        #endregion
    }
}
