using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace musicapp
{
    public partial class MusicPlayer : Form
    {
        public MusicPlayer()
        {
            InitializeComponent();
        }

        private void listsong_SelectedIndexChanged(object sender, EventArgs e)
        {
            //things to do when the music is being selected

            try
            {
                axWindowsMediaPlayer1.URL = paths[Songs.SelectedIndex]; 
            }
            catch(IndexOutOfRangeException)
            {
                MessageBox.Show("Selection Cannot be played");
            }
                    

                
                
            
            
            
        }
        string[] paths, files;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnselcetsong_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); ///click event to open up dialog box to select songs
            ofd.Multiselect = true;/// we will be able to select multiple songs at once
            //ofd.
            //if ()//{            
            if (ofd.ShowDialog() == DialogResult.OK)
            {   
                files = ofd.SafeFileNames;// Save the names of the track in files array
                paths = ofd.FileNames;//save the paths of the tracks in the path array
               Console.WriteLine($"{files.Length} and path length {paths.Length}, first data is {files[0]} and last data  ");  
               
            }
            //else if (files.Length > 0)//&& ofd.ShowDialog() == DialogResult.OK)
            //{
            //    OpenFileDialog val = new OpenFileDialog();
            //    val.Multiselect = true;
            //    files.Concat(val.SafeFileNames);// update the names of the track in files array
            //    paths.Concat(val.FileNames);// update the paths of the tracks in the path array
            //    Console.WriteLine($"{files.Length} and path length {paths.Length},  first data is {files[0]} and last data  {files[files.Length - 1]}");

            //}

            for (int i = 0; i < files.Length; i++)
            {
                Songs.Items.Add(files[i]); //Displays songs in list box
            }
        }

     //else if (files.Length > 0)
     //           {

     //                       //           }



private void btnClear_Click(object sender, EventArgs e)
        {
            //files = null;
            //paths = null;
            //string[] Message = { "Please Select Musics" };
            try
            {
                if(axWindowsMediaPlayer1.URL == null)
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        Songs.Items.Remove(files[i]);
                    }
                }
                else if(axWindowsMediaPlayer1.URL != null)
                {
                    axWindowsMediaPlayer1.ResetText();
                    axWindowsMediaPlayer1.URL = null;
                    for (int i = 0; i < files.Length; i++)
                    {
                        Songs.Items.Remove(files[i]);
                    }
                }

            }
            catch(NullReferenceException)
            {
                MessageBox.Show("You Cannot Clear the Playlist if it is empty");
                    
            }

        }

        private void axWindowsMediaPlayer1_CurrentPlaylistItemAvailable(object sender, AxWMPLib._WMPOCXEvents_CurrentPlaylistItemAvailableEvent e)
        {
            axWindowsMediaPlayer1.URL =paths[Songs.SelectedIndex];
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.TabStop = true;
            axWindowsMediaPlayer1.Select();
            axWindowsMediaPlayer1.Show();
           // var Val = AxHost.ModifierKeys;
            // axWindowsMediaPlayer1.SelectNextControl(axWindowsMediaPlayer1, true, true,false,true);

        }
    }
}
