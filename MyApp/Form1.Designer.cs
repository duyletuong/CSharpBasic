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
            this.txtPrefix.Location = new System.Drawing.Point(144, 86);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(125, 20);
            this.txtPrefix.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 279);
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
    }
}

