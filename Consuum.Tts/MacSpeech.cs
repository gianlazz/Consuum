using System;
using System.Diagnostics;
using Consuum.Domain;

namespace Consuum.Tts
{
    public class MacSpeech : ITextToSpeech
    {
        public VoiceEnum Voice = VoiceEnum.Alex;

        public void Speak(string input, int? wpm = 200)
        {
            try
            {
                input = input.FilterForSpeech();
                var procStartInfo = new ProcessStartInfo($"say -v Alex {input} -r {wpm}")
                {
                    //RedirectStandardOutput = true,
                    UseShellExecute = true,
                    //CreateNoWindow = false,
                    //Arguments = $"say -v {Voice} {input} {speed}"
                    //Arguments = $"say -v Alex Hello -r 200"
                };

                var proc = new Process { StartInfo = procStartInfo };
                proc.Start();
                proc.WaitForExit();
            }
            catch{ throw; }
        }
    }

    internal static class MacStringTtsProcess
    {
        public static string FilterForSpeech(this string input)
        {
            input = input.Replace("(", string.Empty);
            input = input.Replace(")", string.Empty);
            return input;
        }
    }

    public enum VoiceEnum
    {
        Alex
    }
}
