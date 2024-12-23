namespace SpyGamev1._0Csharp.RJ_Controls
{
    partial class UserControl3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userControl12 = new SpyGamev1._0Csharp.RJ_Controls.UserControl1();
            this.userControl11 = new SpyGamev1._0Csharp.RJ_Controls.UserControl1();
            this.askerPlayer = new SpyGamev1._0Csharp.RJ_Controls.UserControl1();
            this.answererPlayer = new SpyGamev1._0Csharp.RJ_Controls.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(298, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // userControl12
            // 
            this.userControl12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.userControl12.CardImage = ((System.Drawing.Image)(resources.GetObject("userControl12.CardImage")));
            this.userControl12.CardName = "mohmmed mohssen";
            this.userControl12.Location = new System.Drawing.Point(665, 125);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(240, 215);
            this.userControl12.TabIndex = 2;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.userControl11.CardImage = ((System.Drawing.Image)(resources.GetObject("userControl11.CardImage")));
            this.userControl11.CardName = "mohmmed mohssen";
            this.userControl11.Location = new System.Drawing.Point(25, 125);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(240, 215);
            this.userControl11.TabIndex = 1;
            // 
            // askerPlayer
            // 
            this.askerPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.askerPlayer.CardImage = ((System.Drawing.Image)(resources.GetObject("askerPlayer.CardImage")));
            this.askerPlayer.CardName = "mohmmed mohssen";
            this.askerPlayer.Location = new System.Drawing.Point(25, 145);
            this.askerPlayer.Name = "askerPlayer";
            this.askerPlayer.Size = new System.Drawing.Size(240, 215);
            this.askerPlayer.TabIndex = 1;
            // 
            // answererPlayer
            // 
            this.answererPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.answererPlayer.CardImage = ((System.Drawing.Image)(resources.GetObject("answererPlayer.CardImage")));
            this.answererPlayer.CardName = "mohmmed mohssen";
            this.answererPlayer.Location = new System.Drawing.Point(665, 145);
            this.answererPlayer.Name = "answererPlayer";
            this.answererPlayer.Size = new System.Drawing.Size(240, 215);
            this.answererPlayer.TabIndex = 2;
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.answererPlayer);
            this.Controls.Add(this.askerPlayer);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.userControl11);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(920, 482);
            this.Load += new System.EventHandler(this.UserControl3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 userControl11;
        private UserControl1 userControl12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControl1 askerPlayer;
        private UserControl1 answererPlayer;
    }
}
