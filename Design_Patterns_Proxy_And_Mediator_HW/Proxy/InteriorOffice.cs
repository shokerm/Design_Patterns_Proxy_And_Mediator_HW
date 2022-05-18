using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Proxy_And_Mediator_HW
{
    internal class InteriorOffice : IInteriorOffice, IServiceMachine
    {
       
        public void AdressUpdate()
        {
            Console.WriteLine("Your address has changed successfully");
        }

        public void ExecutionDepartment()
        {
            Console.WriteLine("Treatment is Transferred to Execution Department");
        }

        public void FinanceDepartment()
        {
            Console.WriteLine("Treatment is Transferred to Finance Department");
        }

        public void LegalDepartment()
        {
            Console.WriteLine("Treatment is Transferred to Legal Department");
        }

        public void NewPassport()
        {
            Console.WriteLine("Hello Your Passport successfully issued");
        }
    }
}
