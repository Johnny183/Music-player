namespace Music_Player
{
    partial class SearchSongItem
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
            this.songName = new System.Windows.Forms.Label();
            this.songArtist = new System.Windows.Forms.Label();
            this.songAlbum = new System.Windows.Forms.Label();
            this.songTime = new System.Windows.Forms.Label();
            this.songAdd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // songName
            // 
            this.songName.AutoSize = true;
            this.songName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songName.ForeColor = System.Drawing.Color.Gainsboro;
            this.songName.Location = new System.Drawing.Point(20, 8);
            this.songName.Name = "songName";
            this.songName.Size = new System.Drawing.Size(88, 22);
            this.songName.TabIndex = 7;
            this.songName.Text = "Song Name";
            // 
            // songArtist
            // 
            this.songArtist.AutoSize = true;
            this.songArtist.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songArtist.ForeColor = System.Drawing.Color.Gainsboro;
            this.songArtist.Location = new System.Drawing.Point(222, 8);
            this.songArtist.Name = "songArtist";
            this.songArtist.Size = new System.Drawing.Size(85, 22);
            this.songArtist.TabIndex = 8;
            this.songArtist.Text = "Song Artist";
            // 
            // songAlbum
            // 
            this.songAlbum.AutoSize = true;
            this.songAlbum.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songAlbum.ForeColor = System.Drawing.Color.Gainsboro;
            this.songAlbum.Location = new System.Drawing.Point(349, 8);
            this.songAlbum.Name = "songAlbum";
            this.songAlbum.Size = new System.Drawing.Size(90, 22);
            this.songAlbum.TabIndex = 9;
            this.songAlbum.Text = "Song Album";
            // 
            // songTime
            // 
            this.songTime.AutoSize = true;
            this.songTime.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.songTime.Location = new System.Drawing.Point(474, 8);
            this.songTime.Name = "songTime";
            this.songTime.Size = new System.Drawing.Size(83, 22);
            this.songTime.TabIndex = 10;
            this.songTime.Text = "Song Time";
            // 
            // songAdd
            // 
            this.songAdd.AutoSize = true;
            this.songAdd.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songAdd.ForeColor = System.Drawing.Color.GhostWhite;
            this.songAdd.Location = new System.Drawing.Point(596, -2);
            this.songAdd.Name = "songAdd";
            this.songAdd.Size = new System.Drawing.Size(34, 40);
            this.songAdd.TabIndex = 11;
            this.songAdd.Text = "+";
            // 
            // SearchSongItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.songAdd);
            this.Controls.Add(this.songTime);
            this.Controls.Add(this.songAlbum);
            this.Controls.Add(this.songArtist);
            this.Controls.Add(this.songName);
            this.Name = "SearchSongItem";
            this.Size = new System.Drawing.Size(644, 38);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label songName;
        private System.Windows.Forms.Label songArtist;
        private System.Windows.Forms.Label songAlbum;
        private System.Windows.Forms.Label songTime;
        private System.Windows.Forms.Label songAdd;
    }
}
