using System.Drawing;
using System;

namespace SpyGamev1._0Csharp.RJ_Controls
{
    partial class UserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.plyrNameLbl = new System.Windows.Forms.Label();
            this.plyrImg = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // plyrNameLbl
            // 
            this.plyrNameLbl.AutoSize = true;
            this.plyrNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plyrNameLbl.Location = new System.Drawing.Point(27, 168);
            this.plyrNameLbl.Name = "plyrNameLbl";
            this.plyrNameLbl.Size = new System.Drawing.Size(189, 25);
            this.plyrNameLbl.TabIndex = 2;
            this.plyrNameLbl.Text = "mohmmed mohssen";
            this.plyrNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plyrNameLbl.Click += new System.EventHandler(this.plyrNameLbl_Click);
            this.plyrNameLbl.Resize += new System.EventHandler(this.plyrNameLbl_Resize);
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
            this.plyrImg.Location = new System.Drawing.Point(52, 16);
            this.plyrImg.Margin = new System.Windows.Forms.Padding(4);
            this.plyrImg.Name = "plyrImg";
            this.plyrImg.Size = new System.Drawing.Size(130, 130);
            this.plyrImg.TabIndex = 1;
            this.plyrImg.TextColor = System.Drawing.Color.White;
            this.plyrImg.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.plyrImg.UseVisualStyleBackColor = false;
            this.plyrImg.Click += new System.EventHandler(this.plyrImg_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.plyrNameLbl);
            this.Controls.Add(this.plyrImg);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(240, 215);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.Resize += new System.EventHandler(this.UserControl1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJButton plyrImg;
        private System.Windows.Forms.Label plyrNameLbl;
    }
}
