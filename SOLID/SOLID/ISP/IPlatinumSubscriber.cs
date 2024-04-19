using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    public interface IPlatinumSubscriber:IBasicSubcriberDocument
    {
        void EditDocument(string DocPath);
    }
}
