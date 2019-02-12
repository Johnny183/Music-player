namespace Music_Player
{
    partial class Home
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.navigationBar = new System.Windows.Forms.Panel();
            this.playlistThreeButton = new System.Windows.Forms.Label();
            this.playlistTwoButton = new System.Windows.Forms.Label();
            this.playlistOneButton = new System.Windows.Forms.Label();
            this.myPlaylistsButton = new System.Windows.Forms.Label();
            this.createPlaylistButton = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.navigationBar.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 69);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Music_Player.Properties.Resources.icon;
            this.pictureBox1.Image = global::Music_Player.Properties.Resources.icon;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.exitButton.Location = new System.Drawing.Point(776, 36);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(43, 24);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.exitButton_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.exitButton_MouseLeave);
            // 
            // minimizeButton
            // 
            this.minimizeButton.AutoSize = true;
            this.minimizeButton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.minimizeButton.Location = new System.Drawing.Point(735, 12);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(84, 24);
            this.minimizeButton.TabIndex = 10;
            this.minimizeButton.Text = "Minimize";
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            this.minimizeButton.MouseEnter += new System.EventHandler(this.minimizeButton_MouseEnter);
            this.minimizeButton.MouseLeave += new System.EventHandler(this.minimizeButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(80, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simple Music Player";
            // 
            // navigationBar
            // 
            this.navigationBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.navigationBar.Controls.Add(this.playlistThreeButton);
            this.navigationBar.Controls.Add(this.playlistTwoButton);
            this.navigationBar.Controls.Add(this.playlistOneButton);
            this.navigationBar.Controls.Add(this.myPlaylistsButton);
            this.navigationBar.Controls.Add(this.createPlaylistButton);
            this.navigationBar.Controls.Add(this.homeButton);
            this.navigationBar.Controls.Add(this.searchButton);
            this.navigationBar.Location = new System.Drawing.Point(0, 58);
            this.navigationBar.Name = "navigationBar";
            this.navigationBar.Size = new System.Drawing.Size(141, 383);
            this.navigationBar.TabIndex = 30;
            // 
            // playlistThreeButton
            // 
            this.playlistThreeButton.AutoSize = true;
            this.playlistThreeButton.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlistThreeButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.playlistThreeButton.Location = new System.Drawing.Point(12, 258);
            this.playlistThreeButton.Name = "playlistThreeButton";
            this.playlistThreeButton.Size = new System.Drawing.Size(98, 20);
            this.playlistThreeButton.TabIndex = 8;
            this.playlistThreeButton.Text = "Playlist Three";
            this.playlistThreeButton.Visible = false;
            this.playlistThreeButton.Click += new System.EventHandler(this.playlistThreeButton_Click);
            this.playlistThreeButton.MouseEnter += new System.EventHandler(this.playlistThreeButton_MouseEnter);
            this.playlistThreeButton.MouseLeave += new System.EventHandler(this.playlistThreeButton_MouseLeave);
            // 
            // playlistTwoButton
            // 
            this.playlistTwoButton.AutoSize = true;
            this.playlistTwoButton.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlistTwoButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.playlistTwoButton.Location = new System.Drawing.Point(12, 238);
            this.playlistTwoButton.Name = "playlistTwoButton";
            this.playlistTwoButton.Size = new System.Drawing.Size(85, 20);
            this.playlistTwoButton.TabIndex = 7;
            this.playlistTwoButton.Text = "Playlist Two";
            this.playlistTwoButton.Visible = false;
            this.playlistTwoButton.Click += new System.EventHandler(this.playlistTwoButton_Click);
            this.playlistTwoButton.MouseEnter += new System.EventHandler(this.playlistTwoButton_MouseEnter);
            this.playlistTwoButton.MouseLeave += new System.EventHandler(this.playlistTwoButton_MouseLeave);
            // 
            // playlistOneButton
            // 
            this.playlistOneButton.AutoSize = true;
            this.playlistOneButton.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlistOneButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.playlistOneButton.Location = new System.Drawing.Point(11, 218);
            this.playlistOneButton.Name = "playlistOneButton";
            this.playlistOneButton.Size = new System.Drawing.Size(85, 20);
            this.playlistOneButton.TabIndex = 6;
            this.playlistOneButton.Text = "Playlist One";
            this.playlistOneButton.Visible = false;
            this.playlistOneButton.Click += new System.EventHandler(this.playlistOneButton_Click);
            this.playlistOneButton.MouseEnter += new System.EventHandler(this.playlistOneButton_MouseEnter);
            this.playlistOneButton.MouseLeave += new System.EventHandler(this.playlistOneButton_MouseLeave);
            // 
            // myPlaylistsButton
            // 
            this.myPlaylistsButton.AutoSize = true;
            this.myPlaylistsButton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myPlaylistsButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.myPlaylistsButton.Location = new System.Drawing.Point(3, 194);
            this.myPlaylistsButton.Name = "myPlaylistsButton";
            this.myPlaylistsButton.Size = new System.Drawing.Size(110, 24);
            this.myPlaylistsButton.TabIndex = 5;
            this.myPlaylistsButton.Text = "My Playlists";
            this.myPlaylistsButton.Click += new System.EventHandler(this.myPlaylistsButton_Click);
            this.myPlaylistsButton.MouseEnter += new System.EventHandler(this.myPlaylistsButton_MouseEnter);
            this.myPlaylistsButton.MouseLeave += new System.EventHandler(this.myPlaylistsButton_MouseLeave);
            // 
            // createPlaylistButton
            // 
            this.createPlaylistButton.AutoSize = true;
            this.createPlaylistButton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPlaylistButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.createPlaylistButton.Location = new System.Drawing.Point(3, 141);
            this.createPlaylistButton.Name = "createPlaylistButton";
            this.createPlaylistButton.Size = new System.Drawing.Size(135, 24);
            this.createPlaylistButton.TabIndex = 4;
            this.createPlaylistButton.Text = "Create Playlist";
            this.createPlaylistButton.Click += new System.EventHandler(this.createPlaylistButton_Click);
            this.createPlaylistButton.MouseEnter += new System.EventHandler(this.createPlaylistButton_MouseEnter);
            this.createPlaylistButton.MouseLeave += new System.EventHandler(this.createPlaylistButton_MouseLeave);
            // 
            // homeButton
            // 
            this.homeButton.AutoSize = true;
            this.homeButton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.homeButton.Location = new System.Drawing.Point(3, 40);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(58, 24);
            this.homeButton.TabIndex = 3;
            this.homeButton.Text = "Home";
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            this.homeButton.MouseEnter += new System.EventHandler(this.homeButton_MouseEnter);
            this.homeButton.MouseLeave += new System.EventHandler(this.homeButton_MouseLeave);
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.searchButton.Location = new System.Drawing.Point(3, 90);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(66, 24);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            this.searchButton.MouseEnter += new System.EventHandler(this.searchButton_MouseEnter);
            this.searchButton.MouseLeave += new System.EventHandler(this.searchButton_MouseLeave);
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.label2);
            this.MenuPanel.Controls.Add(this.label3);
            this.MenuPanel.Location = new System.Drawing.Point(141, 66);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(689, 375);
            this.MenuPanel.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(61, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(569, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Use the navigation features on the left to utilise the music player";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(149, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "Simple Music Player";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(831, 546);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.navigationBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Music Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.navigationBar.ResumeLayout(false);
            this.navigationBar.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel navigationBar;
        private System.Windows.Forms.Label playlistThreeButton;
        private System.Windows.Forms.Label playlistTwoButton;
        private System.Windows.Forms.Label playlistOneButton;
        private System.Windows.Forms.Label myPlaylistsButton;
        private System.Windows.Forms.Label createPlaylistButton;
        private System.Windows.Forms.Label searchButton;
        private System.Windows.Forms.Label homeButton;
        private System.Windows.Forms.Label exitButton;
        private System.Windows.Forms.Label minimizeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

