namespace SpyGamev1._0Csharp
{
    partial class AskForm
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
            this.mainAskUserCtrl = new SpyGamev1._0Csharp.RJ_Controls.UserControl3();
            this.nextBtn = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // mainAskUserCtrl
            // 
            this.mainAskUserCtrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.mainAskUserCtrl.Location = new System.Drawing.Point(144, 99);
            this.mainAskUserCtrl.Name = "mainAskUserCtrl";
            this.mainAskUserCtrl.Size = new System.Drawing.Size(920, 483);
            this.mainAskUserCtrl.TabIndex = 4;
            this.mainAskUserCtrl.Load += new System.EventHandler(this.mainAskUserCtrl_Load);
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
            this.nextBtn.Location = new System.Drawing.Point(519, 614);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(150, 47);
            this.nextBtn.TabIndex = 5;
            this.nextBtn.Text = "Next Turn";
            this.nextBtn.TextColor = System.Drawing.Color.White;
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // AskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1205, 696);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.mainAskUserCtrl);
            this.Name = "AskForm";
            this.Controls.SetChildIndex(this.mainAskUserCtrl, 0);
            this.Controls.SetChildIndex(this.nextBtn, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private RJ_Controls.UserControl3 mainAskUserCtrl;
        private CustomControls.RJControls.RJButton nextBtn;
    }
}
