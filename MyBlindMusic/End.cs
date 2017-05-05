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
    public partial class End : Form
    {
        public End()
        {
            InitializeComponent();
        }

        private void End_Load(object sender, EventArgs e)
        {
            label1.Text = (Singleton.Instance.Actual_score ).ToString() + "  Points";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Score s = new Score();
            s.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPlay f = new frmPlay();
            f.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            choix c = new choix();
            c.Show();
            this.Close();
        }
    }
}
