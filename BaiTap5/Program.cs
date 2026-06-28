using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chuong trinh tu dong thong ke cot");
            int soTang = 0;
            int soCot = 0;


            Console.Write("Xin moi nhap so tang: ");
            soTang = int.Parse(Console.ReadLine());

            Console.Write("Xin moi nhap so cot: ");
            soCot = int.Parse(Console.ReadLine());

            for (int i = 1; i <= soTang; i++)
            {
                for (int j = 1; j <= soCot; j++)
                {
                    Console.WriteLine("C" + "-" + i + "-" + j);
                }
            }

            Console.ReadLine();
        }
    }
}
