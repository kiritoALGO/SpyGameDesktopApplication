namespace SpyGamev1._0Csharp
{
    partial class AddPlayersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPlayersForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.newPlayerTxtBox = new SpyGamev1._0Csharp.RJ_Controls.PlaceholderTextBox();
            this.chooseImgBtn = new CustomControls.RJControls.RJButton();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.cardsPanel = new System.Windows.Forms.Panel();
            this.nextPqageBtn = new CustomControls.RJControls.RJButton();
            this.chooseImgBtn2 = new CustomControls.RJControls.RJButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.newPlayerTxtBox);
            this.panel1.Controls.Add(this.chooseImgBtn);
            this.panel1.Controls.Add(this.chooseImgBtn2);
            this.panel1.Location = new System.Drawing.Point(92, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 63);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // newPlayerTxtBox
            // 
            this.newPlayerTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.newPlayerTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPlayerTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPlayerTxtBox.Location = new System.Drawing.Point(20, 22);
            this.newPlayerTxtBox.Name = "newPlayerTxtBox";
            this.newPlayerTxtBox.PlaceholderText = "Placeholder Text";
            this.newPlayerTxtBox.Size = new System.Drawing.Size(861, 19);
            this.newPlayerTxtBox.TabIndex = 1;
            this.newPlayerTxtBox.Text = "Enter Player Name ...";
            this.newPlayerTxtBox.TextChanged += new System.EventHandler(this.newPlayerTxtBox_TextChanged);
            this.newPlayerTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.newPlayerTxtBox_KeyDown);
            // 
            // chooseImgBtn
            // 
            this.chooseImgBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.chooseImgBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.chooseImgBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chooseImgBtn.BackgroundImage")));
            this.chooseImgBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chooseImgBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.chooseImgBtn.BorderRadius = 20;
            this.chooseImgBtn.BorderSize = 0;
            this.chooseImgBtn.FlatAppearance.BorderSize = 0;
            this.chooseImgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseImgBtn.ForeColor = System.Drawing.Color.White;
            this.chooseImgBtn.Location = new System.Drawing.Point(909, 4);
            this.chooseImgBtn.Margin = new System.Windows.Forms.Padding(4);
            this.chooseImgBtn.Name = "chooseImgBtn";
            this.chooseImgBtn.Size = new System.Drawing.Size(58, 58);
            this.chooseImgBtn.TabIndex = 0;
            this.chooseImgBtn.TextColor = System.Drawing.Color.White;
            this.chooseImgBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.chooseImgBtn.UseVisualStyleBackColor = false;
            this.chooseImgBtn.Click += new System.EventHandler(this.chooseImgBtn_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.Black;
            this.rjButton1.Location = new System.Drawing.Point(10, 10);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(4);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(65, 63);
            this.rjButton1.TabIndex = 3;
            this.rjButton1.Text = "+";
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // cardsPanel
            // 
            this.cardsPanel.Location = new System.Drawing.Point(57, 161);
            this.cardsPanel.Name = "cardsPanel";
            this.cardsPanel.Size = new System.Drawing.Size(1043, 454);
            this.cardsPanel.TabIndex = 17;
            // 
            // nextPqageBtn
            // 
            this.nextPqageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(85)))), ((int)(((byte)(143)))));
            this.nextPqageBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(85)))), ((int)(((byte)(143)))));
            this.nextPqageBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.nextPqageBtn.BorderRadius = 20;
            this.nextPqageBtn.BorderSize = 0;
            this.nextPqageBtn.FlatAppearance.BorderSize = 0;
            this.nextPqageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextPqageBtn.ForeColor = System.Drawing.Color.White;
            this.nextPqageBtn.Location = new System.Drawing.Point(517, 632);
            this.nextPqageBtn.Name = "nextPqageBtn";
            this.nextPqageBtn.Size = new System.Drawing.Size(150, 47);
            this.nextPqageBtn.TabIndex = 19;
            this.nextPqageBtn.Text = "Go To Next Page";
            this.nextPqageBtn.TextColor = System.Drawing.Color.White;
            this.nextPqageBtn.UseVisualStyleBackColor = false;
            this.nextPqageBtn.Click += new System.EventHandler(this.nextPqageBtn_Click);
            // 
            // chooseImgBtn2
            // 
            this.chooseImgBtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.chooseImgBtn2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.chooseImgBtn2.BackgroundImage = global::SpyGamev1._0Csharp.Properties.Resources.avatar2;
            this.chooseImgBtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chooseImgBtn2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.chooseImgBtn2.BorderRadius = 20;
            this.chooseImgBtn2.BorderSize = 0;
            this.chooseImgBtn2.FlatAppearance.BorderSize = 0;
            this.chooseImgBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseImgBtn2.ForeColor = System.Drawing.Color.White;
            this.chooseImgBtn2.Location = new System.Drawing.Point(909, 5);
            this.chooseImgBtn2.Margin = new System.Windows.Forms.Padding(4);
            this.chooseImgBtn2.Name = "chooseImgBtn2";
            this.chooseImgBtn2.Size = new System.Drawing.Size(58, 58);
            this.chooseImgBtn2.TabIndex = 2;
            this.chooseImgBtn2.TextColor = System.Drawing.Color.White;
            this.chooseImgBtn2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.chooseImgBtn2.UseVisualStyleBackColor = false;
            this.chooseImgBtn2.Click += new System.EventHandler(this.chooseImgBtn2_Click);
            // 
            // AddPlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1203, 700);
            this.Controls.Add(this.nextPqageBtn);
            this.Controls.Add(this.cardsPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.Name = "AddPlayersForm";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.cardsPanel, 0);
            this.Controls.SetChildIndex(this.nextPqageBtn, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton chooseImgBtn;
        private RJ_Controls.PlaceholderTextBox newPlayerTxtBox;
        private System.Windows.Forms.Panel cardsPanel;
        private CustomControls.RJControls.RJButton nextPqageBtn;
        private CustomControls.RJControls.RJButton chooseImgBtn2;
    }
}
