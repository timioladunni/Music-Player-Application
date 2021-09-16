using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace music_player_app
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }

        // create global variables of string type Array to save the titles and name of the track and path of the track
        string[] path, files;

        private void button1_Click(object sender, EventArgs e)
        {
            // code to select songs
            OpenFileDialog ofd = new OpenFileDialog();
            //code to select multiple files
            ofd.Multiselect = true;
           if ( ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; // save the name of the track in files area
                path = ofd.FileNames; //save the path of the track in file name
                //Display the music tiles in listbox
                for (int i = 0; i < files.Length; i++)
                {
                    lbMusicPlayer.Items.Add(files[i]); //Display songs in listbox
                }
            }
        }

        private void lbMusicPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //write a code to play music
            axWindowsMediaPlayerMusic.URL = path[lbMusicPlayer.SelectedIndex];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
