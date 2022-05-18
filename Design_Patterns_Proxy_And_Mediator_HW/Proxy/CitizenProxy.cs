using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Proxy_And_Mediator_HW
{
    internal class CitizenProxy : IServiceMachine
    {
        private IServiceMachine citizen { get; set; }
        

        public CitizenProxy(IServiceMachine citizen)
        {
            this.citizen = citizen;
        }

        public void AdressUpdate()
        {
            this.citizen.AdressUpdate();
        }

        public void NewPassport()
        {
            citizen.NewPassport();
        }
          
        
    }
}
