using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpyGamev1._0Csharp.RJ_Controls
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }
        
        public void setPlayer1(string name, Image img)
        {
            askerPlayer.UpdateCard(name, img);
        }
        public void setPlayer2(string name, Image img)
        {
            answererPlayer.UpdateCard(name, img);
        }

        private void CenterLabel(Label lbl)
        {
            lbl.Location = new Point(
                (this.Width - lbl.Width) / 2, // Center horizontally
                lbl.Location.Y // Maintain current Y position
            );
        }


        private void UserControl3_Load(object sender, EventArgs e)
        {

        }
    }
}
