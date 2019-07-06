using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Singelton Class for CurrentUser
/// </summary>
namespace ResManagement.Classes
{
    sealed class CurrentUser : User
    {
        //Only 1 Instance -(Single)
        private static CurrentUser instance = new CurrentUser();

        //Constructor
        private CurrentUser() : base("admin","admin")
        { 
        }

        //Get (can set the USER (parent) class attributes
        public static CurrentUser Instance
        {
            get
            {
                if (instance == null)
                    instance = new CurrentUser();
                return instance;
            }
        }

    }
}
