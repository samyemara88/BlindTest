using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
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
            Class1 c = new Class1();
            c.cnx.Open();
            c.max = "SELECT  MAX(best_score) as max_best_score   FROM [dbo].[Table] ";
            SqlCommand cmd3 = new SqlCommand(c.max, c.cnx);
            SqlDataReader dr_max;
            dr_max = cmd3.ExecuteReader();
            while (dr_max.Read())
            {
                Singleton.Instance.Max_score = Convert.ToInt32(dr_max["max_best_score"].ToString());
            }

            c.cnx.Close();
            c.cnx.Open();
            c.bs = "SELECT  best_score  FROM   [dbo].[Table]  WHERE pseudo = '" + Singleton.Instance.Pseudo + "'  ";
            SqlCommand cmd2 = new SqlCommand(c.bs, c.cnx);
            SqlDataReader dr;
            dr = cmd2.ExecuteReader();

            while (dr.Read())
            {
                Singleton.Instance.Score = Convert.ToInt32(dr["best_score"].ToString());
            }


            c.cnx.Close();
            labelScore.Text = (Singleton.Instance.Score).ToString() + " Points";
            labeltbBestScore.Text = (Singleton.Instance.Max_score ).ToString() + " Points";
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

        private void Back_Click(object sender, EventArgs e)
        {
            choix choix = new choix();
            choix.Show();
            this.Close();
        }
    }
}
