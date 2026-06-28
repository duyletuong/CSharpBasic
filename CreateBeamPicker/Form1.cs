using System;
using System.Windows.Forms;
using Tekla.Structures.Model;
using Tekla.Structures.Model.UI;
using Tekla.Structures.Geometry3d;


namespace CreateBeamPicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            Beam myBeam = new Beam();
            myBeam.Profile.ProfileString = txtProfile.Text;
            myBeam.Material.MaterialString = txtMaterial.Text;

            if (cbOnPlane.Text == "Middle")
            {
                myBeam.Position.Plane = Position.PlaneEnum.MIDDLE;
            }
            else if (cbOnPlane.Text == "Right")
            {
                myBeam.Position.Plane = Position.PlaneEnum.RIGHT;
            }
            else if (cbOnPlane.Text == "Left")
            {
                myBeam.Position.Plane = Position.PlaneEnum.LEFT;
            }
            else
            {
                // Mặc định là middle - nếu người dùng k chọn
                myBeam.Position.Plane = Position.PlaneEnum.MIDDLE;
            }

            if (cbRotation.Text == "Front")
            {
                myBeam.Position.Rotation = Position.RotationEnum.FRONT;
            }
            else if (cbRotation.Text == "Top")
            {
                myBeam.Position.Rotation = Position.RotationEnum.TOP;
            }
            else if (cbRotation.Text == "Back")
            {
                myBeam.Position.Rotation = Position.RotationEnum.BACK;
            }
            else
            {
                myBeam.Position.Rotation = Position.RotationEnum.BELOW;
            }

            // anh em tự xử
            myBeam.Position.Depth = Position.DepthEnum.MIDDLE;

            Picker picker = new Picker();

            Point startPoint = picker.PickPoint("Xin mời chọn điểm start Point");
            Point endPoint = picker.PickPoint("Xin mời chọn end Point");

            picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);
           
            myBeam.StartPoint= startPoint;
            myBeam.EndPoint= endPoint;

            myBeam.Insert();

            new Model().CommitChanges();
        }

        private void profileCatalog1_SelectClicked(object sender, EventArgs e)
        {
            profileCatalog1.SelectedProfile = txtProfile.Text;
        }

        private void profileCatalog1_SelectionDone(object sender, EventArgs e)
        {
            
        }
    }
}
