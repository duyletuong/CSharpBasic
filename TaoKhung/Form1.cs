using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;

namespace TaoKhung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTaoKhung_Click(object sender, EventArgs e)
        {
            Model model = new Model();

            bool connected = model.GetConnectionStatus();

            if (connected == false)
            {
                MessageBox.Show("Khong ket noi duoc Tekla!");
                return;
            }


            double khauDo = Convert.ToDouble(txtKhauDo.Text);
            double nhip = double.Parse(txtNhip.Text);
            double chieuCaoCot = double.Parse(txtChieuCaoCot.Text);
            double chieuCaoDinhKeo = double.Parse(txtChieuCaoDinhKeo.Text);
            int soKhung = Convert.ToInt32(txtSoKhung.Text);

            for (int i = 0; i < soKhung; i++)
            {
                Beam cot1 = new Beam();
                cot1.Profile.ProfileString = txtProfileCot.Text;
                cot1.Material.MaterialString = "S235JR";
                cot1.Class = "3";

                cot1.Position.Rotation = Position.RotationEnum.FRONT;
                cot1.Position.Depth = Position.DepthEnum.MIDDLE;
                cot1.Position.Plane = Position.PlaneEnum.MIDDLE;

                Point startCot1 = new Point(0 , i * nhip, 0);
                Point endCot1 = new Point(0, i * nhip, chieuCaoCot);

                cot1.StartPoint = startCot1;
                cot1.EndPoint = endCot1;

                cot1.Insert();

                Beam cot2 = new Beam();
                cot2.Profile.ProfileString = txtProfileCot.Text;
                cot2.Material.MaterialString = "S235JR";
                cot2.Class = "3";

                cot2.Position.Rotation = Position.RotationEnum.FRONT;
                cot2.Position.Depth = Position.DepthEnum.MIDDLE;
                cot2.Position.Plane = Position.PlaneEnum.MIDDLE;

                Point startCot2 = new Point(khauDo, i * nhip, 0);
                Point endCot2 = new Point(khauDo, i * nhip, chieuCaoCot);

                cot2.StartPoint= startCot2;
                cot2.EndPoint = endCot2;

                cot2.Insert();

                // Tạo kèo

                Beam keo1 = new Beam();
                keo1.Profile.ProfileString = txtProfileKeo.Text;
                keo1.Material.MaterialString = "S235JR";
                keo1.Class = "4";

                keo1.Position.Rotation = Position.RotationEnum.TOP;
                keo1.Position.Depth = Position.DepthEnum.BEHIND;
                keo1.Position.Plane = Position.PlaneEnum.MIDDLE;

                Point startkeo1 = endCot1;
                Point endkeo1 = new Point(khauDo/2, i * nhip, chieuCaoDinhKeo);

                keo1.StartPoint = startkeo1;
                keo1.EndPoint = endkeo1;

                keo1.Insert();

                Beam keo2 = new Beam();
                keo2.Profile.ProfileString = txtProfileKeo.Text;
                keo2.Material.MaterialString = "S235JR";
                keo2.Class = "4";

                keo2.Position.Rotation = Position.RotationEnum.TOP;
                keo2.Position.Depth = Position.DepthEnum.BEHIND;
                keo2.Position.Plane = Position.PlaneEnum.MIDDLE;

                Point startkeo2 = endCot2;
                Point endkeo2 = endkeo1;

                keo2.StartPoint = startkeo2;
                keo2.EndPoint = endkeo2;

                keo2.Insert();
            }

            model.CommitChanges();

            MessageBox.Show("Đã tạo khung thành công!");
        }
    }
}
