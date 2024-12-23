namespace SpyGamev1._0Csharp
{
    partial class GuessWordForm
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
            this.spyGuessTheWordLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // spyGuessTheWordLbl
            // 
            this.spyGuessTheWordLbl.AutoSize = true;
            this.spyGuessTheWordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spyGuessTheWordLbl.Location = new System.Drawing.Point(431, 60);
            this.spyGuessTheWordLbl.Name = "spyGuessTheWordLbl";
            this.spyGuessTheWordLbl.Size = new System.Drawing.Size(349, 38);
            this.spyGuessTheWordLbl.TabIndex = 20;
            this.spyGuessTheWordLbl.Text = "Spy Guess The Word";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(462, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 553);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // GuessWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 696);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.spyGuessTheWordLbl);
            this.Name = "GuessWordForm";
            this.Controls.SetChildIndex(this.spyGuessTheWordLbl, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label spyGuessTheWordLbl;
        private System.Windows.Forms.Panel panel1;
    }
}
