using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpyGamev1._0Csharp
{
    public partial class HowToPlayForm : SpyGamev1._0Csharp.background
    {
        public HowToPlayForm()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            // Go to main menu
            MainMenu nwForm = new MainMenu();
            this.Hide();
            nwForm.ShowDialog();
        }
    }
}
