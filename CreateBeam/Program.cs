using Tekla.Structures.Model;
using Tekla.Common.Geometry;
using Tekla.Structures.Geometry3d;
using System;

namespace CreateBeam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beam myBeam = new Beam();
            myBeam.Profile.ProfileString = "PL10*200";
            myBeam.Material.MaterialString = "S235JR";
            myBeam.Name = "my new test beam";
            myBeam.PartNumber.Prefix = "beam";
            myBeam.PartNumber.StartNumber = 1;
            myBeam.Class = "3";
            myBeam.Position.Plane = Position.PlaneEnum.MIDDLE;
            myBeam.Position.Rotation = Position.RotationEnum.FRONT;
            myBeam.Position.Depth = Position.DepthEnum.MIDDLE;
            
            Point startPoint = new Point(0,0,0);
            Point endPoint = new Point(7200,0,0);

            myBeam.StartPoint = startPoint;
            myBeam.EndPoint = endPoint;

            bool result = myBeam.Insert();

            Model model = new Model();
            model.CommitChanges();

            if (result == true)
            {
                Console.WriteLine("Tao roi do nha kiem tra dum cai di!");
            }
            else
            {
                Console.WriteLine("tao ko dc, co loi o dau do roi!");
            }

            Console.ReadLine();
        }
    }
}
