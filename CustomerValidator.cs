using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample
{
    class CustomerValidator : ILeadValidator
    {
        Lead LeadToBeValidated;

        public CustomerValidator(Lead valLead)
        {
            LeadToBeValidated = valLead;
        }

        public bool ValidateAge()
        {
            //No implementation here, we're just mocking up the validation.
            Console.WriteLine("Validate: Age");
            return true;
        }

        public bool ValidateFirstName()
        {
            //No implementation here, we're just mocking up the validation.
            Console.WriteLine("Validate: FirstName");
            return true;
        }

        public bool ValidateLastName()
        {
            //No implementation here, we're just mocking up the validation.
            Console.WriteLine("Validate: LastName");
            return true;
        }

        public bool ValidatePhone()
        {
            //No implementation here, we're just mocking up the validation.
            Console.WriteLine("Validate: Phone");
            return true;
        }
    }
}
