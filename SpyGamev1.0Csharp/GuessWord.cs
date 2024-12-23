using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpyGamev1._0Csharp
{
    public partial class GuessWordForm : SpyGamev1._0Csharp.background
    {
        public GuessWordForm()
        {
            InitializeComponent();
            AddVoteButtonsToPanel();

            //Fot Test onLY
            //GameData.PreparePlyaersList();


        }

        private void AddVoteButtonsToPanel()
        {
            // Clear any existing controls in the panel
            panel1.Controls.Clear();

            // Define button properties
            int buttonWidth = 100;
            int buttonHeight = 50;
            int spacing = 10; // Space between buttons

            // Starting coordinates within the panel
            int startX = 10; // Adjust as needed (relative to the panel)
            int startY = 10; // Adjust as needed (relative to the panel)

            // Create and position buttons
            for (int i = 0; i < 8; i++)
            {
                RJButton voteButton = new RJButton
                {
                    BackColor = Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(85)))), ((int)(((byte)(143))))),
                    BackgroundColor = Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(85)))), ((int)(((byte)(143))))),
                    BorderColor = Color.PaleVioletRed,
                    BorderRadius = 20,
                    BorderSize = 0,
                    FlatAppearance = { BorderSize = 0 },
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    ForeColor = Color.White,
                    Name = "rjButton2",
                    Size = new Size(panel1.Size.Width-10, 48),
                    Location = new Point(0 , 0),
                    TabIndex = 0,
                    Text = GameData.words[i],
                    TextColor = System.Drawing.Color.White,
                    UseVisualStyleBackColor = false
                };
                voteButton.Location = new Point(
                    (panel1.Width - voteButton.Width) / 2, // Center horizontally
                    (i*(voteButton.Size.Height + 5)+10) // Maintain current Y position
                );

                // Attach click event handler
                voteButton.Click += VoteButton_Click;

                // Add the button to the panel
                panel1.Controls.Add(voteButton);
            }
        }

        // Event handler for button clicks
        private void VoteButton_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                if (clickedButton.Text == GameData.ChoosenWord){
                    GameData.Players[GameData.SpyIndex].Score += 100;
                    MessageBox.Show($"Excellent The Word Is Correct");
                }else{
                    MessageBox.Show($"Your Choosen Is WRONG, The right asnwer is\n${GameData.ChoosenWord}");
                }
            }
            // go to the next Page
            ScoreBoard nwForm = new ScoreBoard();
            this.Hide();
            nwForm.ShowDialog();
        }



        private void rjButton5_Click(object sender, EventArgs e)
        {

        }

        private void rjButton4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
