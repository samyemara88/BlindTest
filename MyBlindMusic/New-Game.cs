using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using WMPLib;
using System.Data.SqlClient;

namespace MyBlindMusic
{
    public partial class frmPlay : Form
    {

        List<Music> listMusics = new List<Music>();


        public frmPlay()
        {
            InitializeComponent();
            //récupérer tous les fichiers de dossier music
            string[] fileEntries = Directory.GetFiles(@"C:\Music\", "*.mp3*", SearchOption.AllDirectories);


            foreach (string fileName in fileEntries)
            {
                listMusics.Add(new Music(fileName));

            }




            int nb = listMusics.Count;
            // MessageBox.Show(nb.ToString());


        }




        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Questin n° 1 ";
            i += 1;
            chargeMusique();

            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // PlayFile(@"C:\Music\Scorpions.mp3");

        }


        WMPLib.WindowsMediaPlayer Player = new WMPLib.WindowsMediaPlayer();
        private string url;




        private void PlayFile(string url)
        {

            Player.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(Player_PlayStateChange);
            Player.MediaError += new WMPLib._WMPOCXEvents_MediaErrorEventHandler(Player_MediaError);
            Player.URL = url;
            Player.controls.play();
        }

        private void Player_MediaError(object pMediaObject)
        {
            throw new NotImplementedException();
        }



        private void Player_PlayStateChange(int NewState)
        {
            if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsStopped)
            {
                this.Close();
            }
        }


        private void Stop_Click(object sender, EventArgs e)
        {

            Player.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(Player_PlayStateChange);
            Player.MediaError += new WMPLib._WMPOCXEvents_MediaErrorEventHandler(Player_MediaError);
            Player.URL = url;
            Player.controls.stop();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void b_rep_Enter(object sender, EventArgs e)
        {
        }


        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            //flowLayout4Btn.Controls.Add(new Button());
        }

        private string m_goodAnswer;
        static int cmpt = 0;
        int i = 0;
        private void chargeMusique()
        {


            Random rnd = new Random();
            List<Music> m2 = new List<Music>();
            // m2.Clear();
            // m2.Add(m);
            //  m2.Add(listMusics[i]);

            int a = rnd.Next(0, listMusics.Count - 1);
            int b = rnd.Next(0, listMusics.Count - 1);
            int c = rnd.Next(0, listMusics.Count - 1);
            int d = rnd.Next(0, listMusics.Count - 1);

            m2.Add(listMusics[d]);
            m2.Add(listMusics[a]);
            m2.Add(listMusics[b]);
            m2.Add(listMusics[c]);


            // mélanger la liste 
            // m2.Remove(listMusics[a]);
            // m2.Add(listMusics[a]);
            // MessageBox.Show(listMusics[a].FileName);


            PlayFile(listMusics[a].FileName);

            m_goodAnswer = listMusics[a].FileName;//---------------------------------------------- musique passe



            flowLayout4Btn.Controls.Clear();
            foreach (Music MBtn in m2)
            {

                Button btn = new Button();
                btn.Text = clean(MBtn.FileName);
                flowLayout4Btn.Controls.Add(btn);
                btn.Width = 200;
                btn.Click += new EventHandler(this.MyEvent);

            }

        }

        private void MyEvent(object sender, EventArgs e)
        {
            
            Player.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(Player_PlayStateChange);
            Player.MediaError += new WMPLib._WMPOCXEvents_MediaErrorEventHandler(Player_MediaError);
            Player.URL = url;
            Player.controls.stop();

            if (clean(m_goodAnswer) == ((Button)sender).Text)
            {
              
                cmpt += 1;
                i += 1;

                // MessageBox.Show("Bonne réponse !!!!!");
                labelRep.Text = "Bonne réponse  " + cmpt;
                chargeMusique();

                label1.Text = "Questin n° " +  (i - 1 ) ;
            }
            else
            {
               
                labelRep.Text = " Mauvaise réponse  " + cmpt;
                // MessageBox.Show("Réponse fausse !!!!!");
                chargeMusique();
                i += 1;
                label1.Text = "Questin n° " + (i - 1);
            }

            if (i > 6)
            {
                Class1 c = new Class1();

               Singleton.Instance.Actual_score = Convert.ToInt32(cmpt * 10)  ;
                c.cnx.Open();
                c.maj = "UPDATE [dbo].[Table] SET best_score = best_score + '" + Singleton.Instance.Actual_score + "' WHERE pseudo = '" + Singleton.Instance.Pseudo + "' ";
                SqlCommand cmd4 = new SqlCommand(c.maj, c.cnx);
                cmd4.ExecuteNonQuery();


                Player.controls.stop();
                End n = new End();
                n.Show();
                this.Close();
            }


        }
        private string clean(String URL)
        {
            string[] exploded = URL.Split('\\');
            int size = exploded.Length;
            string song_name = exploded[size - 1];
            int taille_url = Int32.Parse(URL.Length.ToString());
            string sub = URL.Substring(0, 10);
            return song_name;

        }

        private void button1_Click_2(object sender, EventArgs e)
        {


            chargeMusique();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelRep_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int t = 41;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            this.progressBar1.Increment(2);
            if (t <= 5)
            {
                label2.ForeColor = System.Drawing.Color.Red; 
            }

            if (t == 1)
            {
                timer1.Stop();

                Class1 c = new Class1();

                Singleton.Instance.Actual_score = Convert.ToInt32(cmpt * 10);
                c.cnx.Open();
                c.maj = "UPDATE [dbo].[Table] SET best_score = best_score + '" + Singleton.Instance.Actual_score + "' WHERE pseudo = '" + Singleton.Instance.Pseudo + "' ";
                SqlCommand cmd4 = new SqlCommand(c.maj, c.cnx);
                cmd4.ExecuteNonQuery();


                Player.controls.stop();
                End n = new End();
                n.Show();
                this.Close();
            }

            label2.Text = "";
            t--;
            label2.Text += t.ToString();

        }
    }

}