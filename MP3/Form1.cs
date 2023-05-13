﻿using System;
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
            open_btn.Click += CentralizedEventHandler1;
            down_btn.Click += CentralizedEventHandler1;
            audio_progress.MouseDown += TrackBar1_MouseDown;
            audio_progress.MouseUp += TrackBar1_MouseUp;
            volume.Scroll += TrackBar2_Scroll;
            comboBox1.SelectedIndexChanged += CentralizedEventHandler1;

            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
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
                    play_chb.BackgroundImage = Image.FromFile(@"C:\Users\vkobr\OneDrive\Робочий стіл\ПГІ\C#\Forms\lab-13.1\lab-13.1\1.jpg");

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
                        }
                    }
                    // Resume playing the audio
                    else if (outputDevice.PlaybackState == PlaybackState.Paused)
                    {
                        outputDevice.Play();
                    }
                }
                else
                {
                    play_chb.BackgroundImage = Image.FromFile(@"C:\Users\vkobr\OneDrive\Робочий стіл\ПГІ\C#\Forms\lab-13.1\lab-13.1\2.jpg");

                    // Pause the audio playback
                    if (outputDevice != null && outputDevice.PlaybackState == PlaybackState.Playing)
                    {
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
            }
            else if (sender == open_btn)
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.Filter = "MP3 Files|*.mp3";
                openFileDialog1.Title = "Select MP3 Files";
                openFileDialog1.Multiselect = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    foreach (string selectedFileName in openFileDialog1.FileNames)
                    {
                        // Load the new audio file
                        AudioFileReader audioFile = new AudioFileReader(selectedFileName);

                        // Create a new output device and set its audio source
                        WaveOutEvent outputDevice = new WaveOutEvent();
                        outputDevice.Init(audioFile);

                        // Add the file path to the ComboBox
                        comboBox1.Items.Add(selectedFileName);

                        // Dispose of the audio file and output device objects
                        audioFile.Dispose();
                        outputDevice.Dispose();
                    }

                    play_chb.Checked = false;
                    if (comboBox1.Items.Count > 0)
                    {
                        comboBox1.SelectedIndex = 0;
                    }
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
            else if (sender == next_btn)
            {
                if (comboBox1.Items.Count > 0)
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
            else if (sender == prev_btn)
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
        }
        private int currentSongIndex = 0;
        private void PlayCurrentSong()
        {
            if (audio_progress.Value == audio_progress.Maximum)
            {
                // Restart playing the current song
                outputDevice.Stop();
                audioFile.Position = 0;  // Reset the position to the beginning
                outputDevice.Play();
            }
        }

        private void PlayAllSongsInOrder()
        {
            if (comboBox1.Items.Count > 0)
            {
                // Select the next song in the list
                currentSongIndex++;

                // Check if we've reached the end of the list
                if (currentSongIndex >= comboBox1.Items.Count)
                {
                    // Wrap around to the beginning of the list
                    currentSongIndex = 0;
                }

                // Set the selected item in the combo box to the next song
                comboBox1.SelectedIndex = currentSongIndex;

                // Start playing the next song
                outputDevice.Play();
            }
        }
        private void PlayAllSongsRandomly()
        {
            if (comboBox1.Items.Count > 0)
            {
                // Generate a random index into the list of songs
                int randomIndex = new Random().Next(comboBox1.Items.Count);

                // Select the random song in the list
                comboBox1.SelectedIndex = randomIndex;

                // Start playing the random song
                outputDevice.Play();
            }
        }

        int ModeChange = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            ModeChange++;
            if (ModeChange == 1 || ModeChange > 4)
            {
                ModeChange_btn.BackgroundImage = Image.FromFile(@"C:\Users\vkobr\OneDrive\Робочий стіл\ПГІ\C#\Forms\lab-13.1\lab-13.1\3.jpg");
            }
            else if (ModeChange == 2)
            {
                ModeChange_btn.BackgroundImage = Image.FromFile(@"C:\Users\vkobr\OneDrive\Робочий стіл\ПГІ\C#\Forms\lab-13.1\lab-13.1\4.jpg");
            }
            else if (ModeChange == 3)
            {
                ModeChange_btn.BackgroundImage = Image.FromFile(@"C:\Users\vkobr\OneDrive\Робочий стіл\ПГІ\C#\Forms\lab-13.1\lab-13.1\5.jpg");
                //PlayAllSongsRandomly();
            }
            else if (ModeChange == 4)
            {
                ModeChange = 0;
            }

        }
    }
}
