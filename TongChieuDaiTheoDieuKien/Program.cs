using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongChieuDaiTheoDieuKien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chuong trinh tu dong tinh chieu dai thanh!!!");
            Console.WriteLine("Version 10.2.3");
            Console.WriteLine("---==== @@@@ ====---");

            int soThanh;
            double tongChieuDaiTren6m = 0;
            double tongChieuDaiDuoi6m = 0;

            Console.Write("Xin moi nhap so thanh can tinh: ");
            soThanh = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= soThanh; i++)
            {
                double chieuDaiThanh;
                Console.WriteLine("Xin moi nhap chieu dai thanh: " + i);
                chieuDaiThanh = Convert.ToDouble(Console.ReadLine());

                if (chieuDaiThanh >= 6)
                {
                    tongChieuDaiTren6m = tongChieuDaiTren6m + chieuDaiThanh;
                }
                else
                {
                    tongChieuDaiDuoi6m += chieuDaiThanh;
                }
            }

            Console.WriteLine("Da tinh toan xong!!!");
            Console.WriteLine("Tong chieu dai thanh tu 6m la: " + tongChieuDaiTren6m);

            Console.WriteLine("Tong chieu dai thanh duoi 6m la: " + tongChieuDaiDuoi6m);
            Console.ReadLine();
        }
    }
}
