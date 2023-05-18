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

        private async void button1_Click(object sender, EventArgs e)
        {
            string videoUrl = url_txb.Text; // get the video URL from the text box

            try
            {
                // Create a YouTube video object using the video URL
                var video = await Task.Run(() => YouTube.Default.GetVideo(videoUrl));

                // Get the directory path of the code file
                string codeDirectory = Path.GetDirectoryName(Application.StartupPath);

                // Create a directory for the audio file
                string projectDirectory = Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName;
                string audioDirectory = Path.Combine(Directory.GetParent(projectDirectory).FullName, "Audio");
                Directory.CreateDirectory(audioDirectory);

                // Save the audio to a file in the directory
                string audioFilePath = Path.Combine(audioDirectory, video.Title + ".mp3");
                await Task.Run(() => File.WriteAllBytes(audioFilePath, video.GetBytes()));
            }
            catch (Exception ex)
            {
                // Display an error message to the user if the download fails
                MessageBox.Show("An error occurred while downloading the audio: " + ex.Message, "Download Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
