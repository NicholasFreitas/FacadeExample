using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample
{
    interface ILeadValidator
    {

        bool ValidateFirstName();
        bool ValidateLastName();
        bool ValidatePhone();
        bool ValidateAge();
        
    }
}
