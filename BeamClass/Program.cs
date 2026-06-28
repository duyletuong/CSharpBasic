using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace BeamClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyBeam myBeam = new MyBeam();
            myBeam.Profile = "PL10*200";
            myBeam.Material = "SS400";
            myBeam.Name = "Test";
            
            Point startPoint = new Point(1000, 1000, 0);
            Point endPoint = new Point(2000, 1000, 0);

            myBeam.StartPoint = startPoint;
            myBeam.EndPoint = endPoint;

            bool status = myBeam.Insert();

            if (status == true)
            {
                Console.WriteLine("Da insert thanh cong!");
            }
            else
            {
                Console.WriteLine("Insert khong thanh cong, co loi xay ra!");
            }

            Console.ReadLine();
        }
    }

    internal class MyBeam
    {
        internal string Profile;
        internal string Prefix;
        internal int StartNumber;
        internal string Name;
        internal string Finish;
        internal int Phase;
        internal double Length;
        internal string Material;
        internal string PartMark;
        internal Point StartPoint;
        internal Point EndPoint;

        internal MyBeam()
        {

        }

        internal MyBeam(Point startPoint, Point endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }

        public bool Insert()
        {
            if (Profile == "")
            {
                return false;
            }

            if (Material == "")
            {
                return false;
            }

            if (StartPoint == null)
            {
                return false;
            }

            if (EndPoint == null)
            {
                return false;
            }

            // day la code insert vao trong model .......

            return true;
        }
    }

    class Point
    {
        public double X;
        public double Y;
        public double Z;

        public Point(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
