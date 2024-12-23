using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpyGamev1._0Csharp
{
    public partial class MainMenu : SpyGamev1._0Csharp.background
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            // Clear the GamedData
            GameData.Clear();
            // Go to AddPlayers Form
            AddPlayersForm nwForm = new AddPlayersForm();
            this.Hide();
            nwForm.ShowDialog();
        }

        private void howToPlayBtn_Click(object sender, EventArgs e)
        {
            // Go to ScoreBoard Form
            HowToPlayForm nwForm = new HowToPlayForm();
            this.Hide();
            nwForm.ShowDialog();

        }

        private void lastScoreBoardBtn_Click(object sender, EventArgs e)
        {

            if (GameData.Players.Count < 2)
                MessageBox.Show("No ScoreBoard Found.");
            else {
                // Go to LastScoreBoard Form
                ScoreBoard nwForm = new ScoreBoard();
                this.Hide();
                nwForm.ShowDialog();
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            if (GameData.Players.Count < 2)
                MessageBox.Show("No Game To Complete Please Press \"Play New Game\" to Start.");
            else {
                KnowYourStateForm nwForm = new KnowYourStateForm();
                this.Hide();
                nwForm.ShowDialog();
            } 

        }
    }
}
