using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class Home : Form
    {
        // The current selected tab
        Label selected = null;
        // Holds a reference to the seleceted tabs controls
        List<UserControl> selectedControls = new List<UserControl>();
        // Holds a reference to the FooterSoundBar
        FooterSoundBar soundBar;

        public Home()
        {
            InitializeComponent();
            this.Controls.Add(navigationBar);
            Song.LocalLoadSongs();

            /*List<string> temp = new List<string>();
            temp.Add("Trippie Redd");
            Song test1 = new Song("Taking A Walk", temp, true, "Trippie Redd - Taking A Walk", Song.ImageType.jpg, "Trippie Redd - Taking A Walk", Song.AudioType.wav);

            temp = new List<string>();
            temp.Add("Bugzy Malone");
            Song test2 = new Song("Make or Break", temp, true, "Bugzy Malone - Make or Break", Song.ImageType.jpg, "Bugzy Malone - Make or Break", Song.AudioType.mp3);

            temp = new List<string>();
            temp.Add("Shoreline Mafia");
            Song test3 = new Song("Nun Major", temp, true, "Shoreline Mafia - Nun Major", Song.ImageType.jpg, "Shoreline Mafia - Nun Major", Song.AudioType.mp3);*/

            List<Song> tempQ = new List<Song>();
            tempQ.Add(Song.songList[0]);
            tempQ.Add(Song.songList[1]);
            tempQ.Add(Song.songList[2]);

            soundBar = new FooterSoundBar();
            soundBar.Location = new Point(0, this.Height - soundBar.Height);
            soundBar.BringToFront();
            this.Controls.Add(soundBar);
            soundBar.PlaySong(Song.songList[0]);
            soundBar.SetSongQueue(tempQ, 0);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // Set the selected tab to the home button by default
            SetSelectedTab(homeButton);
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Song.LocalSaveSongs();
            soundBar.CleanupSoundBar();
            soundBar.Dispose();
        }

        // On hover of navigation button
        private void OnHoverEnterNavigationButton(Label sender)
        {
            sender.ForeColor = Color.Cyan;
        }

        // On hover exit of navigation button
        private void OnHoverLeaveNavigationButton(Label sender)
        {
            if (selected != sender)
            {
                sender.ForeColor = Color.Gainsboro;
            }
        }

        // Sets or changes a selected tab to the new one
        private void SetSelectedTab(Label sender)
        {
            Label tempSelected = selected;
            if(selected != null)
            {
                DeSelectTab(selected);
            }

            selected = sender;
            selected.ForeColor = Color.Cyan;
        }

        // Deselects the tab by disposing selectedcontrols and resetting to default navigation button value 
        private void DeSelectTab(Label sender)
        {
            selected.ForeColor = Color.Gainsboro;

            foreach(UserControl c in selectedControls)
            {
                c.Dispose();
            }
            selectedControls = new List<UserControl>();

            selected = null;
        }


        // ----------------------------------------------------------------------------------------------------------------
        // ----------------------------------------------- HOVER ANIMATIONS -----------------------------------------------
        // ----------------------------------------------------------------------------------------------------------------

        private void searchButton_MouseLeave(object sender, EventArgs e)
        {
            OnHoverLeaveNavigationButton((Label)sender);
        }

        private void searchButton_MouseEnter(object sender, EventArgs e)
        {
            OnHoverEnterNavigationButton((Label)sender);
        }

        private void homeButton_MouseEnter(object sender, EventArgs e)
        {
            OnHoverEnterNavigationButton((Label)sender);
        }

        private void homeButton_MouseLeave(object sender, EventArgs e)
        {
            OnHoverLeaveNavigationButton((Label)sender);
        }

        private void createPlaylistButton_MouseEnter(object sender, EventArgs e)
        {
            OnHoverEnterNavigationButton((Label)sender);
        }

        private void createPlaylistButton_MouseLeave(object sender, EventArgs e)
        {
            OnHoverLeaveNavigationButton((Label)sender);
        }

        private void playlistOneButton_MouseEnter(object sender, EventArgs e)
        {
            OnHoverEnterNavigationButton((Label)sender);
        }

        private void playlistOneButton_MouseLeave(object sender, EventArgs e)
        {
            OnHoverLeaveNavigationButton((Label)sender);
        }

        private void playlistTwoButton_MouseEnter(object sender, EventArgs e)
        {
            OnHoverEnterNavigationButton((Label)sender);
        }

        private void playlistTwoButton_MouseLeave(object sender, EventArgs e)
        {
            OnHoverLeaveNavigationButton((Label)sender);
        }

        private void playlistThreeButton_MouseEnter(object sender, EventArgs e)
        {
            OnHoverEnterNavigationButton((Label)sender);
        }

        private void playlistThreeButton_MouseLeave(object sender, EventArgs e)
        {
            OnHoverLeaveNavigationButton((Label)sender);
        }

        private void myPlaylistsButton_MouseEnter(object sender, EventArgs e)
        {
            OnHoverEnterNavigationButton((Label)sender);
        }

        private void myPlaylistsButton_MouseLeave(object sender, EventArgs e)
        {
            OnHoverLeaveNavigationButton((Label)sender);
        }

        private void minimizeButton_MouseEnter(object sender, EventArgs e)
        {
            OnHoverEnterNavigationButton((Label)sender);
        }

        private void minimizeButton_MouseLeave(object sender, EventArgs e)
        {
            OnHoverLeaveNavigationButton((Label)sender);
        }

        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            OnHoverEnterNavigationButton((Label)sender);
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            OnHoverLeaveNavigationButton((Label)sender);
        }


        // ----------------------------------------------------------------------------------------------------------------
        // ------------------------------------------ NAVIGATION BUTTON ACTIONS -------------------------------------------
        // ----------------------------------------------------------------------------------------------------------------

        private void homeButton_Click(object sender, EventArgs e)
        {
            SetSelectedTab((Label)sender);
            // Create user controls and store in selectedControls list
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SetSelectedTab((Label)sender);
            // Create user controls and store in selectedControls list
        }

        private void createPlaylistButton_Click(object sender, EventArgs e)
        {
            SetSelectedTab((Label)sender);
            // Create user controls and store in selectedControls list
        }

        private void myPlaylistsButton_Click(object sender, EventArgs e)
        {
            SetSelectedTab((Label)sender);
            // Create user controls and store in selectedControls list
        }

        private void playlistOneButton_Click(object sender, EventArgs e)
        {
            SetSelectedTab((Label)sender);
            // Create user controls and store in selectedControls list
        }

        private void playlistTwoButton_Click(object sender, EventArgs e)
        {
            SetSelectedTab((Label)sender);
            // Create user controls and store in selectedControls list
        }

        private void playlistThreeButton_Click(object sender, EventArgs e)
        {
            SetSelectedTab((Label)sender);
            // Create user controls and store in selectedControls list
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
