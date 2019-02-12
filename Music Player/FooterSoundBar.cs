using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using NAudio.Wave;
using NAudio;

namespace Music_Player
{
    public partial class FooterSoundBar : UserControl
    {
        // Song realted variables
        public Song currentSong = null;
        public TimeSpan songTime;
        public WaveOutEvent currentSP;
        private WaveStream mainOutputStream = null;
        private WaveChannel32 volumeStream = null;

        // Queue related variables
        public List<Song> songQueue = new List<Song>();
        public int songQueuePos = 0;

        // Additional variables
        public bool shuffle = false;
        public bool loop = false;
        public ControlButtonState cbtnState = ControlButtonState.Play;
        public enum ControlButtonState { Play, Stop }

        // Running path location
        private string RunningPath = AppDomain.CurrentDomain.BaseDirectory;

        public FooterSoundBar()
        {
            InitializeComponent();
            currentSP = new WaveOutEvent();
            volumeSlider.Value = 50;
        }

        // Sets a new song queue with position
        public void SetSongQueue(List<Song> _songQueue, int _queuePos)
        {
            songQueue = _songQueue;
            songQueuePos = _queuePos;
        }

        // Disposes song resources
        private void SongEnded()
        {
            if (mainOutputStream != null)
            {
                mainOutputStream.Dispose();
                mainOutputStream = null;
                volumeStream.Dispose();
                volumeStream = null;

                SongTimer.Enabled = false;
                ChangeControlButtonState(ControlButtonState.Play);
            }
        }

        // Resets the current song
        public void ResetCurrentSong()
        {
            mainOutputStream.Position = 0;
            songTime = new TimeSpan(0, 0, 0, 0, 0);
            songCurrentTime.Text = songTime.ToString(@"mm\:ss");
        }

        // Gets a random song from the queue
        public Song GetRandomSong(Song avoidSong = null)
        {
            Song newSong = null;
            while (true)
            {
                Random rand = new Random();
                int newPos = rand.Next(0, songQueue.Count);

                if (avoidSong != null)
                {
                    if (songQueue[newPos] != avoidSong)
                    {
                        newSong = songQueue[newPos];
                        break;
                    }
                } else
                {
                    newSong = songQueue[newPos];
                    break;
                }
            }
            return newSong;
        }

