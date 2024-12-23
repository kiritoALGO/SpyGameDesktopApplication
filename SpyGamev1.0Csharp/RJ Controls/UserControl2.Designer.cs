namespace SpyGamev1._0Csharp.RJ_Controls
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl2));
            this.plyrNameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plyrImg = new CustomControls.RJControls.RJButton();
            this.wordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // plyrNameLbl
            // 
            this.plyrNameLbl.AutoSize = true;
            this.plyrNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plyrNameLbl.Location = new System.Drawing.Point(86, 337);
            this.plyrNameLbl.Name = "plyrNameLbl";
            this.plyrNameLbl.Size = new System.Drawing.Size(189, 25);
            this.plyrNameLbl.TabIndex = 4;
            this.plyrNameLbl.Text = "mohmmed mohssen";
            this.plyrNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Turn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // plyrImg
            // 
            this.plyrImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.plyrImg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.plyrImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plyrImg.BackgroundImage")));
            this.plyrImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plyrImg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.plyrImg.BorderRadius = 20;
            this.plyrImg.BorderSize = 0;
            this.plyrImg.FlatAppearance.BorderSize = 0;
            this.plyrImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plyrImg.ForeColor = System.Drawing.Color.White;
            this.plyrImg.Location = new System.Drawing.Point(91, 44);
            this.plyrImg.Margin = new System.Windows.Forms.Padding(4);
            this.plyrImg.Name = "plyrImg";
            this.plyrImg.Size = new System.Drawing.Size(150, 150);
            this.plyrImg.TabIndex = 3;
            this.plyrImg.TextColor = System.Drawing.Color.White;
            this.plyrImg.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.plyrImg.UseVisualStyleBackColor = false;
            this.plyrImg.Click += new System.EventHandler(this.plyrImg_Click);
            // 
            // wordLabel
            // 
            this.wordLabel.AutoSize = true;
            this.wordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordLabel.ForeColor = System.Drawing.Color.LawnGreen;
            this.wordLabel.Location = new System.Drawing.Point(41, 224);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(280, 69);
            this.wordLabel.TabIndex = 6;
            this.wordLabel.Text = "the Word";
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.wordLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plyrNameLbl);
            this.Controls.Add(this.plyrImg);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(368, 482);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label plyrNameLbl;
        private CustomControls.RJControls.RJButton plyrImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label wordLabel;
    }
}
