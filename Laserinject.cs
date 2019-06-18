using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
     public class Laserinject : Printer
    {
        public override void Show()
        {
            Console.WriteLine("Laserinject display dimension : 12*12");
        }
        public override void Print()
        {
            Console.WriteLine("Laserinject printer printing....");
        }
    }
}
