using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpyGamev1._0Csharp
{
    public partial class WelcomeForm : SpyGamev1._0Csharp.background
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            //MainMenu nwForm = new MainMenu();
            MainMenu nwForm = new MainMenu();
            this.Hide();
            nwForm.ShowDialog();
            //MessageBox.Show("Heelo Word");
            //Close();
        }
    }
}
