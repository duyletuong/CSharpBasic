namespace MyApp
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
            this.btnSwaphandler = new System.Windows.Forms.Button();
            this.btnSelectObjects = new System.Windows.Forms.Button();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.btnGetSelectedObjects = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateContourPlate = new System.Windows.Forms.Button();
            this.btnCreatePolybeam = new System.Windows.Forms.Button();
            this.btnCreateBolt = new System.Windows.Forms.Button();
            this.btnSetWorkPlaneToBEam = new System.Windows.Forms.Button();
            this.btnCheckLength12m = new System.Windows.Forms.Button();
            this.btnCheckAssembly12m = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSwaphandler
            // 
            this.btnSwaphandler.Location = new System.Drawing.Point(13, 13);
            this.btnSwaphandler.Name = "btnSwaphandler";
            this.btnSwaphandler.Size = new System.Drawing.Size(125, 50);
            this.btnSwaphandler.TabIndex = 0;
            this.btnSwaphandler.Text = "Swap handler";
            this.btnSwaphandler.UseVisualStyleBackColor = true;
            this.btnSwaphandler.Click += new System.EventHandler(this.btnSwaphandler_Click);
            // 
            // btnSelectObjects
            // 
            this.btnSelectObjects.Location = new System.Drawing.Point(144, 13);
            this.btnSelectObjects.Name = "btnSelectObjects";
            this.btnSelectObjects.Size = new System.Drawing.Size(125, 50);
            this.btnSelectObjects.TabIndex = 0;
            this.btnSelectObjects.Text = "Select objects";
            this.btnSelectObjects.UseVisualStyleBackColor = true;
            this.btnSelectObjects.Click += new System.EventHandler(this.btnSelectObjects_Click);
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(215, 74);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(125, 20);
            this.txtPrefix.TabIndex = 1;
            // 
            // btnGetSelectedObjects
            // 
            this.btnGetSelectedObjects.Location = new System.Drawing.Point(275, 13);
            this.btnGetSelectedObjects.Name = "btnGetSelectedObjects";
            this.btnGetSelectedObjects.Size = new System.Drawing.Size(125, 50);
            this.btnGetSelectedObjects.TabIndex = 2;
            this.btnGetSelectedObjects.Text = "Get selected Objects";
            this.btnGetSelectedObjects.UseVisualStyleBackColor = true;
            this.btnGetSelectedObjects.Click += new System.EventHandler(this.btnGetSelectedObjects_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Prefix";
            // 
            // btnCreateContourPlate
            // 
            this.btnCreateContourPlate.Location = new System.Drawing.Point(13, 129);
            this.btnCreateContourPlate.Name = "btnCreateContourPlate";
            this.btnCreateContourPlate.Size = new System.Drawing.Size(125, 27);
            this.btnCreateContourPlate.TabIndex = 4;
            this.btnCreateContourPlate.Text = "Create contour plate";
            this.btnCreateContourPlate.UseVisualStyleBackColor = true;
            this.btnCreateContourPlate.Click += new System.EventHandler(this.btnCreateContourPlate_Click);
            // 
            // btnCreatePolybeam
            // 
            this.btnCreatePolybeam.Location = new System.Drawing.Point(13, 162);
            this.btnCreatePolybeam.Name = "btnCreatePolybeam";
            this.btnCreatePolybeam.Size = new System.Drawing.Size(125, 27);
            this.btnCreatePolybeam.TabIndex = 5;
            this.btnCreatePolybeam.Text = "Create poly beam";
            this.btnCreatePolybeam.UseVisualStyleBackColor = true;
            this.btnCreatePolybeam.Click += new System.EventHandler(this.btnCreatePolybeam_Click);
            // 
            // btnCreateBolt
            // 
            this.btnCreateBolt.Location = new System.Drawing.Point(144, 129);
            this.btnCreateBolt.Name = "btnCreateBolt";
            this.btnCreateBolt.Size = new System.Drawing.Size(125, 27);
            this.btnCreateBolt.TabIndex = 6;
            this.btnCreateBolt.Text = "Create bolt";
            this.btnCreateBolt.UseVisualStyleBackColor = true;
            this.btnCreateBolt.Click += new System.EventHandler(this.btnCreateBolt_Click);
            // 
            // btnSetWorkPlaneToBEam
            // 
            this.btnSetWorkPlaneToBEam.Location = new System.Drawing.Point(13, 221);
            this.btnSetWorkPlaneToBEam.Name = "btnSetWorkPlaneToBEam";
            this.btnSetWorkPlaneToBEam.Size = new System.Drawing.Size(125, 46);
            this.btnSetWorkPlaneToBEam.TabIndex = 7;
            this.btnSetWorkPlaneToBEam.Text = "Set work plane to beam";
            this.btnSetWorkPlaneToBEam.UseVisualStyleBackColor = true;
            this.btnSetWorkPlaneToBEam.Click += new System.EventHandler(this.btnSetWorkPlaneToBEam_Click);
            // 
            // btnCheckLength12m
            // 
            this.btnCheckLength12m.Location = new System.Drawing.Point(314, 129);
            this.btnCheckLength12m.Name = "btnCheckLength12m";
            this.btnCheckLength12m.Size = new System.Drawing.Size(137, 46);
            this.btnCheckLength12m.TabIndex = 8;
            this.btnCheckLength12m.Text = "Check Part length: 12m";
            this.btnCheckLength12m.UseVisualStyleBackColor = true;
            this.btnCheckLength12m.Click += new System.EventHandler(this.btnCheckLength12m_Click);
            // 
            // btnCheckAssembly12m
            // 
            this.btnCheckAssembly12m.Location = new System.Drawing.Point(314, 181);
            this.btnCheckAssembly12m.Name = "btnCheckAssembly12m";
            this.btnCheckAssembly12m.Size = new System.Drawing.Size(137, 46);
            this.btnCheckAssembly12m.TabIndex = 9;
            this.btnCheckAssembly12m.Text = "Check Assembly length: 12m";
            this.btnCheckAssembly12m.UseVisualStyleBackColor = true;
            this.btnCheckAssembly12m.Click += new System.EventHandler(this.btnCheckAssembly12m_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 279);
            this.Controls.Add(this.btnCheckAssembly12m);
            this.Controls.Add(this.btnCheckLength12m);
            this.Controls.Add(this.btnSetWorkPlaneToBEam);
            this.Controls.Add(this.btnCreateBolt);
            this.Controls.Add(this.btnCreatePolybeam);
            this.Controls.Add(this.btnCreateContourPlate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetSelectedObjects);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.btnSelectObjects);
            this.Controls.Add(this.btnSwaphandler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSwaphandler;
        private System.Windows.Forms.Button btnSelectObjects;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Button btnGetSelectedObjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateContourPlate;
        private System.Windows.Forms.Button btnCreatePolybeam;
        private System.Windows.Forms.Button btnCreateBolt;
        private System.Windows.Forms.Button btnSetWorkPlaneToBEam;
        private System.Windows.Forms.Button btnCheckLength12m;
        private System.Windows.Forms.Button btnCheckAssembly12m;
    }
}

