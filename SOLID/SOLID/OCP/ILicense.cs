using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public interface ILicense
    {
        void ActivateLicense(string licenseId);
        void DeactivateLicense(string licenseId);
    }
}
