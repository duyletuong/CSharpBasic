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
using Tekla.Structures.Geometry3d;

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
    }
}
