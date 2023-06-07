using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using System.IO;
using TagLib;

namespace MP3
{
    public partial class Form1 : Form
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        private Timer timer;

        public Form1()
        {
            InitializeComponent();
            play_chb.CheckedChanged += CentralizedEventHandler1;
            next_btn.Click += CentralizedEventHandler1;
            prev_btn.Click += CentralizedEventHandler1;
            add_btn.Click += CentralizedEventHandler1;
            down_btn.Click += CentralizedEventHandler1;
            remove_btn.Click += CentralizedEventHandler1;
            audio_progress.MouseDown += TrackBar1_MouseDown;
            audio_progress.MouseUp += TrackBar1_MouseUp;
            volume.Scroll += TrackBar2_Scroll;
            comboBox1.SelectedIndexChanged += CentralizedEventHandler1;
            listBox1.SelectedIndexChanged += CentralizedEventHandler1;
            Resume_btn.Click += CentralizedEventHandler1;

            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();

            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            song_name.ReadOnly = true;
            artist_name.ReadOnly = true;
            album_name.ReadOnly = true;

            play_chb.BackgroundImageLayout = ImageLayout.Stretch;
            next_btn.BackgroundImageLayout = ImageLayout.Stretch;
            prev_btn.BackgroundImageLayout = ImageLayout.Stretch;
            ModeChange_btn.BackgroundImageLayout = ImageLayout.Stretch;
            Resume_btn.BackgroundImageLayout = ImageLayout.Stretch;
            VolMax.BackgroundImageLayout = ImageLayout.Stretch;
            VolMin.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public ComboBox ComboBox1 // Change access modifier to public
        {
            get { return comboBox1; }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (outputDevice != null && outputDevice.PlaybackState == PlaybackState.Playing)
                audio_progress.Value = (int)(audioFile.CurrentTime.TotalSeconds / audioFile.TotalTime.TotalSeconds * audio_progress.Maximum);

            if (ModeChange == 1)
                if ((audio_progress.Value == audio_progress.Maximum - 1) || (audio_progress.Value == audio_progress.Maximum))
                {
                    // Restart playing the current song
                    outputDevice.Stop();
                    audioFile.Position = 0;  // Reset the position to the beginning
                    outputDevice.Play();
                }
            if (ModeChange == 2)
                if ((audio_progress.Value == audio_progress.Maximum - 1) || (audio_progress.Value == audio_progress.Maximum))
                {
                    // Get the index of the current song in the ComboBox
                    int currentIndex = comboBox1.SelectedIndex;

                    // Check if there is a next song available
                    if (currentIndex < comboBox1.Items.Count - 1)
                    {
                        // Select the next song in the ComboBox
                        comboBox1.SelectedIndex = currentIndex + 1;

                        play_chb.CheckedChanged += CentralizedEventHandler1;
                    }
                }

            if (ModeChange == 3)
                if (audio_progress.Value == (audio_progress.Maximum - 1) || audio_progress.Value == audio_progress.Maximum)
                {
                    // Stop the current song
                    outputDevice.Stop();
                    audioFile.Position = 0;  // Reset the position to the beginning

                    // Play a random song from the ComboBox
                    if (comboBox1.Items.Count > 0)
                    {
                        Random random = new Random();
                        int randomIndex = random.Next(0, comboBox1.Items.Count);
                        comboBox1.SelectedIndex = randomIndex;
                        string audioFilePath = comboBox1.SelectedItem.ToString();
                        audioFile = new AudioFileReader(audioFilePath);
                        outputDevice.Play();
                    }
                }
        }

        private void TrackBar2_Scroll(object sender, EventArgs e)
        {
            if (outputDevice != null)
                outputDevice.Volume = (float)volume.Value / volume.Maximum;
        }

        private void TrackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            if (outputDevice != null)
            {
                TimeSpan newPosition = TimeSpan.FromSeconds(audio_progress.Value * audioFile.TotalTime.TotalSeconds / audio_progress.Maximum);
                outputDevice.Stop();
                audioFile.CurrentTime = newPosition;
                outputDevice.Play();
                timer.Start();
            }
        }

        private void TrackBar1_MouseDown(object sender, MouseEventArgs e)
        {
            if (outputDevice != null) {
                timer.Stop();

                outputDevice.Pause();
            }
        }

