using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResManagement.Classes
{
    class User
    {
        public String UserName { set; get; }
        public String Password { set; get; }
        public int Permission { set; get; }
        public String FirstName { set; get; }
        public String LastName { set; get; } 
        public String Email { set; get; }
        public int PhoneNumber { set; get; }
        public int Age { set; get; }

        public User(String userName, String password)
        {
            UserName = userName;
            Password = password;
        }

        public User(String userName, String password, int permission, String firstName, String lastName, String email, int phoneNumber, int age)
            : this (userName,password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Age = age;
            Permission = permission;
        }

        //ProtoType - Design Structure

        // Deep Copy: all objects are duplicated
        public User DeepCopy()
        {
            return (User)MemberwiseClone();
        }

        // Shallow Copy: only top-level objects are duplicated  
        public User ShallowCopy()
        {
            return (User)this.Clone();
        }

        private User Clone()
        {
            throw new NotImplementedException();
        }
    }
}
