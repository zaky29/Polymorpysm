using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer;

            Console.WriteLine("Pilih Printer");
            Console.WriteLine("1.Epson");
            Console.WriteLine("2.Canon");
            Console.WriteLine("3.Laserinject");

            Console.WriteLine("Nomor Printer [1..3: ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            if (nomorPrinter == 1)
                printer = new Epson();
            else if (nomorPrinter == 2)
                printer = new Canon();
            else
                printer = new Laserinject();

            printer.Show();
            printer.Print();

            Console.ReadKey();
        }
    }
}
