using SpyGamev1._0Csharp.RJ_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpyGamev1._0Csharp
{
    public partial class AddPlayersForm : SpyGamev1._0Csharp.background
    {
        public AddPlayersForm()
        {
            InitializeComponent();
            chooseImgBtn.Visible = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            // Maximum number of players
            const int maxPlayers = 8;
            const int cardsPerRow = 4;

            // Check if maximum players limit is reached
            if (cardsPanel.Controls.Count >= maxPlayers)
            {
                MessageBox.Show($"Maximum number of players reached!");
                //MessageBox.Show($"Maximum number of players reached! ({GameData.Players.Count})");
                return;
            }

            // Create New Player Add it to GamePlay
            Player newPlayer = new Player
            {
                Name = newPlayerTxtBox.Text,
                Score = 0,
                Avatar = (chooseImgBtn.Visible ? chooseImgBtn.BackgroundImage : chooseImgBtn2.BackgroundImage),
            };
            //MessageBox.Show("Player Added Successfully");
            GameData.AddPlayer(newPlayer);

            // Create the card
            UserControl1 newCard = new UserControl1
            {
                CardImage = newPlayer.Avatar,
                CardName = newPlayer.Name,
                // Set card size (example size)
                //Size = new Size(100, 150) 
            };

            // Calculate position of the card
            int cardIndex = cardsPanel.Controls.Count; // Get the index of the new card
            int row = cardIndex / cardsPerRow; // Determine the row
            int column = cardIndex % cardsPerRow; // Determine the column

            int cardWidth = newCard.Width + 10; // Card width + spacing
            int cardHeight = newCard.Height + 10; // Card height + spacing

            // Set the card position
            newCard.Location = new Point(column * cardWidth, row * cardHeight);

            // Add the card to the panel
            cardsPanel.Controls.Add(newCard);

            //MessageBox.Show($"Card added: {newCard.CardName} at Row: {row}, Column: {column}");
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newPlayerTxtBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void newPlayerTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter){
                rjButton1_Click(sender, e);
            }
        }

        private void newPlayerTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nextPqageBtn_Click(object sender, EventArgs e)
        {
            // Check if there is less than 2 return and message error

            if (GameData.Players.Count < 2){
                MessageBox.Show("Error: You need at least 2 players to start the game.", "Insufficient Players", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            KnowYourStateForm nwForm = new KnowYourStateForm();
            this.Hide();
            nwForm.ShowDialog();
        }

        private void chooseImgBtn2_Click(object sender, EventArgs e)
        {
            chooseImgBtn2.Visible = false;
            chooseImgBtn.Visible = true;
        }

        private void chooseImgBtn_Click(object sender, EventArgs e)
        {
            chooseImgBtn2.Visible = true;
            chooseImgBtn.Visible = false;
        }
    }
}
