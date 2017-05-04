using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using WMPLib;

namespace MyBlindMusic
{
    public partial class frmPlay : Form
    {
        

        List<Music> listMusics = new List<Music>();


        public frmPlay() 
        {
            InitializeComponent();
            //récupérer tous les fichiers de dossier music
            string[] fileEntries = Directory.GetFiles(@"C:\Music\", "*.*", SearchOption.AllDirectories);
            foreach (string fileName in fileEntries)
            {
                listMusics.Add(new Music(fileName));
                
            }

           
             

            int nb = listMusics.Count;
          //MessageBox.Show(nb.ToString());
           // MessageBox.Show("toto");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chargeMusique();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayFile(@"C:\Music\Scorpions.mp3");

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

        private void chargeMusique()
        {


            Random rnd = new Random();
                List<Music> m2 = new List<Music>();
               // m2.Clear();
               // m2.Add(m);
                int a = rnd.Next(0,listMusics.Count-1);

                int b = rnd.Next(0,listMusics.Count-1);
                int c = rnd.Next(0,listMusics.Count-1);
                int d = rnd.Next(0, listMusics.Count - 1);
                m2.Add(listMusics[a]);
                m2.Add(listMusics[b]);
                m2.Add(listMusics[c]);
                m2.Add(listMusics[d]);
                // mélanger la liste 
                m2.Remove(listMusics[a]);
                m2.Add(listMusics[a]);
                foreach ( Music MBtn in m2)
                {
                    Button btn = new Button();
                    
                    btn.Text = clean(MBtn.FileName);
                    flowLayout4Btn.Controls.Add(btn);
                    btn.Click += new EventHandler(this.MyEvent);
                }
            
            


        }

        private void MyEvent(object sender, EventArgs e)
        {

            throw new NotImplementedException();

        }
         private string  clean(String URL)
        {
            string[] exploded = URL.Split('\\');
            int size = exploded.Length;
            string song_name = exploded[size - 1];

            int taille_url =  Int32.Parse(URL.Length.ToString());
            
            string sub = URL.Substring(0, 10);
           // MessageBox.Show(sub.ToString());
            return song_name;
            
        }
    }

}
