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
    public partial class VoteForm : SpyGamev1._0Csharp.background
    {
        private int currentIndex = 0;
        public VoteForm()
        {
            InitializeComponent();
            CenterLabel(label1);
            
            // Just For prepare Test
            //GameData.PreparePlyaersList();
            //GameData.SpyIndex = 2;


            //MessageBox.Show(GameData.Players.Count.ToString());
            createAllPlayerCards();
        }

        private void createAllPlayerCards()
        {
            cardsPanel.Controls.Clear();

            voteForNameLbl.Text = "Vote For " + GameData.Players[currentIndex].Name + "\n\n\n\n\n\ntest";
            CenterLabel(voteForNameLbl);
            for (int i = 0; i < GameData.Players.Count; i++)
            {
                if (i == currentIndex)
                    continue;

                const int cardsPerRow = 4;

                // Create New Player Add it to GamePlay
                Player currentPlayer = GameData.Players[i];
                // Create the card
                UserControl1 newCard = new UserControl1
                {
                    CardImage = currentPlayer.Avatar,
                    CardName = currentPlayer.Name,
                };
                // Subscribe to the button click event
                newCard.ButtonClicked += NewCard_ButtonClicked;

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
        }
        private void NewCard_ButtonClicked(object sender, EventArgs e)
        {
            if (sender is UserControl1 clickedCard){
                //currentIndex != GameData.SpyIndex &&
                //MessageBox.Show(GameData.Players[GameData.SpyIndex].Name + clickedCard.CardName);
                if (GameData.Players[GameData.SpyIndex].Name == clickedCard.CardName)
                {
                    GameData.Players[currentIndex ].Score += 100;
                }
                if (currentIndex == GameData.Players.Count - 1)
                {
                    // Transatoin Message to show the SPY
                    MessageBox.Show($"The Spy is {GameData.Players[GameData.SpyIndex].Name}");

                    // Go to next Page
                    GuessWordForm nwForm = new GuessWordForm();
                    this.Hide();
                    nwForm.ShowDialog();
                    return;
                }

                currentIndex++;
                createAllPlayerCards();
                
                //MessageBox.Show($"The Score of player {GameData.Players[currentIndex].Name} is {GameData.Players[currentIndex].Score}");
            }
        }



        private void cardsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VoteForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void CenterLabel(Label lbl)
        {
            lbl.Location = new Point(
                (this.Width - lbl.Width) / 2, // Center horizontally
                lbl.Location.Y // Maintain current Y position
            );
        }
    }
}
