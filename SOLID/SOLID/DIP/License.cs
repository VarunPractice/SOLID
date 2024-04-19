using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    public class License
    {
        IRenewablelLicense license {  get; set; }
        public License(IRenewablelLicense _license)
        {
            license = _license; 
        }

        void Install(string Lic)
        { license.InstallLicense(Lic); }
        void Uninstall(string Lic)
        { license.ReturnInstalledLicense(Lic); }
        void RenewLicense(string Lic)
        { license.RenewLicense(Lic); }
        


    }
}
