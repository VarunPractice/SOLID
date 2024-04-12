using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public class RenewableLicense : IRenewLicenses
    {
        public void ActivateLicense(string licenseId)
        {
            Console.WriteLine("License- {0} is successfully activated", licenseId);
        }

        public void DeactivateLicense(string licenseId)
        {
            Console.WriteLine("License- {0} is successfully deactivated", licenseId);
        }
        //enhancement new feature renew added.
        public void RenewLic(string licKey)
        {
            Console.WriteLine("License- {0} is successfully renewed", licKey);

        }
    }
}
