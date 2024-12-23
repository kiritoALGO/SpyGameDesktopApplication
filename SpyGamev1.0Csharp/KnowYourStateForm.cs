using SpyGamev1._0Csharp.RJ_Controls;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpyGamev1._0Csharp
{
    public partial class KnowYourStateForm : SpyGamev1._0Csharp.background
    {
        private int SpinOrNext = 0;
        private int CurrnetPlayerIndex = 0;
        public KnowYourStateForm()
        {
            InitializeComponent();


            // For Test Only
            GameData.PreparePlyaersList();


            mainUserControl.UpdateCard(
                GameData.Players[CurrnetPlayerIndex].Name,
                GameData.Players[CurrnetPlayerIndex].Avatar
            );
            nextBtn.Text = "Spin";
        }

        private void SpinCard(Action onSpinComplete)
        {
            // Example: Fade out, wait, update, then fade in
            mainUserControl.Visible = false;

            // Simulate a delay for spinning (e.g., via Timer or Task.Delay)
            Task.Delay(500).ContinueWith(_ =>
            {
                this.Invoke(new Action(() =>
                {
                    onSpinComplete?.Invoke();
                    mainUserControl.Visible = true;
                }));
            });
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (CurrnetPlayerIndex == GameData.Players.Count)
            {
                // Go to next page
                AskForm nwForm = new AskForm();
                this.Hide();
                nwForm.ShowDialog();
            }
            else if (SpinOrNext == 0)
            {
                // Spin the card and transition to UserControl3
                SpinCard(() =>
                {
                    // Assuming UserControl3 has a method to update content "WORD"
                    if(CurrnetPlayerIndex == GameData.SpyIndex){
                        mainUserControl.UpdateCard("Spy", GameData.Players[CurrnetPlayerIndex].Avatar);
                        //mainUserControl.WordLabel = "SPY";
                        mainUserControl.setWordColor(Color.Red);
                    }
                    else{
                        mainUserControl.UpdateCard(GameData.ChoosenWord, GameData.Players[CurrnetPlayerIndex].Avatar);
                        //mainUserControl.WordLabel = GameData.ChoosenWord;
                        mainUserControl.setWordColor(Color.LawnGreen);
                    }
                    mainUserControl.showTheSecretWord(true);
                });
                SpinOrNext = 1;
                nextBtn.Text = "Next Player";
                
            }
            else
            {
                // Move to the next player
                CurrnetPlayerIndex++;
                if (CurrnetPlayerIndex == GameData.Players.Count)
                {
                    nextBtn.Text = "Let's Start"; mainUserControl.Visible = false;
                    return;
                }
                SpinCard(() =>
                {
                    //MessageBox.Show($"{CurrnetPlayerIndex} -- {GameData.Players.Count}");
                    mainUserControl.UpdateCard(
                        GameData.Players[CurrnetPlayerIndex].Name,
                        GameData.Players[CurrnetPlayerIndex].Avatar
                    );
                    mainUserControl.showTheSecretWord(false);
                });
                SpinOrNext = 0;
                nextBtn.Text = "Spin";
            }
        }

        private void mainUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
