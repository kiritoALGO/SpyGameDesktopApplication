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
    public partial class ScoreBoard : SpyGamev1._0Csharp.background
    {
        public ScoreBoard()
        {
            InitializeComponent();
            
            
            // Just For Test
            //GameData.PreparePlyaersList();



            AddCardsForPlayers();

        }

        private void AddCardsForPlayers()
        {
            List<Player> players = GameData.Players;
            // Clear any existing cards from the panel
            cardsPanel.Controls.Clear();

            const int cardsPerRow = 4; // Number of cards per row
            //int cardWidth = 271; // Set the width of each card
            //int cardHeight = 238; // Set the height of each card
            

            for (int i = 0; i < players.Count; i++)
            {
                Player currentPlayer = players[i];

                // Create a new instance of UserControl5 for the current player
                UserControl5 card = new UserControl5
                {
                    CardImage = currentPlayer.Avatar,
                    CardName = currentPlayer.Name,
                    CardScore = currentPlayer.Score.ToString(), // Example: Use actual score if available
                };
                // Calculate the position of the card
                int row = i / cardsPerRow; // Determine the row based on the index
                int column = i % cardsPerRow; // Determine the column based on the index

                // Set the location for the card inside the panel
                card.Location = new Point(column * (card.Size.Width + 1), row * (card.Size.Height + 1)); // Add spacing between cards

                //// Set the size of the card
                //card.Size = new Size(cardWidth, cardHeight);

                // Add the card to the panel
                card.CenterAllLabels();
                cardsPanel.Controls.Add(card);
                
            }
            cardsPanel.AutoScroll = true;
        }
        private void CenterLabel(Label lbl)
        {
            lbl.Location = new Point(
                (this.Width - lbl.Width) / 2, // Center horizontally
                lbl.Location.Y // Maintain current Y position
            );
        }

        private void ScoreBoard_Load(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            // Go to the Main Menu 
            MainMenu nwForm = new MainMenu();
            this.Hide();
            nwForm.ShowDialog();
        }
    }
}