        // Plays a songs
        public void PlaySong(Song song)
        {
            try
            {
                // If the playbackstate is playing, release song resources and stop the current WaveOutEvent
                if (currentSP.PlaybackState == PlaybackState.Playing || currentSP.PlaybackState == PlaybackState.Paused)
                {
                    SongEnded();
                    currentSP.Stop();
                }

                // Create new audio stream for different audio types
                if (song.audioType == Song.AudioType.mp3)
                {
                    mainOutputStream = new Mp3FileReader(AppDomain.CurrentDomain.BaseDirectory + @"Assets\" + song.audioFileName + "." + song.audioType.ToString());
                    volumeStream = new WaveChannel32(mainOutputStream);
                } else if(song.audioType == Song.AudioType.wav)
                {
                    mainOutputStream = new WaveFileReader(AppDomain.CurrentDomain.BaseDirectory + @"Assets\" + song.audioFileName + "." + song.audioType.ToString());
                    volumeStream = new WaveChannel32(mainOutputStream);
                }

                // Sets the current song
                currentSong = song;

                // Initializes and plays the new volume Stream
                currentSP.Init(volumeStream);
                currentSP.Play();

                // Sets up the song UI
                SetupSongUI(song, mainOutputStream.TotalTime);
            } catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        // Handles setting up all the song UI
        private void SetupSongUI(Song song, TimeSpan maximum)
        {
            // Sets the left side of the bar song information
            if(songPicture.Image != null)
            {
                songPicture.Image.Dispose();
            }

            songPicture.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"Assets\" + song.imageFileName + "." + song.imageType.ToString());
            songName.Text = song.name;
            songArtists.Text = "";
            for(int i = 0; i < song.artists.Count; i++)
            {
                if(i >= song.artists.Count-1)
                {
                    songArtists.Text += song.artists[i];
                } else {
                    songArtists.Text += song.artists[i] + ", ";
                }
            }

            // Sets up the main information bar in the middle
            songTime = new TimeSpan(0, 0, 0, 0, 0);
            songCurrentTime.Text = songTime.ToString(@"mm\:ss");
            songProgressBar.Value = songProgressBar.Minimum;
            songProgressBar.Step = Convert.ToInt32(maximum.TotalSeconds);
            songProgressBar.Maximum = Convert.ToInt32(maximum.TotalSeconds);
            songTotalTime.Text = maximum.ToString(@"mm\:ss");

            // Enables the song timer and changes the control button state
            ChangeControlButtonState(ControlButtonState.Stop);
            SongTimer.Enabled = true;
        }

        // Changes to the control button state to the one passed
        private void ChangeControlButtonState(ControlButtonState newState)
        {
            if (newState == ControlButtonState.Play)
            {
                songControlButton.Text = "Play";
                cbtnState = ControlButtonState.Play;
                songControlButton.Image = Properties.Resources.Play;
            }
            else
            {
                songControlButton.Text = "Stop";
                cbtnState = ControlButtonState.Stop;
                songControlButton.Image = Properties.Resources.Pause;
            }
        }

        // A loop called every 1000 ms for the Song Timer
        private void SongTimer_Tick(object sender, EventArgs e)
        {
            if (currentSP.PlaybackState == PlaybackState.Playing)
            {
                songTime = songTime.Add(new TimeSpan(0, 0, 1));
                songCurrentTime.Text = songTime.ToString(@"mm\:ss");

                try
                {
                    songProgressBar.Value = Convert.ToInt32(songTime.TotalSeconds);
                }
                catch
                {
                    songProgressBar.Value = songProgressBar.Maximum;
                }

                // When the song ends
                if(songTime.TotalSeconds > songProgressBar.Maximum)
                {
                    if (loop)
                    {
                        ResetCurrentSong();
                    } else if (shuffle)
                    {
                        Song randSong = GetRandomSong(currentSong);
                        PlaySong(randSong);
                        songQueuePos = songQueue.FindIndex(x => x.name == randSong.name);
                    }
                    else
                    {
                        try
                        {
                            if (songQueue[songQueuePos + 1] != null)
                            {
                                PlaySong(songQueue[songQueuePos + 1]);
                                songQueuePos++;
                            }
                        } catch
                        {
                            SongEnded();
                        }
                    }
                }
            }
        }

        // Cleanup sound bar resources
        public void CleanupSoundBar()
        {
            SongEnded();
            currentSP.Dispose();
        }

        // Pauses and plays the current song
        private void songControlButton_Click(object sender, EventArgs e)
        {
            if (currentSong != null)
            {
                if (cbtnState == ControlButtonState.Play)
                {
                    if(currentSP.PlaybackState == PlaybackState.Paused)
                    {
                        currentSP.Play();
                    } else if (currentSP.PlaybackState == PlaybackState.Stopped)
                    {
                        PlaySong(currentSong);
                    }

                    ChangeControlButtonState(ControlButtonState.Stop);
                    SongTimer.Enabled = true;
                }
                else
                {
                    currentSP.Pause();
                    ChangeControlButtonState(ControlButtonState.Play);
                    SongTimer.Enabled = false;
                }
            }
        }

        private void songReplay_Click(object sender, EventArgs e)
        {
            loop = !loop;
            if (loop)
            {
                loopSelected.Visible = true;
            }
            else
            {
                loopSelected.Visible = false;
            }
        }

        private void songShuffle_Click(object sender, EventArgs e)
        {
            shuffle = !shuffle;
            if (shuffle)
            {
                shuffleSelected.Visible = true;
            }
            else
            {
                shuffleSelected.Visible = false;
            }
        }

        private void volumeSlider_Scroll(object sender, EventArgs e)
        {
            currentSP.Volume = Utilities.Map(volumeSlider.Value, volumeSlider.Minimum, volumeSlider.Maximum, 0.0f, 1.0f);
            if(volumeSlider.Value <= 0)
            {
                volumeImage.Image = Properties.Resources.MuteVolume;
            } else if(volumeSlider.Value > 0 && volumeSlider.Value <= 55)
            {
                volumeImage.Image = Properties.Resources.LowVolume;
            } else if(volumeSlider.Value > 55 && volumeSlider.Value <= 110)
            {
                volumeImage.Image = Properties.Resources.MediumVolume;
            } else if (volumeSlider.Value > 110)
            {
                volumeImage.Image = Properties.Resources.HighVolume;
            }
        }

        private void songPreviousButton_Click(object sender, EventArgs e)
        {
            ResetCurrentSong();
        }

        private void songPreviousButton_DoubleClick(object sender, EventArgs e)
        {
            if (songQueuePos != 0)
            {
                PlaySong(songQueue[songQueuePos - 1]);
                songQueuePos--;
            }
        }

       private void songNextButton_Click(object sender, EventArgs e)
        {
            // If the shuffle button is selected
            if (shuffle)
            {
                Song randSong = GetRandomSong(currentSong);
                PlaySong(randSong);
                songQueuePos = songQueue.FindIndex(x => x.name == randSong.name);
            }
            else
            {
                try
                {
                    // Gets the next song in the queue
                    if (songQueue[songQueuePos + 1] != null)
                    {
                        PlaySong(songQueue[songQueuePos + 1]);
                        songQueuePos++;
                    }
                }
                catch
                {
                    // Returns to the start of the songQueue
                    songQueuePos = 0;
                    PlaySong(songQueue[songQueuePos]);
                }
            }
        }
    }
}
