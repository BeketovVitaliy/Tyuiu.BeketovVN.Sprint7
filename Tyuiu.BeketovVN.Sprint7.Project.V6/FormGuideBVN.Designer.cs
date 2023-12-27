namespace Tyuiu.BeketovVN.Sprint7.Project.V6
{
    partial class FormGuide_BVN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide_BVN));
            this.pictureBoxManual_BVN = new System.Windows.Forms.PictureBox();
            this.buttonPrev_BVN = new System.Windows.Forms.Button();
            this.buttonNext_BVN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManual_BVN)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxManual_BVN
            // 
            this.pictureBoxManual_BVN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxManual_BVN.BackgroundImage")));
            this.pictureBoxManual_BVN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxManual_BVN.Location = new System.Drawing.Point(93, -2);
            this.pictureBoxManual_BVN.Name = "pictureBoxManual_BVN";
            this.pictureBoxManual_BVN.Size = new System.Drawing.Size(900, 571);
            this.pictureBoxManual_BVN.TabIndex = 0;
            this.pictureBoxManual_BVN.TabStop = false;
            // 
            // buttonPrev_BVN
            // 
            this.buttonPrev_BVN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.buttonPrev_BVN.Enabled = false;
            this.buttonPrev_BVN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrev_BVN.Location = new System.Drawing.Point(12, 261);
            this.buttonPrev_BVN.Name = "buttonPrev_BVN";
            this.buttonPrev_BVN.Size = new System.Drawing.Size(75, 65);
            this.buttonPrev_BVN.TabIndex = 1;
            this.buttonPrev_BVN.Text = "<";
            this.buttonPrev_BVN.UseVisualStyleBackColor = false;
            this.buttonPrev_BVN.Click += new System.EventHandler(this.buttonPrev_BVN_Click);
            // 
            // buttonNext_BVN
            // 
            this.buttonNext_BVN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.buttonNext_BVN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext_BVN.Location = new System.Drawing.Point(999, 261);
            this.buttonNext_BVN.Name = "buttonNext_BVN";
            this.buttonNext_BVN.Size = new System.Drawing.Size(75, 65);
            this.buttonNext_BVN.TabIndex = 2;
            this.buttonNext_BVN.Text = ">";
            this.buttonNext_BVN.UseVisualStyleBackColor = false;
            this.buttonNext_BVN.Click += new System.EventHandler(this.buttonNext_BVN_Click);
            // 
            // FormGuide_BVN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1086, 573);
            this.Controls.Add(this.buttonNext_BVN);
            this.Controls.Add(this.buttonPrev_BVN);
            this.Controls.Add(this.pictureBoxManual_BVN);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGuide_BVN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Руководство пользователя";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManual_BVN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxManual_BVN;
        private System.Windows.Forms.Button buttonPrev_BVN;
        private System.Windows.Forms.Button buttonNext_BVN;
    }
}