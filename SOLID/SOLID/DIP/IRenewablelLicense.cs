using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    public interface IRenewablelLicense:ILicense
    {
        void RenewLicense(string license);
    }
}
