using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpyGamev1._0Csharp
{
    public partial class AskForm : SpyGamev1._0Csharp.background
    {
        private int currentTurn = 0;

        public AskForm()
        {
            InitializeComponent();
            mainAskUserCtrl.Visible = false;
            //nextBtn.Text = "Start";
            //GameData.PreparePlyaersList();
        }

        private void mainAskUserCtrl_Load(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            if (currentTurn == GameData.Players.Count) {
                // Go to the next form
                VoteForm nwForm = new VoteForm();
                this.Hide();
                nwForm.ShowDialog();
                return;
            }
            mainAskUserCtrl.Visible=true;
            Player p1 = GameData.Players[GameData.asker[currentTurn]];
            Player p2 = GameData.Players[GameData.answerer[currentTurn]];
            mainAskUserCtrl.setPlayer1(p1.Name, p1.Avatar);
            mainAskUserCtrl.setPlayer2(p2.Name, p2.Avatar);
            currentTurn++;
            if (currentTurn == GameData.Players.Count)
            {
                nextBtn.Text = "End Game";
            }
        }
    }
}
