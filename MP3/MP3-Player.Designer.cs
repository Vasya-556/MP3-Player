﻿
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
            this.add_btn = new System.Windows.Forms.Button();
            this.down_btn = new System.Windows.Forms.Button();
            this.audio_progress = new System.Windows.Forms.TrackBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ModeChange_btn = new System.Windows.Forms.Button();
            this.volume = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.remove_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.audio_progress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).BeginInit();
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
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(601, 184);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 5;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
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
            // audio_progress
            // 
            this.audio_progress.Location = new System.Drawing.Point(36, 230);
            this.audio_progress.Maximum = 300;
            this.audio_progress.Name = "audio_progress";
            this.audio_progress.Size = new System.Drawing.Size(730, 56);
            this.audio_progress.TabIndex = 12;
            this.audio_progress.TickFrequency = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(415, 370);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // ModeChange_btn
            // 
            this.ModeChange_btn.Location = new System.Drawing.Point(493, 51);
            this.ModeChange_btn.Name = "ModeChange_btn";
            this.ModeChange_btn.Size = new System.Drawing.Size(75, 23);
            this.ModeChange_btn.TabIndex = 13;
            this.ModeChange_btn.Text = "button1";
            this.ModeChange_btn.UseVisualStyleBackColor = true;
            this.ModeChange_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // volume
            // 
            this.volume.Location = new System.Drawing.Point(36, 338);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(195, 56);
            this.volume.TabIndex = 11;
            this.volume.Value = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(152, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // remove_btn
            // 
            this.remove_btn.Location = new System.Drawing.Point(607, 278);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(75, 23);
            this.remove_btn.TabIndex = 14;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.ModeChange_btn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.audio_progress);
            this.Controls.Add(this.down_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.play_chb);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.prev_btn);
            this.Name = "Form1";
            this.Text = "MP3 Player";
            ((System.ComponentModel.ISupportInitialize)(this.audio_progress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button remove_btn;
    }
}
