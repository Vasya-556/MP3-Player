
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
            this.prev_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.play_chb = new System.Windows.Forms.CheckBox();
            this.open_btn = new System.Windows.Forms.Button();
            this.down_btn = new System.Windows.Forms.Button();
            this.volumeGB = new System.Windows.Forms.GroupBox();
            this.volume = new System.Windows.Forms.TrackBar();
            this.audio_progress = new System.Windows.Forms.TrackBar();
            this.PL_GB = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.T_GB = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.PL_btn = new System.Windows.Forms.Button();
            this.volumeGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.audio_progress)).BeginInit();
            this.PL_GB.SuspendLayout();
            this.T_GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // prev_btn
            // 
            this.prev_btn.Location = new System.Drawing.Point(181, 169);
            this.prev_btn.Name = "prev_btn";
            this.prev_btn.Size = new System.Drawing.Size(75, 23);
            this.prev_btn.TabIndex = 1;
            this.prev_btn.Text = "Previous";
            this.prev_btn.UseVisualStyleBackColor = true;
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(446, 169);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(75, 23);
            this.next_btn.TabIndex = 2;
            this.next_btn.Text = "Next";
            this.next_btn.UseVisualStyleBackColor = true;
            // 
            // play_chb
            // 
            this.play_chb.AutoSize = true;
            this.play_chb.Location = new System.Drawing.Point(356, 116);
            this.play_chb.Name = "play_chb";
            this.play_chb.Size = new System.Drawing.Size(98, 21);
            this.play_chb.TabIndex = 4;
            this.play_chb.Text = "checkBox1";
            this.play_chb.UseVisualStyleBackColor = true;
            // 
            // open_btn
            // 
            this.open_btn.Location = new System.Drawing.Point(601, 184);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(75, 23);
            this.open_btn.TabIndex = 5;
            this.open_btn.Text = "open";
            this.open_btn.UseVisualStyleBackColor = true;
            // 
            // down_btn
            // 
            this.down_btn.Location = new System.Drawing.Point(601, 106);
            this.down_btn.Name = "down_btn";
            this.down_btn.Size = new System.Drawing.Size(90, 23);
            this.down_btn.TabIndex = 6;
            this.down_btn.Text = "download";
            this.down_btn.UseVisualStyleBackColor = true;
            // 
            // volumeGB
            // 
            this.volumeGB.Controls.Add(this.volume);
            this.volumeGB.Location = new System.Drawing.Point(47, 327);
            this.volumeGB.Margin = new System.Windows.Forms.Padding(4);
            this.volumeGB.Name = "volumeGB";
            this.volumeGB.Padding = new System.Windows.Forms.Padding(4);
            this.volumeGB.Size = new System.Drawing.Size(209, 87);
            this.volumeGB.TabIndex = 10;
            this.volumeGB.TabStop = false;
            this.volumeGB.Text = "Volume";
            // 
            // volume
            // 
            this.volume.Location = new System.Drawing.Point(7, 22);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(195, 56);
            this.volume.TabIndex = 11;
            this.volume.Value = 5;
            // 
            // audio_progress
            // 
            this.audio_progress.Location = new System.Drawing.Point(36, 230);
            this.audio_progress.Name = "audio_progress";
            this.audio_progress.Size = new System.Drawing.Size(163, 56);
            this.audio_progress.TabIndex = 12;
            this.audio_progress.TickFrequency = 0;
            // 
            // PL_GB
            // 
            this.PL_GB.Controls.Add(this.comboBox1);
            this.PL_GB.Location = new System.Drawing.Point(296, 348);
            this.PL_GB.Name = "PL_GB";
            this.PL_GB.Size = new System.Drawing.Size(200, 57);
            this.PL_GB.TabIndex = 14;
            this.PL_GB.TabStop = false;
            this.PL_GB.Text = "groupBox1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // T_GB
            // 
            this.T_GB.Controls.Add(this.comboBox2);
            this.T_GB.Location = new System.Drawing.Point(527, 348);
            this.T_GB.Name = "T_GB";
            this.T_GB.Size = new System.Drawing.Size(200, 57);
            this.T_GB.TabIndex = 15;
            this.T_GB.TabStop = false;
            this.T_GB.Text = "groupBox2";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 22);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(188, 24);
            this.comboBox2.TabIndex = 0;
            // 
            // PL_btn
            // 
            this.PL_btn.Location = new System.Drawing.Point(36, 79);
            this.PL_btn.Name = "PL_btn";
            this.PL_btn.Size = new System.Drawing.Size(75, 23);
            this.PL_btn.TabIndex = 16;
            this.PL_btn.Text = "Playlist";
            this.PL_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PL_btn);
            this.Controls.Add(this.T_GB);
            this.Controls.Add(this.PL_GB);
            this.Controls.Add(this.audio_progress);
            this.Controls.Add(this.volumeGB);
            this.Controls.Add(this.down_btn);
            this.Controls.Add(this.open_btn);
            this.Controls.Add(this.play_chb);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.prev_btn);
            this.Name = "Form1";
            this.Text = "MP3 Player";
            this.volumeGB.ResumeLayout(false);
            this.volumeGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.audio_progress)).EndInit();
            this.PL_GB.ResumeLayout(false);
            this.T_GB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button prev_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.CheckBox play_chb;
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.Button down_btn;
        private System.Windows.Forms.GroupBox volumeGB;
        private System.Windows.Forms.TrackBar volume;
        private System.Windows.Forms.TrackBar audio_progress;
        private System.Windows.Forms.GroupBox PL_GB;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox T_GB;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button PL_btn;
    }
}

