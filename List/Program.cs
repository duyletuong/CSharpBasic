using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> danhSachDam = new List<string>();

            //danhSachDam.Add("B1");
            //danhSachDam.Add("B2");
            //danhSachDam.Add("B3");
            //danhSachDam.Add("B4");

            //Console.WriteLine("Dam dau tien la: " + danhSachDam[0]);
            //Console.WriteLine("Dam so 2 la: " + danhSachDam[1]);
            //Console.WriteLine("Dam so 3 la: " + danhSachDam[2]);
            //Console.WriteLine("Dam cuoi la: " + danhSachDam[3]);

            //if (danhSachDam.Contains("B4") == true)
            //{
            //    Console.WriteLine("Dam B4 co trong danh sach nha!");
            //}
            //else
            //{
            //    Console.WriteLine("Dam B4 khong co nha!");
            //}

            List<double> danhSachCacSoCanTinhTong = new List<double>();

            for (int i = 10; i <= 100; i+=10)
            {
                danhSachCacSoCanTinhTong.Add(i);
            }


            double tongDanhSach = 0;
            tongDanhSach = TinhTongDanhSach(danhSachCacSoCanTinhTong);
            Console.WriteLine("Tong la: " + tongDanhSach);

            Console.ReadLine();
        }

        static double TinhTongDanhSach(List<double> danhSach) 
        {
            double tong = 0;

            for (int i = 0; i < danhSach.Count; i++)
            {
                tong = TinhTong(tong, danhSach[i]);
            }

            return tong;

            double TinhTong(double so1, double so2) 
            {
                return so1 + so2;
            }
        }
    }
}
