using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Speech.Synthesis;

namespace Meow
{
    public class MeowFile : ISubject
    {
        public string fileName { get; set; }
        public string meowPattern { get; set; }
        public string meowReplacement { get; set; }
        public List<IObserver> Observers { get; set; }

        public MeowFile()
        {
            this.fileName = String.Empty;
            Observers = new List<IObserver>();
        }

        public void FeedTheCat(bool bReplaceFile)
        {
            var synth = new SpeechSynthesizer();
            //
            var installedVoices = synth.GetInstalledVoices();
            foreach (var voice in installedVoices)
            {
                string name = voice.VoiceInfo.Name;
                VoiceGender gender = voice.VoiceInfo.Gender;
                var culture = voice.VoiceInfo.Culture;
                LogOperation("SVoice name: " + name);
                LogOperation("culture: " + culture.ToString());
            }
            synth.SelectVoice("Microsoft Zira Desktop");

            //

            int timeStampIterator = 1;
            int totalLinesChanged = 0;
            string meowedFile = this.fileName + ".meowed";

            
            Regex rgx = new Regex(this.meowPattern);

            string[] lines = System.IO.File.ReadAllLines(this.fileName);
            StreamWriter writer = new StreamWriter(meowedFile);

            LogOperation("Started scanning " + this.fileName);

            synth.SpeakAsync("Started scanning ");

            for (int i = 0; i < lines.Length; i++)
            {
                ApplyLineChanges(ref timeStampIterator, ref totalLinesChanged, rgx, lines, i);

                writer.WriteLine(lines[i]);
            }

            writer.Close();
            LogOperation("Scanning " + this.fileName + " Completed");
            LogOperation(totalLinesChanged.ToString() + " lines changed");
            synth.SpeakAsync(totalLinesChanged.ToString() + " lines changed");
            
            if (bReplaceFile)
            {
                File.Replace(meowedFile, this.fileName, null);
                LogOperation(this.fileName + " replaced");  
            }
            else
            {
                LogOperation(meowedFile + " Created");            
            }    
            
        }

        private void ApplyLineChanges(ref int timeStampIterator, ref int totalLinesChanged, Regex rgx, string[] lines, int i)
        {
            if (rgx.IsMatch(lines[i]))            
            {

                string replacement = meowReplacement + timeStampIterator.ToString();
                string result = rgx.Replace(lines[i], replacement);
                if (!(lines[i] == result))
                {
                    LogOperation(string.Format("Line {0} changed From:  " + lines[i], i));
                    lines[i] = result;
                    totalLinesChanged++;
                    LogOperation(string.Format("Line {0} changed To:  " + lines[i], i));
                }


                timeStampIterator++;
            }
        }

        #region ISubject Members

        public void Register(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void LogOperation(string logText)
        {
            Observers.ForEach(x => x.LogOperation(logText));
        }

        #endregion
    }
}
