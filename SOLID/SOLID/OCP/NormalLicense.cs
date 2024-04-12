using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public class NormalLicense :ILicense
    {

        public void ActivateLicense(string licenseId)
        {
            Console.WriteLine("License- {0} is successfully activated",licenseId);
        }

        public void DeactivateLicense(string licenseId)
        {
            Console.WriteLine("License- {0} is successfully deactivated", licenseId);
        }
        
    }
}
