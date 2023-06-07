
namespace MP3
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
            this.prev_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.play_chb = new System.Windows.Forms.CheckBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.down_btn = new System.Windows.Forms.Button();
            this.audio_progress = new System.Windows.Forms.TrackBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ModeChange_btn = new System.Windows.Forms.Button();
            this.volume = new System.Windows.Forms.TrackBar();
            this.remove_btn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Resume_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.album_name = new System.Windows.Forms.TextBox();
            this.artist_name = new System.Windows.Forms.TextBox();
            this.song_name = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.VolMax = new System.Windows.Forms.Button();
            this.VolMin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.audio_progress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // prev_btn
            // 
            this.prev_btn.BackColor = System.Drawing.Color.White;
            this.prev_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prev_btn.Location = new System.Drawing.Point(421, 248);
            this.prev_btn.Name = "prev_btn";
            this.prev_btn.Size = new System.Drawing.Size(50, 50);
            this.prev_btn.TabIndex = 1;
            this.prev_btn.Text = "<<<";
            this.prev_btn.UseVisualStyleBackColor = false;
            // 
            // next_btn
            // 
            this.next_btn.BackColor = System.Drawing.Color.White;
            this.next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_btn.Location = new System.Drawing.Point(574, 248);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(50, 50);
            this.next_btn.TabIndex = 2;
            this.next_btn.Text = ">>>";
            this.next_btn.UseVisualStyleBackColor = false;
            // 
            // play_chb
            // 
            this.play_chb.Appearance = System.Windows.Forms.Appearance.Button;
            this.play_chb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("play_chb.BackgroundImage")));
            this.play_chb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_chb.Location = new System.Drawing.Point(500, 248);
            this.play_chb.Name = "play_chb";
            this.play_chb.Size = new System.Drawing.Size(50, 50);
            this.play_chb.TabIndex = 4;
            this.play_chb.Text = "     ";
            this.play_chb.UseVisualStyleBackColor = true;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.White;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Location = new System.Drawing.Point(33, 467);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 26);
            this.add_btn.TabIndex = 5;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            // 
            // down_btn
            // 
            this.down_btn.BackColor = System.Drawing.Color.White;
            this.down_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.down_btn.Location = new System.Drawing.Point(124, 467);
            this.down_btn.Name = "down_btn";
            this.down_btn.Size = new System.Drawing.Size(90, 26);
            this.down_btn.TabIndex = 6;
            this.down_btn.Text = "Download";
            this.down_btn.UseVisualStyleBackColor = false;
            // 
            // audio_progress
            // 
            this.audio_progress.BackColor = System.Drawing.Color.White;
            this.audio_progress.Location = new System.Drawing.Point(338, 437);
            this.audio_progress.Maximum = 300;
            this.audio_progress.Name = "audio_progress";
            this.audio_progress.Size = new System.Drawing.Size(362, 56);
            this.audio_progress.TabIndex = 12;
            this.audio_progress.TickFrequency = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1086, 400);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Visible = false;
            // 
            // ModeChange_btn
            // 
            this.ModeChange_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ModeChange_btn.BackgroundImage")));
            this.ModeChange_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModeChange_btn.Location = new System.Drawing.Point(338, 248);
            this.ModeChange_btn.Name = "ModeChange_btn";
            this.ModeChange_btn.Size = new System.Drawing.Size(50, 50);
            this.ModeChange_btn.TabIndex = 13;
            this.ModeChange_btn.Text = "      ";
            this.ModeChange_btn.UseVisualStyleBackColor = true;
            this.ModeChange_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // volume
            // 
            this.volume.BackColor = System.Drawing.Color.White;
            this.volume.Location = new System.Drawing.Point(421, 353);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(195, 56);
            this.volume.TabIndex = 11;
            this.volume.Value = 5;
            // 
            // remove_btn
            // 
            this.remove_btn.BackColor = System.Drawing.Color.White;
            this.remove_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_btn.Location = new System.Drawing.Point(231, 467);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(77, 26);
            this.remove_btn.TabIndex = 14;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(33, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(275, 420);
            this.listBox1.TabIndex = 15;
            // 
            // Resume_btn
            // 
            this.Resume_btn.BackColor = System.Drawing.Color.White;
            this.Resume_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Resume_btn.BackgroundImage")));
            this.Resume_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resume_btn.Location = new System.Drawing.Point(650, 248);
            this.Resume_btn.Name = "Resume_btn";
            this.Resume_btn.Size = new System.Drawing.Size(50, 50);
            this.Resume_btn.TabIndex = 16;
            this.Resume_btn.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.album_name);
            this.groupBox1.Controls.Add(this.artist_name);
            this.groupBox1.Controls.Add(this.song_name);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(338, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 158);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFO";
            // 
            // album_name
            // 
            this.album_name.Location = new System.Drawing.Point(130, 102);
            this.album_name.Name = "album_name";
            this.album_name.Size = new System.Drawing.Size(192, 22);
            this.album_name.TabIndex = 23;
            // 
            // artist_name
            // 
            this.artist_name.Location = new System.Drawing.Point(130, 70);
            this.artist_name.Name = "artist_name";
            this.artist_name.Size = new System.Drawing.Size(192, 22);
            this.artist_name.TabIndex = 22;
            // 
            // song_name
            // 
            this.song_name.Location = new System.Drawing.Point(130, 37);
            this.song_name.Name = "song_name";
            this.song_name.Size = new System.Drawing.Size(192, 22);
            this.song_name.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(19, 102);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(88, 22);
            this.textBox3.TabIndex = 21;
            this.textBox3.Text = "Album name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(19, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(88, 22);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "Artist name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 22);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "Song name";
            // 
            // VolMax
            // 
            this.VolMax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VolMax.BackgroundImage")));
            this.VolMax.Enabled = false;
            this.VolMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VolMax.Location = new System.Drawing.Point(644, 353);
            this.VolMax.Name = "VolMax";
            this.VolMax.Size = new System.Drawing.Size(56, 56);
            this.VolMax.TabIndex = 20;
            this.VolMax.UseVisualStyleBackColor = true;
            // 
            // VolMin
            // 
            this.VolMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VolMin.BackgroundImage")));
            this.VolMin.Enabled = false;
            this.VolMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VolMin.Location = new System.Drawing.Point(338, 353);
            this.VolMin.Name = "VolMin";
            this.VolMin.Size = new System.Drawing.Size(56, 56);
            this.VolMin.TabIndex = 21;
            this.VolMin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(732, 515);
            this.Controls.Add(this.VolMin);
            this.Controls.Add(this.VolMax);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Resume_btn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.ModeChange_btn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.audio_progress);
            this.Controls.Add(this.down_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.play_chb);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.prev_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cubeex player";
            ((System.ComponentModel.ISupportInitialize)(this.audio_progress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button prev_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.CheckBox play_chb;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button down_btn;
        private System.Windows.Forms.TrackBar audio_progress;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ModeChange_btn;
        private System.Windows.Forms.TrackBar volume;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Resume_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox song_name;
        private System.Windows.Forms.TextBox album_name;
        private System.Windows.Forms.TextBox artist_name;
        private System.Windows.Forms.Button VolMax;
        private System.Windows.Forms.Button VolMin;
    }
}

