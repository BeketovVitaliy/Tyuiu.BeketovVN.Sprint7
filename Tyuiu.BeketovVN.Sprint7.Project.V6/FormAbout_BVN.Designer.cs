namespace Tyuiu.BeketovVN.Sprint7.Project.V6
{
    partial class FormAbout_BVN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_BVN));
            this.buttonOK_BVN = new System.Windows.Forms.Button();
            this.pictureBoxAvatar_BVN = new System.Windows.Forms.PictureBox();
            this.labelInfo_BVN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_BVN)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK_BVN
            // 
            this.buttonOK_BVN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.buttonOK_BVN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.buttonOK_BVN.Location = new System.Drawing.Point(331, 157);
            this.buttonOK_BVN.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK_BVN.Name = "buttonOK_BVN";
            this.buttonOK_BVN.Size = new System.Drawing.Size(112, 32);
            this.buttonOK_BVN.TabIndex = 11;
            this.buttonOK_BVN.Text = "Ок";
            this.buttonOK_BVN.UseVisualStyleBackColor = false;
            this.buttonOK_BVN.Click += new System.EventHandler(this.buttonOK_BVN_Click);
            // 
            // pictureBoxAvatar_BVN
            // 
            this.pictureBoxAvatar_BVN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAvatar_BVN.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_BVN.Image")));
            this.pictureBoxAvatar_BVN.InitialImage = null;
            this.pictureBoxAvatar_BVN.Location = new System.Drawing.Point(2, 2);
            this.pictureBoxAvatar_BVN.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxAvatar_BVN.Name = "pictureBoxAvatar_BVN";
            this.pictureBoxAvatar_BVN.Size = new System.Drawing.Size(177, 200);
            this.pictureBoxAvatar_BVN.TabIndex = 10;
            this.pictureBoxAvatar_BVN.TabStop = false;
            // 
            // labelInfo_BVN
            // 
            this.labelInfo_BVN.AutoSize = true;
            this.labelInfo_BVN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.labelInfo_BVN.Location = new System.Drawing.Point(187, 9);
            this.labelInfo_BVN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo_BVN.Name = "labelInfo_BVN";
            this.labelInfo_BVN.Size = new System.Drawing.Size(284, 130);
            this.labelInfo_BVN.TabIndex = 9;
            this.labelInfo_BVN.Text = resources.GetString("labelInfo_BVN.Text");
            // 
            // FormAbout_BVN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(471, 204);
            this.Controls.Add(this.buttonOK_BVN);
            this.Controls.Add(this.pictureBoxAvatar_BVN);
            this.Controls.Add(this.labelInfo_BVN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout_BVN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_BVN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK_BVN;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_BVN;
        private System.Windows.Forms.Label labelInfo_BVN;
    }
}