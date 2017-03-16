using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace mp3player
{
    
    public partial class Form1 : Form
    {
        int i = 0;long j=0;
        public Form1()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            

            InitializeComponent();
            


        }




        private void Form1_Load(object sender, EventArgs e)
        {
            this.

            timer1.Start();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            pause.Visible = false;
            play.Visible = true;
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void play_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pause.Visible = true;
            string s;
            listBox1.SelectedIndex = listBox2.SelectedIndex;
            s = Convert.ToString(listBox1.SelectedItem);
            if (axWindowsMediaPlayer1.URL == "" || axWindowsMediaPlayer1.URL!=s)
                axWindowsMediaPlayer1.URL = s;
            else
                axWindowsMediaPlayer1.Ctlcontrols.play();
            
            play.Visible = false;
            trackBar1.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                    }

        private void quit_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                listBox1.Visible = false;
                listBox2.Visible = false;
                option.Visible = false;
                
                min.Visible = false;
                playlist.Visible = false;
                i++;
            }
            else
            {
                listBox1.Visible = true;
                listBox2.Visible = true;
                option.Visible = true;
                exit.Visible = true;
                min.Visible = true;
                playlist.Visible = true;
                i = 0;
            }
        }


        private void exit_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void min_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "";
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            trackBar1.Value = 0;
            trackBar1.Maximum = 1;
        }

        private void playlist_Click(object sender, EventArgs e)
        { 
            ofd.Multiselect = true;
            ofd.Filter = " (*.mp3) |*.mp3| AllFiles (*.*) |*.*";
            ofd.ShowDialog();
            foreach (string dir in ofd.FileNames)
            {
                listBox1.Items.Add(dir);
                
            }
            foreach (string track in ofd.SafeFileNames)
            {
                listBox2.Items.Add(track);
            }
            
                                
        }
        

        private void next_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex + 1;


                listBox2.SelectedIndex = listBox1.SelectedIndex;
                axWindowsMediaPlayer1.URL = Convert.ToString(listBox1.SelectedItem);
            }
            catch (Exception ex)
            {
                pause.Visible = false;
                play.Visible = true;

            }
        }

        private void prev_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
            listBox2.SelectedIndex = listBox1.SelectedIndex;
            
            axWindowsMediaPlayer1.URL = Convert.ToString(listBox1.SelectedItem);
        }

        private void mc(object sender, MouseEventArgs e)
        {
            play_Click(sender,e);
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            { next_Click(sender, e);
            }
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {

                trackBar1.Maximum = (int)axWindowsMediaPlayer1.currentMedia.duration + 1;
                trackBar1.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;

            }
            label1.Text = Convert.ToString(trackBar1.Value/60)+" : "+Convert.ToString(trackBar1.Value%60);
            label2.Text = Convert.ToString(trackBar1.Maximum % 60-1) + " : " + Convert.ToString(trackBar1.Maximum/60);

            j++;
        }
            

        
        
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = trackBar1.Value;
        }
        
        
        
    }
}
