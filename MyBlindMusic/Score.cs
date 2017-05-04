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
    public partial class Score : Form
    {
        public Score()
        {
            InitializeComponent();
            
        }

        private void Score_Load(object sender, EventArgs e)
        {
            tbScore.Text = Singleton.Instance.Score.ToString() + " Points";
            tbBestScore.Text = Singleton.Instance.Max_score.ToString() + " Points";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbScore_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void tbBestScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
