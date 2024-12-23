using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpyGamev1._0Csharp.RJ_Controls
{
    public partial class UserControl1 : UserControl
    {
        public event EventHandler ButtonClicked;

        public UserControl1()
        {
            InitializeComponent();
        }

        private void plyrImg_Click(object sender, EventArgs e)
        {
            // Trigger the custom event
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        // Property for Title
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

        private void plyrNameLbl_Click(object sender, EventArgs e)
        {

        }

        private void plyrNameLbl_Resize(object sender, EventArgs e)
        {

        }
        public void UpdateCard(string newName, Image newImage)
        {
            CardName = newName;
            CardImage = newImage;
            CenterLabel(plyrNameLbl);
            // Optional: Refresh the UI to reflect changes immediately
            //Refresh();
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            CenterLabel(plyrNameLbl);
        }

        // Method to center the label horizontally
        private void CenterLabel(Label lbl)
        {
            lbl.Location = new Point(
                (this.Width - lbl.Width) / 2, // Center horizontally
                lbl.Location.Y // Maintain current Y position
            );
        }

        private void UserControl1_Resize(object sender, EventArgs e)
        {
            CenterLabel(plyrNameLbl);
        }
    }
}
