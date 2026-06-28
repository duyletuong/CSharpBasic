using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhaiBaoBien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = 1;
            string material = "SS400";
            double distance = 1000.2;

            Console.WriteLine("Start number la: " + startNumber);
            Console.WriteLine("Vat lieu la: " + material);
            Console.WriteLine("Khoang cach la: " + distance);
            Console.ReadLine(); // dung man hinh
        }
    }
}
