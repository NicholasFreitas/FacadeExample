using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample
{
    class LeadImportService : ILeadImportFacade
    {
        ICallCenter CallCenter;
        ILeadValidator Validator;
        ILeadImporter Importer;
        IAPIProcessor Processor;
        

        /*
         so this is an interesting facade. We have properties which essentially represents interfaces for disparate subsystems.
         What these do is tell us "this subsystems are involved in the import service.
         then in the implementation of the LeadImportService, we then instantiate in the method calls, the service we need to use.
         You'll notice not every subsystem is prefixed with Lead so they might exist elsewhere in our system and do the same thing.
         So we have some nice code re-use while abstracting away the specific calls themselves. Which aren't useful for the consumer.  
             
             */

        public Lead BindURIToLeadObject(string uri)
        {

            Processor = new QueryStringProcessor();

            Processor.ParseURI(uri);

            return Processor.BuildLeadObject();

        }

        public void ImportLeadIntoSystem(Lead validatedLead)
        {
            Importer = new LeadImporter(validatedLead);

            Importer.AssignProductsAndServices();

            Importer.AssignLocalMarket();

            Importer.AssignClassification();

            Importer.AssignRating();
                        
        }

        public void QueueLeadForCallcenter(Lead importedLead)
        {
            CallCenter = new CallCenterEngine(importedLead);

            CallCenter.AssignToAgent();

            CallCenter.SendCallToAgent();
        }

        public bool ValidateLeadInformation(Lead boundLead)
        {
            Validator = new CustomerValidator(boundLead);

            /*I doubt this is the BEST way to do it, but I'm quick just showing 
             validation sub processes.Bare with me :)
             */

            if ( Validator.ValidateAge() && Validator.ValidatePhone() & Validator.ValidateFirstName() & Validator.ValidateLastName() )
                return true;

            
            return false;
            
        }
    }
}
