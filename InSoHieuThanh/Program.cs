using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InSoHieuThanh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- !!!Chuog trinh tu dong in so hieu dam !!! ---");
            Console.WriteLine("Sau day la tat ca cac dam chung toi co!!!");

            //for (int i = 1; i <= 10000000; i++)
            //{
            //    Console.WriteLine("Dam " + i);
            //}

            int i = 1;
            while (true)
            {
                Console.WriteLine("Dam " + i);
                i = i + 1;
            }

            Console.ReadLine();
        }
    }
}
