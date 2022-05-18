using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Proxy_And_Mediator_HW
{
    internal class OfficialProxy : IInteriorOffice
    {
        public string OfficalName { get; set; }
        private IInteriorOffice Offical { get; set; }

        public OfficialProxy(IInteriorOffice offical)
        {
            this.Offical = offical;
        }

        public void ExecutionDepartment()
        {
            this.Offical.ExecutionDepartment();
        }

        public void FinanceDepartment()
        {
            this.Offical.FinanceDepartment();
        }

        public void LegalDepartment()
        {
            this.Offical.LegalDepartment();
        }


        public static string GetRandomNameString()
        {
            Random r = new Random();

            string[] names = { "David","Rotem", "Yoni","Adi", "Dani",
                "Shir", "Moshe","Yael", "Nir",
                "Anat","Reuven","Galit", "Shimi","Dana",
                "Yogev","Osnat", "Gad","Tali", "Natan",
                "Liat","Eyal","Rona" };
            int index = r.Next(0, names.Length);
            return names[index];

        }
    
    }
}