        private void CentralizedEventHandler1(object sender, EventArgs e)
        {
            if (sender == play_chb)
            {
                if (play_chb.Checked)
                {
                    play_chb.BackgroundImage = Image.FromFile(@"C:\Users\vkobr\OneDrive\Робочий стіл\Coursework\MP3\MP3\icons\pause.png");

                    if (outputDevice == null || outputDevice.PlaybackState == PlaybackState.Stopped)
                    {
                        // Load the audio file
                        if (comboBox1.SelectedItem != null)
                        {
                            string audioFilePath = comboBox1.SelectedItem.ToString();
                            audioFile = new AudioFileReader(audioFilePath);

                            // Create a new output device and set its audio source
                            outputDevice = new WaveOutEvent();
                            outputDevice.Init(audioFile);

                            // Start playing the audio
                            outputDevice.Play();
                            
                            timer.Start();
                            string selectedFilePath = comboBox1.SelectedItem.ToString();
                            TagLib.File file = TagLib.File.Create(selectedFilePath);
                            string songTitle = file.Tag.Title;
                            string artist = file.Tag.FirstPerformer;
                            string album = file.Tag.Album;

                            song_name.Text = songTitle;
                            artist_name.Text = artist;
                            album_name.Text = album;
                        }
                    }
                    // Resume playing the audio
                    else if (outputDevice.PlaybackState == PlaybackState.Paused)
                    {
                        outputDevice.Play();
                        timer.Start();
                    }
                }
                else
                {
                    play_chb.BackgroundImage = Image.FromFile(@"C:\Users\vkobr\OneDrive\Робочий стіл\Coursework\MP3\MP3\icons\play.png");

                    // Pause the audio playback
                    if (outputDevice != null && outputDevice.PlaybackState == PlaybackState.Playing)
                    {
                        timer.Stop();
                        outputDevice.Pause();
                    }
                }
            }
            else if (sender == comboBox1)
            {
                // Stop the audio playback if it's currently playing or paused
                if (outputDevice != null && (outputDevice.PlaybackState == PlaybackState.Playing || outputDevice.PlaybackState == PlaybackState.Paused))
                {
                    outputDevice.Stop();
                }

                // Load and play the selected song
                if (comboBox1.SelectedItem != null && play_chb.Checked)
                {
                    string audioFilePath = comboBox1.SelectedItem.ToString();
                    audioFile = new AudioFileReader(audioFilePath);

                    // Create a new output device and set its audio source
                    outputDevice = new WaveOutEvent();
                    outputDevice.Init(audioFile);

                    // Start playing the audio
                    outputDevice.Play();
                }
                if (comboBox1.SelectedItem != null)
                {
                    string selectedFilePath = comboBox1.SelectedItem.ToString();
                    TagLib.File file = TagLib.File.Create(selectedFilePath);
                    string songTitle = file.Tag.Title;
                    string artist = file.Tag.FirstPerformer;
                    string album = file.Tag.Album;

                    song_name.Text = songTitle;
                    artist_name.Text = artist;
                    album_name.Text = album;
                }
            }
            else if (sender == add_btn)
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.Filter = "MP3 Files|*.mp3";
                openFileDialog1.Title = "Select MP3 Files";
                openFileDialog1.Multiselect = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    foreach (string selectedFileName in openFileDialog1.FileNames)
                    {
                        // Add the file path to the ComboBox
                        comboBox1.Items.Add(selectedFileName);

                        // Get song information
                        TagLib.File file = TagLib.File.Create(selectedFileName);
                        string songTitle = file.Tag.Title;
                        string artist = file.Tag.FirstPerformer;

                        // Add song information to the ListBox
                        string songInfo = $"{songTitle} - {artist}";
                        listBox1.Items.Add(songInfo);
                    }

                    play_chb.Checked = false;
                    if (comboBox1.Items.Count > 0)
                        comboBox1.SelectedIndex = 0;
                }
            }
            else if (sender == down_btn)
            {
                Download d = new Download();
                if (d == null)
                    d = new Download();
                d.Show();
                d.Activate();
            }
            else if (sender == remove_btn)
            {
                Remove remove = new Remove(this);
                remove.ShowDialog();

                EnableButtons();
                listBox1.Items.Clear();
                foreach (var item in comboBox1.Items)
                {
                    // Get song information
                    TagLib.File file = TagLib.File.Create(item.ToString());
                    string songTitle = file.Tag.Title;
                    string artist = file.Tag.FirstPerformer;

                    // Add song information to the ListBox
                    string songInfo = $"{songTitle} - {artist}";
                    listBox1.Items.Add(songInfo);
                }
            }
            else if (sender == next_btn)
            {
                next_btn.Enabled = false;
                prev_btn.Enabled = false;
                if (comboBox1.Items.Count > 0)
                {
                    if (ModeChange == 3)
                    {
                        if (comboBox1.Items.Count > 0)
                        {
                            Random random = new Random();
                            int randomIndex = random.Next(0, comboBox1.Items.Count);
                            comboBox1.SelectedIndex = randomIndex;
                            string audioFilePath = comboBox1.SelectedItem.ToString();
                            audioFile = new AudioFileReader(audioFilePath);
                            outputDevice.Play();
                        }
                    }
                    else
                    {
                        int currentIndex = comboBox1.SelectedIndex;
                        if (currentIndex == -1 || currentIndex == comboBox1.Items.Count - 1)
                            currentIndex = 0;
                        else
                            currentIndex++;
                        comboBox1.SelectedIndex = currentIndex;
                        if (outputDevice != null && outputDevice.PlaybackState == PlaybackState.Playing)
                        {
                            outputDevice.Stop();
                            string audioFilePath = comboBox1.SelectedItem.ToString();
                            audioFile = new AudioFileReader(audioFilePath);
                            outputDevice.Init(audioFile);
                            outputDevice.Play();
                        }
                    }
                }
                next_btn.Enabled = true;
                prev_btn.Enabled = true;
            }
            else if (sender == prev_btn)
            {
                next_btn.Enabled = false;
                prev_btn.Enabled = false;
                if (ModeChange == 3)
                {
                    if (comboBox1.Items.Count > 0)
                    {
                        Random random = new Random();
                        int randomIndex = random.Next(0, comboBox1.Items.Count);
                        comboBox1.SelectedIndex = randomIndex;
                        string audioFilePath = comboBox1.SelectedItem.ToString();
                        audioFile = new AudioFileReader(audioFilePath);
                        outputDevice.Play();
                    }
                }
                else 
                {
                    if (comboBox1.Items.Count > 0)
                    {
                        int currentIndex = comboBox1.SelectedIndex;
                        if (currentIndex == -1 || currentIndex == 0)
                            currentIndex = comboBox1.Items.Count - 1;
                        else
                            currentIndex--;
                        comboBox1.SelectedIndex = currentIndex;
                        if (outputDevice != null && outputDevice.PlaybackState == PlaybackState.Playing)
                        {
                            outputDevice.Stop();
                            string audioFilePath = comboBox1.SelectedItem.ToString();
                            audioFile = new AudioFileReader(audioFilePath);
                            outputDevice.Init(audioFile);
                            outputDevice.Play();
                        }
                    }
                }
                next_btn.Enabled = true;
                prev_btn.Enabled = true;
            }
            else if (sender == listBox1){
                if (listBox1.SelectedIndex >= 0 && listBox1.SelectedIndex < comboBox1.Items.Count)
                {
                    comboBox1.SelectedIndex = listBox1.SelectedIndex;
                }
            }
            else if (sender == Resume_btn)
            {
                if (play_chb.Checked && comboBox1.SelectedItem != null)
                {
                    outputDevice.Stop();
                    audioFile.Position = 0;  // Reset the position to the beginning
                    outputDevice.Play();
                }
            }
        }
        private void EnableButtons()
        {
            bool hasItems = comboBox1.Items.Count > 0;
            if (!hasItems)
                song_name.Text = "";
            //songname
        }

        int ModeChange = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            ModeChange++;
            if (ModeChange > 3)
                ModeChange = 1;

            if (ModeChange == 1)
            {
                ModeChange_btn.BackgroundImage = Image.FromFile(@"C:\Users\vkobr\OneDrive\Робочий стіл\Coursework\MP3\MP3\icons\repeat_current_song.png");
            }
            else if (ModeChange == 2)
            {
                ModeChange_btn.BackgroundImage = Image.FromFile(@"C:\Users\vkobr\OneDrive\Робочий стіл\Coursework\MP3\MP3\icons\repeat_current_playlist.png");
            }
            else if (ModeChange == 3)
            {
                ModeChange_btn.BackgroundImage = Image.FromFile(@"C:\Users\vkobr\OneDrive\Робочий стіл\Coursework\MP3\MP3\icons\random.png");
            }
        }

    }
}
