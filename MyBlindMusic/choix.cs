using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBlindMusic
{
    public partial class choix : Form
    {
        public choix()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Score vue_score = new Score();
            vue_score.Show();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            frmPlay vue_game = new frmPlay();
            vue_game.Show();
        }

        private void GameRules_Click(object sender, EventArgs e)
        {
            Game_Rules vue_rules = new Game_Rules();
            vue_rules.Show();
        }
    }
}
