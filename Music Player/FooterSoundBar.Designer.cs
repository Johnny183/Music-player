namespace Music_Player
{
    partial class FooterSoundBar
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.currentSongPanel = new System.Windows.Forms.Panel();
            this.songName = new System.Windows.Forms.Label();
            this.songArtists = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.songProgressBar = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.songTotalTime = new System.Windows.Forms.Label();
            this.songCurrentTime = new System.Windows.Forms.Label();
            this.SongTimer = new System.Windows.Forms.Timer(this.components);
            this.volumeSlider = new System.Windows.Forms.TrackBar();
            this.volumeImage = new System.Windows.Forms.PictureBox();
            this.shuffleSelected = new System.Windows.Forms.PictureBox();
            this.songReplay = new System.Windows.Forms.PictureBox();
            this.songShuffle = new System.Windows.Forms.PictureBox();
            this.songNextButton = new System.Windows.Forms.PictureBox();
            this.songPreviousButton = new System.Windows.Forms.PictureBox();
            this.songControlButton = new System.Windows.Forms.PictureBox();
            this.songPicture = new System.Windows.Forms.PictureBox();
            this.loopSelected = new System.Windows.Forms.PictureBox();
            this.currentSongPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shuffleSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songReplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songShuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songNextButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songPreviousButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songControlButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loopSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // currentSongPanel
            // 
            this.currentSongPanel.Controls.Add(this.songName);
            this.currentSongPanel.Controls.Add(this.songArtists);
            this.currentSongPanel.Controls.Add(this.label9);
            this.currentSongPanel.Controls.Add(this.songPicture);
            this.currentSongPanel.Location = new System.Drawing.Point(3, 4);
            this.currentSongPanel.Name = "currentSongPanel";
            this.currentSongPanel.Size = new System.Drawing.Size(237, 98);
            this.currentSongPanel.TabIndex = 15;
            // 
            // songName
            // 
            this.songName.AutoSize = true;
            this.songName.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.songName.Location = new System.Drawing.Point(79, 42);
            this.songName.Name = "songName";
            this.songName.Size = new System.Drawing.Size(84, 20);
            this.songName.TabIndex = 12;
            this.songName.Text = "Song Name";
            // 
            // songArtists
            // 
            this.songArtists.AutoSize = true;
            this.songArtists.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songArtists.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.songArtists.Location = new System.Drawing.Point(80, 62);
            this.songArtists.Name = "songArtists";
            this.songArtists.Size = new System.Drawing.Size(72, 18);
            this.songArtists.TabIndex = 13;
            this.songArtists.Text = "Song Artists";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(5, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 24);
            this.label9.TabIndex = 10;
            this.label9.Text = "Currently Playing";
            // 
            // songProgressBar
            // 
            this.songProgressBar.Location = new System.Drawing.Point(39, 62);
            this.songProgressBar.Maximum = 1000;
            this.songProgressBar.Name = "songProgressBar";
            this.songProgressBar.Size = new System.Drawing.Size(318, 10);
            this.songProgressBar.Step = 100;
            this.songProgressBar.TabIndex = 19;
            this.songProgressBar.Value = 100;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loopSelected);
            this.panel1.Controls.Add(this.shuffleSelected);
            this.panel1.Controls.Add(this.songReplay);
            this.panel1.Controls.Add(this.songShuffle);
            this.panel1.Controls.Add(this.songNextButton);
            this.panel1.Controls.Add(this.songPreviousButton);
            this.panel1.Controls.Add(this.songControlButton);
            this.panel1.Controls.Add(this.songTotalTime);
            this.panel1.Controls.Add(this.songCurrentTime);
            this.panel1.Controls.Add(this.songProgressBar);
            this.panel1.Location = new System.Drawing.Point(246, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 99);
            this.panel1.TabIndex = 20;
            // 
            // songTotalTime
            // 
            this.songTotalTime.AutoSize = true;
            this.songTotalTime.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songTotalTime.ForeColor = System.Drawing.SystemColors.Control;
            this.songTotalTime.Location = new System.Drawing.Point(355, 58);
            this.songTotalTime.Name = "songTotalTime";
            this.songTotalTime.Size = new System.Drawing.Size(34, 18);
            this.songTotalTime.TabIndex = 21;
            this.songTotalTime.Text = "2:50";
            // 
            // songCurrentTime
            // 
            this.songCurrentTime.AutoSize = true;
            this.songCurrentTime.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songCurrentTime.ForeColor = System.Drawing.SystemColors.Control;
            this.songCurrentTime.Location = new System.Drawing.Point(5, 58);
            this.songCurrentTime.Name = "songCurrentTime";
            this.songCurrentTime.Size = new System.Drawing.Size(34, 18);
            this.songCurrentTime.TabIndex = 20;
            this.songCurrentTime.Text = "1:56";
            // 
            // SongTimer
            // 
            this.SongTimer.Interval = 1000;
            this.SongTimer.Tick += new System.EventHandler(this.SongTimer_Tick);
            // 
            // volumeSlider
            // 
            this.volumeSlider.Location = new System.Drawing.Point(726, 57);
            this.volumeSlider.Maximum = 150;
            this.volumeSlider.Name = "volumeSlider";
            this.volumeSlider.Size = new System.Drawing.Size(104, 45);
            this.volumeSlider.TabIndex = 21;
            this.volumeSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volumeSlider.Value = 50;
            this.volumeSlider.Scroll += new System.EventHandler(this.volumeSlider_Scroll);
            // 
            // volumeImage
            // 
            this.volumeImage.Image = global::Music_Player.Properties.Resources.MediumVolume;
            this.volumeImage.Location = new System.Drawing.Point(758, 24);
            this.volumeImage.Name = "volumeImage";
            this.volumeImage.Size = new System.Drawing.Size(40, 30);
            this.volumeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.volumeImage.TabIndex = 29;
            this.volumeImage.TabStop = false;
            // 
            // shuffleSelected
            // 
            this.shuffleSelected.Image = global::Music_Player.Properties.Resources.SelectedDot;
            this.shuffleSelected.Location = new System.Drawing.Point(91, 50);
            this.shuffleSelected.Name = "shuffleSelected";
            this.shuffleSelected.Size = new System.Drawing.Size(12, 7);
            this.shuffleSelected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shuffleSelected.TabIndex = 29;
            this.shuffleSelected.TabStop = false;
            this.shuffleSelected.Visible = false;
            // 
            // songReplay
            // 
            this.songReplay.Image = global::Music_Player.Properties.Resources.Repeat;
            this.songReplay.Location = new System.Drawing.Point(276, 21);
            this.songReplay.Name = "songReplay";
            this.songReplay.Size = new System.Drawing.Size(40, 30);
            this.songReplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.songReplay.TabIndex = 28;
            this.songReplay.TabStop = false;
            this.songReplay.Click += new System.EventHandler(this.songReplay_Click);
            // 
            // songShuffle
            // 
            this.songShuffle.Image = global::Music_Player.Properties.Resources.Shuffle;
            this.songShuffle.Location = new System.Drawing.Point(77, 21);
            this.songShuffle.Name = "songShuffle";
            this.songShuffle.Size = new System.Drawing.Size(40, 30);
            this.songShuffle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.songShuffle.TabIndex = 27;
            this.songShuffle.TabStop = false;
            this.songShuffle.Click += new System.EventHandler(this.songShuffle_Click);
            // 
            // songNextButton
            // 
            this.songNextButton.Image = global::Music_Player.Properties.Resources.Forward;
            this.songNextButton.Location = new System.Drawing.Point(225, 16);
            this.songNextButton.Name = "songNextButton";
            this.songNextButton.Size = new System.Drawing.Size(45, 35);
            this.songNextButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.songNextButton.TabIndex = 26;
            this.songNextButton.TabStop = false;
            this.songNextButton.Click += new System.EventHandler(this.songNextButton_Click);
            // 
            // songPreviousButton
            // 
            this.songPreviousButton.Image = global::Music_Player.Properties.Resources.Back;
            this.songPreviousButton.Location = new System.Drawing.Point(123, 16);
            this.songPreviousButton.Name = "songPreviousButton";
            this.songPreviousButton.Size = new System.Drawing.Size(45, 35);
            this.songPreviousButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.songPreviousButton.TabIndex = 25;
            this.songPreviousButton.TabStop = false;
            this.songPreviousButton.Click += new System.EventHandler(this.songPreviousButton_Click);
            this.songPreviousButton.DoubleClick += new System.EventHandler(this.songPreviousButton_DoubleClick);
            // 
            // songControlButton
            // 
            this.songControlButton.Image = global::Music_Player.Properties.Resources.Play;
            this.songControlButton.Location = new System.Drawing.Point(174, 16);
            this.songControlButton.Name = "songControlButton";
            this.songControlButton.Size = new System.Drawing.Size(45, 35);
            this.songControlButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.songControlButton.TabIndex = 24;
            this.songControlButton.TabStop = false;
            this.songControlButton.Click += new System.EventHandler(this.songControlButton_Click);
            // 
            // songPicture
            // 
            this.songPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.songPicture.Location = new System.Drawing.Point(12, 31);
            this.songPicture.Name = "songPicture";
            this.songPicture.Size = new System.Drawing.Size(64, 60);
            this.songPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.songPicture.TabIndex = 11;
            this.songPicture.TabStop = false;
            // 
            // loopSelected
            // 
            this.loopSelected.Image = global::Music_Player.Properties.Resources.SelectedDot;
            this.loopSelected.Location = new System.Drawing.Point(290, 50);
            this.loopSelected.Name = "loopSelected";
            this.loopSelected.Size = new System.Drawing.Size(12, 7);
            this.loopSelected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loopSelected.TabIndex = 30;
            this.loopSelected.TabStop = false;
            this.loopSelected.Visible = false;
            // 
            // FooterSoundBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.Controls.Add(this.volumeImage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.currentSongPanel);
            this.Controls.Add(this.volumeSlider);
            this.Name = "FooterSoundBar";
            this.Size = new System.Drawing.Size(833, 105);
            this.currentSongPanel.ResumeLayout(false);
            this.currentSongPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shuffleSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songReplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songShuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songNextButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songPreviousButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songControlButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loopSelected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel currentSongPanel;
        private System.Windows.Forms.Label songName;
        private System.Windows.Forms.Label songArtists;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox songPicture;
        private System.Windows.Forms.ProgressBar songProgressBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label songTotalTime;
        private System.Windows.Forms.Label songCurrentTime;
        private System.Windows.Forms.Timer SongTimer;
        private System.Windows.Forms.TrackBar volumeSlider;
        private System.Windows.Forms.PictureBox songControlButton;
        private System.Windows.Forms.PictureBox songNextButton;
        private System.Windows.Forms.PictureBox songPreviousButton;
        private System.Windows.Forms.PictureBox songReplay;
        private System.Windows.Forms.PictureBox songShuffle;
        private System.Windows.Forms.PictureBox volumeImage;
        private System.Windows.Forms.PictureBox shuffleSelected;
        private System.Windows.Forms.PictureBox loopSelected;
    }
}
