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

            for (int i = 1; i <= soKhung; i++)
            {
                Beam cot1 = new Beam();
                cot1.Profile.ProfileString = txtProfileCot.Text;
                cot1.Material.MaterialString = "S235JR";

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

                cot2.Position.Rotation = Position.RotationEnum.FRONT;
                cot2.Position.Depth = Position.DepthEnum.MIDDLE;
                cot2.Position.Plane = Position.PlaneEnum.MIDDLE;

                Point startCot2 = new Point(khauDo, i * nhip, 0);
                Point endCot2 = new Point(khauDo, i * nhip, chieuCaoCot);

                cot2.StartPoint= startCot2;
                cot2.EndPoint = endCot2;

                cot2.Insert();

            }

            model.CommitChanges();

            MessageBox.Show("Đã tạo khung thành công!");
        }
    }
}
