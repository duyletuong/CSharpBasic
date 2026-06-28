using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dienTich1 = 0;
            dienTich1 = TinhDienTich(10, 20);
            Console.WriteLine("Dien tich 1 la: " + dienTich1);

            double dienTich2 = 0;
            dienTich2 = TinhDienTich(20, 30);
            Console.WriteLine("Dien tich 2 la: " + dienTich2);

            double dienTich3 = 0;
            dienTich3 = TinhDienTich(30, 40);
            Console.WriteLine("Dien tich 3 la: " + dienTich3);

            double dienTich4 = 0;
            dienTich4 = TinhDienTich(40, 55);
            Console.WriteLine("Dien tich 4 la: " + dienTich4);

            double chuVi = TinhChuVi(10.5, 20.8);
            Console.WriteLine("Chu vi la: " + chuVi);

            Console.ReadLine();
        }

        static double TinhDienTich(double dai, double rong)
        {
            double dienTich = 0;
            dienTich = dai * rong;

            return dienTich;
        }

        static double TinhChuVi(double dai, double rong)
        {
            double chuVi = 0;
            chuVi = (dai + rong) * 2;

            return LamtronSo(chuVi);

            double LamtronSo(double so)
            {
                return Math.Round(so);
            }
        }
    }
}
