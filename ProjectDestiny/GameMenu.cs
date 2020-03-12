using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;
using ProjectDestiny;

namespace ProjectDestiny
{
   
    public partial class fmGameMenu : Form
    {
        static string GameVersion = "v.0.0.1e";
        public fmGameMenu()
        {
            InitializeComponent();
        }

        private void fmGameMenu_Load(object sender, EventArgs e)
        {
            initMusic();
            lblGameMenuVer.Text = GameVersion;
            
        }
        private void initMusic()
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

            wplayer.URL = @"C:\Users\Natha\source\repos\ProjectDestiny\ProjectDestiny\Data\Media\Music\Haywrye1.mp3";
            wplayer.controls.play();
        }

        private void btnMenuQuit_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Application closing....");
            Application.Exit();

        }

        private void btnMenuOptions_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            options.Show();

        }

        private void llblAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Console.WriteLine("Showing About Us Dialog");
            MessageBox.Show("Thankyou for downloading this software! We're working hard on trying to update this game as much as possible. For any suggestions please e-mail s3rvtech@gmail.com " +" /// - The S3RV Team", "Project Destiny - About Us");
        }

        private void btnMenuSP_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Loading SinglePlayer...");
            GameEngine engine = new GameEngine(InitializeComponent);
        }
    }
}   
