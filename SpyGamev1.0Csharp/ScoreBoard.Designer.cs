namespace SpyGamev1._0Csharp
{
    partial class ScoreBoard
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
            this.cardsPanel = new System.Windows.Forms.Panel();
            this.voteForNameLbl = new System.Windows.Forms.Label();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // cardsPanel
            // 
            this.cardsPanel.Location = new System.Drawing.Point(48, 141);
            this.cardsPanel.Name = "cardsPanel";
            this.cardsPanel.Size = new System.Drawing.Size(1101, 483);
            this.cardsPanel.TabIndex = 18;
            // 
            // voteForNameLbl
            // 
            this.voteForNameLbl.AutoSize = true;
            this.voteForNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voteForNameLbl.Location = new System.Drawing.Point(447, 73);
            this.voteForNameLbl.Name = "voteForNameLbl";
            this.voteForNameLbl.Size = new System.Drawing.Size(295, 38);
            this.voteForNameLbl.TabIndex = 20;
            this.voteForNameLbl.Text = "Final Score Board";
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(85)))), ((int)(((byte)(143)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(85)))), ((int)(((byte)(143)))));
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 20;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(529, 637);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(150, 47);
            this.rjButton2.TabIndex = 21;
            this.rjButton2.Text = "Main Menu";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // ScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1205, 696);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.voteForNameLbl);
            this.Controls.Add(this.cardsPanel);
            this.Name = "ScoreBoard";
            this.Load += new System.EventHandler(this.ScoreBoard_Load);
            this.Controls.SetChildIndex(this.cardsPanel, 0);
            this.Controls.SetChildIndex(this.voteForNameLbl, 0);
            this.Controls.SetChildIndex(this.rjButton2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel cardsPanel;
        private System.Windows.Forms.Label voteForNameLbl;
        private CustomControls.RJControls.RJButton rjButton2;
    }
}
