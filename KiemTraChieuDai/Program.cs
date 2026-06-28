using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTraChieuDai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> danhSachChieuDaiDam = new List<double>();

            danhSachChieuDaiDam.Add(4500);
            danhSachChieuDaiDam.Add(10000);
            danhSachChieuDaiDam.Add(1000);
            danhSachChieuDaiDam.Add(5000);
            danhSachChieuDaiDam.Add(6000);
            danhSachChieuDaiDam.Add(8000);
            danhSachChieuDaiDam.Add(10000);
            danhSachChieuDaiDam.Add(12000);
            danhSachChieuDaiDam.Add(13000);
            danhSachChieuDaiDam.Add(2000);

            int soLuongDamDaiHon6m = 0;
            int soLuongDamDaiHon12m = 0;
            double tongChieuDaiDam = 0;
            double min = 100000000;
            double max = -1;

            Console.WriteLine("Tong so dam la: " + danhSachChieuDaiDam.Count);

            for (int i = 0; i < danhSachChieuDaiDam.Count; i++)
            {
                Console.WriteLine("Do dai tung dam trong danh sach la: " + danhSachChieuDaiDam[i]);
            }

            for (int i = 0; i < danhSachChieuDaiDam.Count; i++)
            {
                if (danhSachChieuDaiDam[i] > 6000)
                {
                    soLuongDamDaiHon6m = soLuongDamDaiHon6m + 1;
                }

                if (danhSachChieuDaiDam[i] > 12000)
                {
                    soLuongDamDaiHon12m = soLuongDamDaiHon12m + 1;
                }
            }

            for (int i = 0; i < danhSachChieuDaiDam.Count; i++)
            {
                tongChieuDaiDam = tongChieuDaiDam + danhSachChieuDaiDam[i];
            }

            for (int i = 0; i < danhSachChieuDaiDam.Count; i++)
            {
                if (danhSachChieuDaiDam[i] < min)
                {
                    min = danhSachChieuDaiDam[i];
                }

                if (danhSachChieuDaiDam[i] > max)
                {
                    max = danhSachChieuDaiDam[i];
                }
            }

            Console.WriteLine("So dam dai hon 6m: " + soLuongDamDaiHon6m);
            Console.WriteLine("So dam dai hon 12m: " + soLuongDamDaiHon12m);
            Console.WriteLine("Tong chieu dai la: " + tongChieuDaiDam);
            Console.WriteLine("Dam ngan nhat la: " + min);
            Console.WriteLine("Dam dai nhat la: " + max);

            for (int i = 0; i < danhSachChieuDaiDam.Count - 1; i++)
            {
                //vi tri phan tu nho nhat
                int minIndex = i;

                //tim vi tri phan tu nho nhat
                for (int j = i + 1; j < danhSachChieuDaiDam.Count; j++)
                {
                    if (danhSachChieuDaiDam[j] < danhSachChieuDaiDam[minIndex])
                    {
                        minIndex = j;
                    }
                }
                
                //Doi cho
                double temp = danhSachChieuDaiDam[i];
                danhSachChieuDaiDam[i] = danhSachChieuDaiDam[minIndex];
                danhSachChieuDaiDam[minIndex] = temp;
            }

            Console.WriteLine("Danh sach dam theo do dai: ");
            for (int i = 0; i < danhSachChieuDaiDam.Count; i++)
            {
                Console.WriteLine(danhSachChieuDaiDam[i]);
            }

            Console.ReadLine();
        }
    }
}
