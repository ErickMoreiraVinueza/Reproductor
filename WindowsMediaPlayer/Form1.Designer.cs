namespace WindowsMediaPlayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.picBoxWindows = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSettings5 = new System.Windows.Forms.Label();
            this.lblSettings4 = new System.Windows.Forms.Label();
            this.lblSettings3 = new System.Windows.Forms.Label();
            this.lblSettings2 = new System.Windows.Forms.Label();
            this.lblSettings1 = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.WindowsMediaPlayerMain = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVolume = new System.Windows.Forms.Button();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.lblFIndAlbum = new System.Windows.Forms.Label();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWindows)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayerMain)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.AliceBlue;
            this.panelLeft.Controls.Add(this.picBoxWindows);
            this.panelLeft.Controls.Add(this.label3);
            this.panelLeft.Controls.Add(this.label2);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.lblSettings5);
            this.panelLeft.Controls.Add(this.lblSettings4);
            this.panelLeft.Controls.Add(this.lblSettings3);
            this.panelLeft.Controls.Add(this.lblSettings2);
            this.panelLeft.Controls.Add(this.lblSettings1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(135, 631);
            this.panelLeft.TabIndex = 0;
            // 
            // picBoxWindows
            // 
            this.picBoxWindows.BackgroundImage = global::WindowsMediaPlayer.Properties.Resources.logoxp;
            this.picBoxWindows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxWindows.Location = new System.Drawing.Point(19, 546);
            this.picBoxWindows.Name = "picBoxWindows";
            this.picBoxWindows.Size = new System.Drawing.Size(89, 73);
            this.picBoxWindows.TabIndex = 8;
            this.picBoxWindows.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 133);
            this.label3.TabIndex = 7;
            this.label3.Text = "Skin\r\nChooser\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 114);
            this.label2.TabIndex = 6;
            this.label2.Text = "Premium \r\nServices\r\n\r\n\r\n\r\n\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 114);
            this.label1.TabIndex = 5;
            this.label1.Text = "Copy to CD \r\nor Device\r\n\r\n\r\n\r\n\r\n";
            // 
            // lblSettings5
            // 
            this.lblSettings5.AutoSize = true;
            this.lblSettings5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSettings5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings5.Location = new System.Drawing.Point(13, 281);
            this.lblSettings5.Name = "lblSettings5";
            this.lblSettings5.Size = new System.Drawing.Size(54, 95);
            this.lblSettings5.TabIndex = 4;
            this.lblSettings5.Text = "Radio \r\nTuner\r\n\r\n\r\n\r\n";
            // 
            // lblSettings4
            // 
            this.lblSettings4.AutoSize = true;
            this.lblSettings4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSettings4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings4.Location = new System.Drawing.Point(15, 221);
            this.lblSettings4.Name = "lblSettings4";
            this.lblSettings4.Size = new System.Drawing.Size(58, 95);
            this.lblSettings4.TabIndex = 3;
            this.lblSettings4.Text = "Media\r\nLibrary\r\n\r\n\r\n\r\n";
            // 
            // lblSettings3
            // 
            this.lblSettings3.AutoSize = true;
            this.lblSettings3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSettings3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings3.Location = new System.Drawing.Point(12, 145);
            this.lblSettings3.Name = "lblSettings3";
            this.lblSettings3.Size = new System.Drawing.Size(84, 76);
            this.lblSettings3.TabIndex = 2;
            this.lblSettings3.Text = "Copy from\r\nCD\r\n\r\n\r\n";
            // 
            // lblSettings2
            // 
            this.lblSettings2.AutoSize = true;
            this.lblSettings2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSettings2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings2.Location = new System.Drawing.Point(12, 76);
            this.lblSettings2.Name = "lblSettings2";
            this.lblSettings2.Size = new System.Drawing.Size(50, 57);
            this.lblSettings2.TabIndex = 1;
            this.lblSettings2.Text = "Media\r\nGuide\r\n\r\n";
            // 
            // lblSettings1
            // 
            this.lblSettings1.AutoSize = true;
            this.lblSettings1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSettings1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings1.Location = new System.Drawing.Point(13, 9);
            this.lblSettings1.Name = "lblSettings1";
            this.lblSettings1.Size = new System.Drawing.Size(60, 38);
            this.lblSettings1.TabIndex = 0;
            this.lblSettings1.Text = "Now \r\nPlaying\r\n";
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelRight.Controls.Add(this.WindowsMediaPlayerMain);
            this.panelRight.Controls.Add(this.panel1);
            this.panelRight.Controls.Add(this.listBoxSongs);
            this.panelRight.Controls.Add(this.lblFIndAlbum);
            this.panelRight.Controls.Add(this.picBoxLogo);
            this.panelRight.Location = new System.Drawing.Point(134, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(876, 631);
            this.panelRight.TabIndex = 1;
            // 
            // WindowsMediaPlayerMain
            // 
            this.WindowsMediaPlayerMain.Enabled = true;
            this.WindowsMediaPlayerMain.Location = new System.Drawing.Point(0, 0);
            this.WindowsMediaPlayerMain.Name = "WindowsMediaPlayerMain";
            this.WindowsMediaPlayerMain.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayerMain.OcxState")));
            this.WindowsMediaPlayerMain.Size = new System.Drawing.Size(642, 529);
            this.WindowsMediaPlayerMain.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.btnVolume);
            this.panel1.Controls.Add(this.trackBar);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Location = new System.Drawing.Point(0, 528);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 103);
            this.panel1.TabIndex = 3;
            // 
            // btnVolume
            // 
            this.btnVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolume.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnVolume.FlatAppearance.BorderSize = 0;
            this.btnVolume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolume.Image = global::WindowsMediaPlayer.Properties.Resources.iconsong;
            this.btnVolume.Location = new System.Drawing.Point(527, 22);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(56, 58);
            this.btnVolume.TabIndex = 6;
            this.btnVolume.UseVisualStyleBackColor = true;
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(589, 35);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(273, 45);
            this.trackBar.TabIndex = 5;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Image = global::WindowsMediaPlayer.Properties.Resources.btnatras;
            this.btnPrevious.Location = new System.Drawing.Point(160, 26);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(33, 48);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = global::WindowsMediaPlayer.Properties.Resources.btnsiguiente;
            this.btnNext.Location = new System.Drawing.Point(249, 26);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(47, 48);
            this.btnNext.TabIndex = 3;
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Image = global::WindowsMediaPlayer.Properties.Resources.btnstop;
            this.btnStop.Location = new System.Drawing.Point(199, 22);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(53, 58);
            this.btnStop.TabIndex = 2;
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Image = global::WindowsMediaPlayer.Properties.Resources.btnpause;
            this.btnPause.Location = new System.Drawing.Point(17, 25);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(47, 55);
            this.btnPause.TabIndex = 1;
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Image = global::WindowsMediaPlayer.Properties.Resources.btnplay;
            this.btnPlay.Location = new System.Drawing.Point(70, 29);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(46, 48);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.BackColor = System.Drawing.Color.LightSlateGray;
            this.listBoxSongs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxSongs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxSongs.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSongs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.ItemHeight = 23;
            this.listBoxSongs.Items.AddRange(new object[] {
            "\tSong 1",
            "\tSong 2",
            "\tSong 3",
            "\tSong 4",
            "\tSong 5"});
            this.listBoxSongs.Location = new System.Drawing.Point(643, 244);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(219, 276);
            this.listBoxSongs.TabIndex = 2;
            // 
            // lblFIndAlbum
            // 
            this.lblFIndAlbum.AutoSize = true;
            this.lblFIndAlbum.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFIndAlbum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFIndAlbum.Location = new System.Drawing.Point(687, 19);
            this.lblFIndAlbum.Name = "lblFIndAlbum";
            this.lblFIndAlbum.Size = new System.Drawing.Size(145, 23);
            this.lblFIndAlbum.TabIndex = 1;
            this.lblFIndAlbum.Text = "Find Album Info";
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.BackgroundImage = global::WindowsMediaPlayer.Properties.Resources.wmpfolder;
            this.picBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxLogo.Location = new System.Drawing.Point(643, 45);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(219, 158);
            this.picBoxLogo.TabIndex = 0;
            this.picBoxLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 631);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Media Player";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWindows)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayerMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblSettings1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSettings5;
        private System.Windows.Forms.Label lblSettings4;
        private System.Windows.Forms.Label lblSettings3;
        private System.Windows.Forms.Label lblSettings2;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Label lblFIndAlbum;
        private System.Windows.Forms.PictureBox picBoxWindows;
        private System.Windows.Forms.ListBox listBoxSongs;
        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayerMain;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Button btnVolume;
    }
}

