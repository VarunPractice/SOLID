using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    public class Document : IDocument
    {
        /*
         Document class here is showing SRP becaause is not doing any work none other than assigned.
         */
        public void Close()
        {
            Console.WriteLine("Document is Closed"); 
        }

        public void Open()
        {
            Console.WriteLine("Document is opened");
        }
    }
}
