namespace SpyGamev1._0Csharp
{
    partial class KnowYourStateForm
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
            this.mainUserControl = new SpyGamev1._0Csharp.RJ_Controls.UserControl2();
            this.nextBtn = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // mainUserControl
            // 
            this.mainUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.mainUserControl.Location = new System.Drawing.Point(415, 93);
            this.mainUserControl.Name = "mainUserControl";
            this.mainUserControl.Size = new System.Drawing.Size(368, 482);
            this.mainUserControl.TabIndex = 3;
            this.mainUserControl.Load += new System.EventHandler(this.mainUserControl_Load);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(85)))), ((int)(((byte)(143)))));
            this.nextBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(85)))), ((int)(((byte)(143)))));
            this.nextBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.nextBtn.BorderRadius = 20;
            this.nextBtn.BorderSize = 0;
            this.nextBtn.FlatAppearance.BorderSize = 0;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.ForeColor = System.Drawing.Color.White;
            this.nextBtn.Location = new System.Drawing.Point(515, 606);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(150, 47);
            this.nextBtn.TabIndex = 4;
            this.nextBtn.Text = "Spin";
            this.nextBtn.TextColor = System.Drawing.Color.White;
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // KnowYourStateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1205, 696);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.mainUserControl);
            this.Name = "KnowYourStateForm";
            this.Controls.SetChildIndex(this.mainUserControl, 0);
            this.Controls.SetChildIndex(this.nextBtn, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private RJ_Controls.UserControl2 mainUserControl;
        private CustomControls.RJControls.RJButton nextBtn;
    }
}
