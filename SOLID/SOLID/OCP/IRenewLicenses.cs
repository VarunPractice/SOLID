using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public interface IRenewLicenses:ILicense
    {
        /*
         wanted to add new functionality renew, so adding new interface. without altering ILicense and NormalClass, so these two are closed.
         */
        void RenewLic(string licKey);
    }
}
