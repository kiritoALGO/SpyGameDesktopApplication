using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpyGamev1._0Csharp.RJ_Controls
{
    public partial class UserControl5 : UserControl
    {
        public string CardScore
        {
            get => plyrScoreLbl.Text;
            set => plyrScoreLbl.Text = value;
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

        public UserControl5()
        {
            InitializeComponent();
            CenterLabel(plyrNameLbl);
            CenterLabel(plyrScoreLbl);
        }

        public void CenterAllLabels()
        {
            CenterLabel(plyrNameLbl);
            CenterLabel(plyrScoreLbl);
        }

        private void CenterLabel(Label lbl)
        {
            lbl.Location = new Point(
                (this.Width - lbl.Width) / 2, // Center horizontally
                lbl.Location.Y // Maintain current Y position
            );
        }

        private void UserControl5_Load(object sender, EventArgs e)
        {

        }
    }
}
