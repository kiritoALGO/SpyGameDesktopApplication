namespace SpyGamev1._0Csharp
{
    partial class VoteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cardsPanel
            // 
            this.cardsPanel.Location = new System.Drawing.Point(78, 168);
            this.cardsPanel.Name = "cardsPanel";
            this.cardsPanel.Size = new System.Drawing.Size(1043, 454);
            this.cardsPanel.TabIndex = 18;
            this.cardsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.cardsPanel_Paint);
            // 
            // voteForNameLbl
            // 
            this.voteForNameLbl.AutoSize = true;
            this.voteForNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voteForNameLbl.Location = new System.Drawing.Point(365, 66);
            this.voteForNameLbl.Name = "voteForNameLbl";
            this.voteForNameLbl.Size = new System.Drawing.Size(443, 38);
            this.voteForNameLbl.TabIndex = 19;
            this.voteForNameLbl.Text = "Vote For Mohamed Mohsen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 248);
            this.label1.TabIndex = 20;
            this.label1.Text = "Who is The Spy ......!\r\n\r\n\r\n\r\n\r\n\r\n\r\nhello\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // VoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1205, 696);
            this.Controls.Add(this.cardsPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.voteForNameLbl);
            this.Name = "VoteForm";
            this.Load += new System.EventHandler(this.VoteForm_Load);
            this.Controls.SetChildIndex(this.voteForNameLbl, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cardsPanel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel cardsPanel;
        private System.Windows.Forms.Label voteForNameLbl;
        private System.Windows.Forms.Label label1;
    }
}
