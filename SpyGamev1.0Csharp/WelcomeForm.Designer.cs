namespace SpyGamev1._0Csharp
{
    partial class WelcomeForm
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
            this.startBtn = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(85)))), ((int)(((byte)(143)))));
            this.startBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(85)))), ((int)(((byte)(143)))));
            this.startBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.startBtn.BorderRadius = 20;
            this.startBtn.BorderSize = 0;
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.ForeColor = System.Drawing.Color.White;
            this.startBtn.Location = new System.Drawing.Point(451, 288);
            this.startBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(200, 58);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Start";
            this.startBtn.TextColor = System.Drawing.Color.White;
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1119, 630);
            this.Controls.Add(this.startBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "WelcomeForm";
            this.Controls.SetChildIndex(this.startBtn, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJButton startBtn;
    }
}
