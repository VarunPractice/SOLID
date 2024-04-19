using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{
    public class PressureUnit :Unit
    {
        public override void convert(IUnit inputUnit1, double inputUnit1Value, IUnit inputUnit2, double inputUint2Value)
        {
            Console.WriteLine("Conversion done for pressure.");
        }
    }
}
