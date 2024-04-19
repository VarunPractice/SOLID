using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    public interface ILicense
    {
        void InstallLicense(string licenseName);
        void ReturnInstalledLicense(string licenseName);
    }
}
