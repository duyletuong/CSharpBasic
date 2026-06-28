using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTraChieuDaiDam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chieuDaiDam;
            Console.WriteLine("Chuong trinh tu dong kiem tra chieu dai dam!");
            Console.WriteLine("Version 1.0.1");
            Console.WriteLine("Copyright @2025");
            Console.Write("Xin moi nhap chieu dai dam de chung toi kiem tra: ");
            
            chieuDaiDam = Convert.ToDouble(Console.ReadLine());

            if (chieuDaiDam < 3)
            {
                Console.WriteLine("Qua ngan, xem lai di!");
            }
            else if (chieuDaiDam >= 3 && chieuDaiDam <= 9)
            {
                Console.WriteLine("Ok roi do, dam binh thuong nha!");
            }
            else
            {
                Console.WriteLine("Dam dai qua cat ngan bot di");
            }

            Console.ReadLine();
        }
    }
}
