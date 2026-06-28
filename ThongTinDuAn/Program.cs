using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThongTinDuAn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tenDuAn = "Ware house";
            int soTang = 10;
            double chieuCao = 50.5;
            bool daXong = false;

            Console.WriteLine("Du an: " + tenDuAn);
            Console.WriteLine("So tang: " + soTang);
            Console.WriteLine("Chieu cao: " + chieuCao);

            if (daXong == true)
            {
                Console.WriteLine("Du an nay xong roi nha!");
            }
            else 
            {
                Console.WriteLine("Du an nay chua xong dau nha!, lo ma lam di");
            }

            Console.ReadLine();
        }
    }
}
