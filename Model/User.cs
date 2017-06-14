using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        private string _FirstName;
        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                if (value.Length > 20)
                    Console.WriteLine("Error! FirstName must be less than 21 characters!");
                else
                    _FirstName = value;
            }
        }

        private string _LastName;
        public string LastName
        {
            get { return _LastName; }
            set
            {
                if (value.Length > 20)
                    Console.WriteLine("Error! LastName must be less than 21 characters!");
                else
                    _LastName = value;
            }
        }

        private string _PhoneNo;
        public string PhoneNo
        {
            get { return _PhoneNo; }
            set
            {
                if (value.Length > 11)
                    Console.WriteLine("Error! Phone No must be less than 11 characters!");
                else
                    _PhoneNo = value;
            }
        }

        private string _Email;
        public string Email
        {
            get { return _Email; }
            set
            {
                    _Email = value;
            }
        }

        private string _Address;
        public string Address
        {
            get { return _Address; }
            set
            {
                if (value.Length > 50)
                    Console.WriteLine("Error! Phone No must be less than 51 characters!");
                else
                    _Address = value;
            }
        }

        public User(string firstname, string lastname, string phoneno, string email, string address)
        {
            FirstName = firstname;
            LastName = lastname;
            PhoneNo = phoneno;
            Email = email;
            Address = address;
        }

    }
}
