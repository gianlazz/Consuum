using System;
using System.Diagnostics;
using Consuum.Domain;

namespace Consuum.Tts
{
    public class MacSpeech : ITextToSpeech
    {
        public VoiceEnum Voice = VoiceEnum.Alex;

        public void Speak(string input, int? wpm = 0)
        {
            string speed = (wpm != null) ? $"-r {wpm}" : string.Empty;
            try
            {
                var procStartInfo = new ProcessStartInfo("terminal")
                {
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = false,
                    Arguments = $"say -v {Voice} {input} {speed}"
                };

                var proc = new Process { StartInfo = procStartInfo };
                proc.Start();
            }
            catch{}
        }
    }

    public enum VoiceEnum
    {
        Alex
    }
}
