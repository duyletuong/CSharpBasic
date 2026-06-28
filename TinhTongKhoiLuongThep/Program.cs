using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTongKhoiLuongThep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soLuongThanh;
            double chieuDaiThanh;
            double trongLuongRieng;
            double khoiLuong;

            Console.Write("Xin moi nhap so thanh: ");
            soLuongThanh = int.Parse(Console.ReadLine());

            Console.Write("Xin moi nhap chieu dai thanh: ");
            chieuDaiThanh = double.Parse(Console.ReadLine());

            Console.Write("Xin moi nhap trong luong rieng: ");
            trongLuongRieng = double.Parse(Console.ReadLine());

            khoiLuong = chieuDaiThanh * soLuongThanh * trongLuongRieng;

            Console.WriteLine("Tong khoi luong la: " + khoiLuong);
            Console.ReadLine();
        }
    }
}
