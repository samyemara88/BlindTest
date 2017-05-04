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
    public partial class frmIdentification : Form
    {
        public frmIdentification()
        {
            InitializeComponent();
        }

        private void frmIdentification_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Authentification_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            Class1 c = new
 Class1();

            c.s = "SELECT  count(*)  FROM   [dbo].[Table]  WHERE pseudo = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "' ";
            SqlCommand cmd = new SqlCommand(c.s, c.cnx);
            c.cnx.Open();
            int a = (Int32)cmd.ExecuteScalar() ;

           

           
            

            if (a > 0)
            {


                MessageBox.Show("connetée");
                Singleton.Instance.Pseudo = textBox1.Text;
                c.bs = "SELECT  best_score  FROM   [dbo].[Table]  WHERE pseudo = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "' ";
                SqlCommand cmd2 = new SqlCommand(c.bs, c.cnx);
                SqlDataReader dr;
                dr = cmd2.ExecuteReader();
         
                while (dr.Read())
                {
                    Singleton.Instance.Score = Convert.ToInt32(dr["best_score"].ToString());
                }
                c.cnx.Close();
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
                choix vue_choix = new choix();
                vue_choix.Show();
            }
            else
            {

                MessageBox.Show("email eronée");
            }

           


        }
    }
}
