using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample
{
    class Lead
    {
        string FirstName { get; set; }

        string LastName { get; set; }

        int Age { get; set; }

        string PhoneNumber { get; set; }

        public Lead(string firstname, string lastname, int age, string phonenumber)
        {

            FirstName = firstname;
            LastName = lastname;
            Age = age;
            PhoneNumber = phonenumber;
                       
        }
    }
}
