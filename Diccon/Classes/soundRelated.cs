﻿using System;
using System.IO;
using System.Net;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;
using System.Windows.Forms;

namespace Diccon
{

    class SoundRelated
    {

        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        string currentWord = "";

        /// <summary>
        /// Use to play local file with a given address file
        /// </summary>
        /// <returns></returns>
        public void OfflinePlay(string word)
        {
            if (!Directory.Exists(DicconProp.ResourcesFolder))
            {
                Directory.CreateDirectory(DicconProp.ResourcesFolder);
            }
            currentWord = word;
            string path = DicconProp.ResourcesFolder + word + ".mp3";
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                if (fileInfo.Length > 0)
                {
                    player.URL = path;
                    player.controls.play();
                }
                else
                    // Pronounce word by machine if sound track not exist in the internet and the file size is 0KB
                    MachinePlay(word);
            }
            else
            {
                // Download sound track if not exist in resources folder
                WordRelated wordProcess = new WordRelated(word);
                string onlineUrl = wordProcess.OnlineUrlPath("us");
                Thread thread = new Thread(() =>
                {

                    WebClient client = new WebClient();
                    client.DownloadFileCompleted += Client_DownloadFileCompleted;
                    client.DownloadFileAsync(new Uri(onlineUrl), path);

                });
                thread.Start();

            }
        }

        private void Client_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            OfflinePlay(currentWord);
        }
        /// <summary>
        /// Use intergrated SpeechSynthesizer to pronouce the word
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public bool MachinePlay(string word)
        {
            try
            {
                SpeechSynthesizer machineSound = new SpeechSynthesizer();
                machineSound.Volume = 100;  // 0...100 volumn
                machineSound.Rate = -2;     // -10...10
                machineSound.SpeakAsync(word);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
                return false;
            }
            return true;
        }

        /// <summary>
        /// Speech to text function
        /// </summary>
        /// <param name="waitingtime"></param>
        /// <returns></returns>
        public string SpeechToText(string waitingtime)
        {
            // waiting time format : "00:00:07"
            string word = "";
            SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine();
            Grammar dictationGrammar = new DictationGrammar();
            recognizer.LoadGrammar(dictationGrammar);
            try
            {
                recognizer.SetInputToDefaultAudioDevice();
                TimeSpan time;
                TimeSpan.TryParse(waitingtime, out time);
                RecognitionResult result = recognizer.Recognize(time);

                if (result == null)
                {
                    word = "";
                }
                else
                {
                    word = result.Text;
                }

            }
            catch (InvalidOperationException error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                recognizer.UnloadAllGrammars();
                recognizer.Dispose();
            }
            return word;
        }


    }


}

