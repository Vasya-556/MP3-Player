using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using VideoLibrary;

namespace MP3
{
    public partial class Download : Form
    {
        public Download()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string videoUrl = url_txb.Text; // get the video URL from the text box

            try
            {
                // Create a YouTube video object using the video URL
                var video = YouTube.Default.GetVideo(videoUrl);

                // Get the path to the user's desktop
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                // Create a directory for the audio file on the desktop
                string audioDirectory = Path.Combine(desktopPath, "Audio");
                Directory.CreateDirectory(audioDirectory);

                // Save the audio to a file in the directory
                string audioFilePath = Path.Combine(audioDirectory, video.Title + ".mp3");
                File.WriteAllBytes(audioFilePath, video.GetBytes());

                // Display a success message to the user
                MessageBox.Show("Audio downloaded successfully to " + audioFilePath, "Download Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Display an error message to the user if the download fails
                MessageBox.Show("An error occurred while downloading the audio: " + ex.Message, "Download Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
