using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio;

namespace Music_Player
{
    public partial class SearchSongItem : UserControl
    {
        public SearchSongItem()
        {
            InitializeComponent();
        }

        public void SetupItem(Song song)
        {
            songName.Text = song.name;
            songArtist.Text = song.artists[0];

            if (song.album != null) {
                songAlbum.Text = song.album;
            } else
            {
                songAlbum.Text = "Unknown";
            }

            // Get song time
            try
            {
                WaveStream mainOutputStream = null;
                if (song.audioType == Song.AudioType.mp3)
                {
                    mainOutputStream = new Mp3FileReader(AppDomain.CurrentDomain.BaseDirectory + @"Assets\" + song.audioFileName + "." + song.audioType.ToString());
                }
                else if (song.audioType == Song.AudioType.wav)
                {
                    mainOutputStream = new WaveFileReader(AppDomain.CurrentDomain.BaseDirectory + @"Assets\" + song.audioFileName + "." + song.audioType.ToString());
                }

                songTime.Text = mainOutputStream.TotalTime.ToString(@"mm\:ss")
            } catch
            {
                songTime.Text = "00:00";
            }
        }
    }
}
