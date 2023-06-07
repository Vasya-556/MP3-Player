
namespace MP3
{
    partial class Remove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remove));
            this.Remove_btn = new System.Windows.Forms.Button();
            this.Remove_List = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // Remove_btn
            // 
            this.Remove_btn.BackColor = System.Drawing.Color.White;
            this.Remove_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove_btn.Location = new System.Drawing.Point(12, 250);
            this.Remove_btn.Name = "Remove_btn";
            this.Remove_btn.Size = new System.Drawing.Size(77, 26);
            this.Remove_btn.TabIndex = 1;
            this.Remove_btn.Text = "Remove";
            this.Remove_btn.UseVisualStyleBackColor = false;
            this.Remove_btn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Remove_List
            // 
            this.Remove_List.FormattingEnabled = true;
            this.Remove_List.Location = new System.Drawing.Point(10, 10);
            this.Remove_List.Name = "Remove_List";
            this.Remove_List.Size = new System.Drawing.Size(521, 225);
            this.Remove_List.TabIndex = 2;
            this.Remove_List.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // Remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(543, 288);
            this.Controls.Add(this.Remove_List);
            this.Controls.Add(this.Remove_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Remove";
            this.Text = "Remove";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Remove_btn;
        private System.Windows.Forms.CheckedListBox Remove_List;
    }
}