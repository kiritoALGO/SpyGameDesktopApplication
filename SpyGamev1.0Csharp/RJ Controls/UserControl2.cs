using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace SpyGamev1._0Csharp.RJ_Controls
{
    public partial class UserControl2 : UserControl
    {
        public string WordLabel
        {
            get => wordLabel.Text;
            set => wordLabel.Text = value;
            
        }
        public void setWordColor(Color c)
        {
            wordLabel.ForeColor = c;
            CenterLabel(wordLabel);
        }
        public string CardName
        {
            get => plyrNameLbl.Text;
            set => plyrNameLbl.Text = value;
        }

        // Property for Image
        public Image CardImage
        {
            get => plyrImg.BackgroundImage;
            set => plyrImg.BackgroundImage = value;
        }

        public UserControl2()
        {
            InitializeComponent();
            SetRoundedCorners();
            CenterLabel(label1);
            //{
                RJButton btn = this.plyrImg;
                btn.Location = new Point(
                (this.Width - btn.Width) / 2, // Center horizontally
                btn.Location.Y // Maintain current Y position
                );
            //}
            showTheSecretWord(false);
        }
        private void SetRoundedCorners()
        {
            int cornerRadius = 20; // Adjust corner radius as needed
            var path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(Width - cornerRadius, Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            CenterLabel(plyrNameLbl);
        }
        public void showTheSecretWord(bool isFace)
        {
            plyrImg.Visible = !isFace;
            plyrNameLbl.Visible = !isFace;
            label1.Visible = !isFace;
            wordLabel.Visible = isFace;
        }
        private void CenterLabel(Label lbl)
        {
            lbl.Location = new Point(
                (this.Width - lbl.Width) / 2, // Center horizontally
                lbl.Location.Y // Maintain current Y position
            );
        }

        // Method to update the card details
        public void UpdateCard(string newName, Image newImage)
        {
            CardName = newName;
            CardImage = newImage;
            // Optional: Refresh the UI to reflect changes immediately
            Refresh();
        }

        private void UserControl2_Resize(object sender, EventArgs e)
        {
            CenterLabel(plyrNameLbl);
            //CenterLabel(plyrNameLbl);
        }

        private void plyrImg_Click(object sender, EventArgs e)
        {

        }
    }
}
