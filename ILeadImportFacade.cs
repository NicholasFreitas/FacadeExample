using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample
{
    interface ILeadImportFacade
    {
        Lead BindURIToLeadObject(string uri);
         
        bool ValidateLeadInformation(Lead boundLead);

        void ImportLeadIntoSystem(Lead validatedLead);

        void QueueLeadForCallcenter(Lead importedLead);
    }
}
