using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    public class SoftwareLicense : IRenewablelLicense
    {
        public void InstallLicense(string licenseName)
        {
            Console.WriteLine("SW Lic Installed");
        }

        public void RenewLicense(string license)
        {
          Console.WriteLine("SW Lic Renewed");
        }

        public void ReturnInstalledLicense(string licenseName)
        {
            Console.WriteLine("SW Lic Returned");
        }
    }
}
