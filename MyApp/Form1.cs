using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tekla.Structures.Model;
using Tekla.Structures.Model.UI;
using TSMUI = Tekla.Structures.Model.UI;
using Tekla.Structures.Geometry3d;
using System.Collections;

namespace MyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSwaphandler_Click(object sender, EventArgs e)
        {
            //khai báo picker - cho phép người dùng pick object trên model
            Picker picker = new Picker();

            ModelObject modelPart = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART, 
                "Xin moi chon beam");

            if (modelPart is Beam)
            {
                // ép kiểu - ép model part thành beam
                //chỉ ép được khi model part chắc chắn là beam
                Beam beam = modelPart as Beam; // cú pháp ép kiểu trong C#

                Point startPoint = beam.StartPoint;
                Point endPoint = beam.EndPoint;

                beam.StartPoint = endPoint;
                beam.EndPoint = startPoint;

                //cập nhật thuộc tính
                beam.Modify();

                //cập nhật thay đổi trên view
                new Model().CommitChanges();
            }
        }

        private void btnSelectObjects_Click(object sender, EventArgs e)
        {
            Picker picker = new Picker();

            ModelObjectEnumerator modelObjects = picker.PickObjects(Picker.PickObjectsEnum.PICK_N_OBJECTS,
                "Xin moi quet chon");

            foreach (var modelObject in modelObjects)
            {
                if (modelObject is Part)
                {
                    Part part = modelObject as Part; // cast model object to Part

                    part.PartNumber.Prefix = txtPrefix.Text + part.PartNumber.Prefix;
                    part.AssemblyNumber.Prefix = txtPrefix.Text + part.AssemblyNumber.Prefix;

                    part.Modify();
                }
                
            }
        }

        private void btnGetSelectedObjects_Click_1(object sender, EventArgs e)
        {
            TSMUI.ModelObjectSelector selector = new TSMUI.ModelObjectSelector();

            ModelObjectEnumerator selectedObjects = selector.GetSelectedObjects();

            while (selectedObjects.MoveNext())
            {
                if (selectedObjects.Current is Part)
                {
                    Part part = (Part)selectedObjects.Current;

                    part.PartNumber.Prefix = txtPrefix.Text + part.PartNumber.Prefix;
                    part.AssemblyNumber.Prefix = txtPrefix.Text + part.AssemblyNumber.Prefix;

                    part.Modify();
                }
            }
        }

        private void btnCreateContourPlate_Click(object sender, EventArgs e)
        {
            ContourPlate contourPlate = new ContourPlate();
            contourPlate.Profile.ProfileString = "PL10";
            contourPlate.Material.MaterialString = "S235JR";

            Picker picker = new Picker();

            //using System.Collections;
            ArrayList listPoints = picker.PickPoints(Picker.PickPointEnum.PICK_POLYGON);

            Contour contour = new Contour();

            //thêm điểm/chamfer cho contour plate
            foreach (Point point in listPoints) 
            {
                Chamfer chamfer = new Chamfer();
                ContourPoint contourPoint = new ContourPoint(point, chamfer);

                contour.AddContourPoint(contourPoint);
            }

            contourPlate.Contour = contour;
            contourPlate.Insert();
            new Model().CommitChanges();
        }

        private void btnCreatePolybeam_Click(object sender, EventArgs e)
        {
            PolyBeam polyBeam = new PolyBeam();
            polyBeam.Profile.ProfileString = "D50";
            polyBeam.Material.MaterialString = "S235JR";

            Picker picker = new Picker();

            //using System.Collections;
            ArrayList listPoints = picker.PickPoints(Picker.PickPointEnum.PICK_POLYGON);

            Contour contour = new Contour();

            //thêm điểm/chamfer cho contour plate
            foreach (Point point in listPoints)
            {
                Chamfer chamfer = new Chamfer();
                ContourPoint contourPoint = new ContourPoint(point, chamfer);

                contour.AddContourPoint(contourPoint);
            }

            polyBeam.Contour = contour;
            polyBeam.Insert();

            new Model().CommitChanges();
        }

        private void btnCreateBolt_Click(object sender, EventArgs e)
        {

        }

        private void btnSetWorkPlaneToBEam_Click(object sender, EventArgs e)
        {
            CoordinateSystem local = new CoordinateSystem();
            local.Origin = new Point(5000, 5000, 0);
            local.AxisX = new Vector(0, 0, 1);
            local.AxisY = new Vector(-1, 0, 0);

            Model model = new Model();
            WorkPlaneHandler wpHandler = model.GetWorkPlaneHandler();

            // lấy tọa độ hiện hành
            TransformationPlane userTransformationPlane = wpHandler.GetCurrentTransformationPlane();

            //set tọa độ mới
            wpHandler.SetCurrentTransformationPlane(new TransformationPlane(local));

            ////vẽ vời
            ///

            //trả về workplane của ngừời dùng
            wpHandler.SetCurrentTransformationPlane(userTransformationPlane)

            model.CommitChanges();
        }
    }
}
