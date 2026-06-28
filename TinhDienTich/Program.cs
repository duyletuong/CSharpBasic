using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDienTich
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chieuDai;
            double chieuRong;
            double dienTich;

            Console.WriteLine("Xin moi nhap chieu dai: ");
            chieuDai = double.Parse(Console.ReadLine()); // doc chuoi tu ban phim

            Console.WriteLine("Xin moi nhap chieu rong: ");
            chieuRong = double.Parse(Console.ReadLine());

            dienTich = chieuDai * chieuRong;

            Console.WriteLine("dien tich la: " + dienTich);

            Console.ReadLine(); // dung man hinh
        }
    }
}
