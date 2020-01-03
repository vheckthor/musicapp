namespace musicapp
{
    partial class MusicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.Toppanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labellogo = new System.Windows.Forms.Label();
            this.Songs = new System.Windows.Forms.ListBox();
            this.btnselcetsong = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.footer = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.Toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // Toppanel
            // 
            this.Toppanel.BackColor = System.Drawing.Color.Transparent;
            this.Toppanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Toppanel.BackgroundImage")));
            this.Toppanel.Controls.Add(this.pictureBox1);
            this.Toppanel.Controls.Add(this.labellogo);
            this.Toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Toppanel.Location = new System.Drawing.Point(0, 0);
            this.Toppanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Toppanel.Name = "Toppanel";
            this.Toppanel.Size = new System.Drawing.Size(813, 38);
            this.Toppanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(777, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labellogo
            // 
            this.labellogo.AutoSize = true;
            this.labellogo.Font = new System.Drawing.Font("Prestige Elite Std", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labellogo.Location = new System.Drawing.Point(32, 7);
            this.labellogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labellogo.Name = "labellogo";
            this.labellogo.Size = new System.Drawing.Size(198, 18);
            this.labellogo.TabIndex = 0;
            this.labellogo.Text = " Deca Music Player ";
            // 
            // Songs
            // 
            this.Songs.BackColor = System.Drawing.Color.Black;
            this.Songs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Songs.ForeColor = System.Drawing.Color.White;
            this.Songs.FormattingEnabled = true;
            this.Songs.Location = new System.Drawing.Point(567, 42);
            this.Songs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Songs.Name = "Songs";
            this.Songs.Size = new System.Drawing.Size(244, 286);
            this.Songs.TabIndex = 1;
            this.Songs.SelectedIndexChanged += new System.EventHandler(this.listsong_SelectedIndexChanged);
            // 
            // btnselcetsong
            // 
            this.btnselcetsong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnselcetsong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnselcetsong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnselcetsong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselcetsong.Location = new System.Drawing.Point(567, 331);
            this.btnselcetsong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnselcetsong.Name = "btnselcetsong";
            this.btnselcetsong.Size = new System.Drawing.Size(123, 46);
            this.btnselcetsong.TabIndex = 2;
            this.btnselcetsong.Text = "Select Song";
            this.btnselcetsong.UseVisualStyleBackColor = false;
            this.btnselcetsong.Click += new System.EventHandler(this.btnselcetsong_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(1, 381);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(812, 70);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            this.axWindowsMediaPlayer1.CurrentPlaylistItemAvailable += new AxWMPLib._WMPOCXEvents_CurrentPlaylistItemAvailableEventHandler(this.axWindowsMediaPlayer1_CurrentPlaylistItemAvailable);
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // footer
            // 
            this.footer.AutoSize = true;
            this.footer.BackColor = System.Drawing.Color.Snow;
            this.footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.footer.Location = new System.Drawing.Point(363, 428);
            this.footer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(150, 13);
            this.footer.TabIndex = 4;
            this.footer.Text = "Developed by Vheckthor Drey";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkRed;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(695, 331);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 46);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear Song";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(813, 462);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.btnselcetsong);
            this.Controls.Add(this.Songs);
            this.Controls.Add(this.Toppanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MusicPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decag Music Player";
            this.Toppanel.ResumeLayout(false);
            this.Toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Toppanel;
        private System.Windows.Forms.Label labellogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox Songs;
        private System.Windows.Forms.Button btnselcetsong;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label footer;
        private System.Windows.Forms.Button btnClear;
    }
}

