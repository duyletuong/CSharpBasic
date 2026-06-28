namespace CreateBeamPicker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPick = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProfile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.cbOnPlane = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbRotation = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAtDepth = new System.Windows.Forms.ComboBox();
            this.profileCatalog1 = new Tekla.Structures.Dialog.UIControls.ProfileCatalog();
            this.materialCatalog1 = new Tekla.Structures.Dialog.UIControls.MaterialCatalog();
            this.SuspendLayout();
            // 
            // btnPick
            // 
            this.btnPick.Location = new System.Drawing.Point(226, 209);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(172, 52);
            this.btnPick.TabIndex = 0;
            this.btnPick.Text = "Create Beam";
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Profile";
            // 
            // txtProfile
            // 
            this.txtProfile.Location = new System.Drawing.Point(131, 14);
            this.txtProfile.Name = "txtProfile";
            this.txtProfile.Size = new System.Drawing.Size(164, 20);
            this.txtProfile.TabIndex = 2;
            this.txtProfile.Text = "HEA300";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Material";
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(131, 53);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(164, 20);
            this.txtMaterial.TabIndex = 2;
            this.txtMaterial.Text = "S235JR";
            // 
            // cbOnPlane
            // 
            this.cbOnPlane.FormattingEnabled = true;
            this.cbOnPlane.Items.AddRange(new object[] {
            "Middle",
            "Right",
            "Left"});
            this.cbOnPlane.Location = new System.Drawing.Point(131, 93);
            this.cbOnPlane.Name = "cbOnPlane";
            this.cbOnPlane.Size = new System.Drawing.Size(121, 21);
            this.cbOnPlane.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Onplane";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Rotation";
            // 
            // cbRotation
            // 
            this.cbRotation.FormattingEnabled = true;
            this.cbRotation.Items.AddRange(new object[] {
            "Front",
            "Top",
            "Back",
            "Below"});
            this.cbRotation.Location = new System.Drawing.Point(131, 124);
            this.cbRotation.Name = "cbRotation";
            this.cbRotation.Size = new System.Drawing.Size(121, 21);
            this.cbRotation.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "At depth";
            // 
            // cbAtDepth
            // 
            this.cbAtDepth.FormattingEnabled = true;
            this.cbAtDepth.Items.AddRange(new object[] {
            "Middle",
            "Front",
            "Behind"});
            this.cbAtDepth.Location = new System.Drawing.Point(131, 156);
            this.cbAtDepth.Name = "cbAtDepth";
            this.cbAtDepth.Size = new System.Drawing.Size(121, 21);
            this.cbAtDepth.TabIndex = 3;
            // 
            // profileCatalog1
            // 
            this.profileCatalog1.BackColor = System.Drawing.Color.Transparent;
            this.profileCatalog1.ButtonText = "albl_Select__";
            this.profileCatalog1.Location = new System.Drawing.Point(301, 12);
            this.profileCatalog1.Name = "profileCatalog1";
            this.profileCatalog1.SelectedProfile = "";
            this.profileCatalog1.Size = new System.Drawing.Size(106, 27);
            this.profileCatalog1.TabIndex = 4;
            this.profileCatalog1.SelectClicked += new System.EventHandler(this.profileCatalog1_SelectClicked);
            this.profileCatalog1.SelectionDone += new System.EventHandler(this.profileCatalog1_SelectionDone);
            // 
            // materialCatalog1
            // 
            this.materialCatalog1.BackColor = System.Drawing.Color.Transparent;
            this.materialCatalog1.ButtonText = "albl_Select__";
            this.materialCatalog1.Location = new System.Drawing.Point(301, 52);
            this.materialCatalog1.Name = "materialCatalog1";
            this.materialCatalog1.SelectedMaterial = "";
            this.materialCatalog1.Size = new System.Drawing.Size(106, 27);
            this.materialCatalog1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 278);
            this.Controls.Add(this.materialCatalog1);
            this.Controls.Add(this.profileCatalog1);
            this.Controls.Add(this.cbAtDepth);
            this.Controls.Add(this.cbRotation);
            this.Controls.Add(this.cbOnPlane);
            this.Controls.Add(this.txtMaterial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProfile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Vẽ beam bằng Picker";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.ComboBox cbOnPlane;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbRotation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbAtDepth;
        private Tekla.Structures.Dialog.UIControls.ProfileCatalog profileCatalog1;
        private Tekla.Structures.Dialog.UIControls.MaterialCatalog materialCatalog1;
    }
}

