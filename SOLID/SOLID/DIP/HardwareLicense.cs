using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    public class HardwareLicense : ILicense
    {
        public void InstallLicense(string licenseName)
        {
            Console.WriteLine("HW License Installed");
        }

        public void ReturnInstalledLicense(string licenseName)
        {
            Console.WriteLine("HW License returned");

        }
    }
}
