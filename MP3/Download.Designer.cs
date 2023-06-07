
namespace MP3
{
    partial class Download
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Download));
            this.Paste = new System.Windows.Forms.Label();
            this.url_txb = new System.Windows.Forms.TextBox();
            this.Download_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Paste
            // 
            this.Paste.AutoSize = true;
            this.Paste.ForeColor = System.Drawing.Color.White;
            this.Paste.Location = new System.Drawing.Point(130, 9);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(69, 17);
            this.Paste.TabIndex = 0;
            this.Paste.Text = "Paste link";
            // 
            // url_txb
            // 
            this.url_txb.Location = new System.Drawing.Point(12, 45);
            this.url_txb.Name = "url_txb";
            this.url_txb.Size = new System.Drawing.Size(298, 22);
            this.url_txb.TabIndex = 1;
            // 
            // Download_btn
            // 
            this.Download_btn.BackColor = System.Drawing.Color.White;
            this.Download_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Download_btn.Location = new System.Drawing.Point(109, 83);
            this.Download_btn.Name = "Download_btn";
            this.Download_btn.Size = new System.Drawing.Size(106, 44);
            this.Download_btn.TabIndex = 2;
            this.Download_btn.Text = "Download";
            this.Download_btn.UseVisualStyleBackColor = false;
            this.Download_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Download
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(322, 139);
            this.Controls.Add(this.Download_btn);
            this.Controls.Add(this.url_txb);
            this.Controls.Add(this.Paste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Download";
            this.Text = "Download";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Paste;
        private System.Windows.Forms.TextBox url_txb;
        private System.Windows.Forms.Button Download_btn;
    }
}