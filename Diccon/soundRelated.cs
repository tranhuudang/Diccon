using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Windows.Forms;

namespace Diccon
{
    /// <summary>
    ///  Class xử lí các vấn đề về âm thanh
    /// </summary>
    class soundRelated
    {
        private string soundUrl;
        private string fileAddress;

        public string SoundUrl { get => soundUrl; set => soundUrl = value; }
        public string FileAddress { get => fileAddress; set => fileAddress = value; }

        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        public bool OnlinePlay()
        {
            try
            {

                if (player.isOnline == true) // indentify 
                {
                    player.URL = soundUrl;
                    player.controls.play();
                }
                else
                {
                    return false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
                return false;
            }
            return true;
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
        /// Use to play local file with a given address file
        /// </summary>
        /// <returns></returns>
        public bool OfflinePlay(string path)
        {
            // Phát âm thanh được tải về trong máy
            player.URL = path;
            player.controls.play();
            return false;
        }
        // Speech To Text 
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

