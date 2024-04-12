using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public interface IRenewLicenses:ILicense
    {
        void RenewLic(string licKey);
    }
}
