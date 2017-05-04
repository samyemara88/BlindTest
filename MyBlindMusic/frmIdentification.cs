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
            int a = (Int32)cmd.ExecuteScalar(); ;


            if (a > 0)
            {
                MessageBox.Show("connetée");
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
