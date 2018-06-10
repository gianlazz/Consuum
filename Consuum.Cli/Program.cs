using System;
using System.Threading;
using Consuum.Clipboard;
using Consuum.Tts;

namespace Consuum.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var macSpeech = new MacSpeech();
            var clp = new MacClipboard();
            var lines = clp.GetLines();
            for (int i = 0; i < lines.Count; i++)
            {
                Console.WriteLine(lines[i]);
                macSpeech.Speak(lines[i], 350);
            }

            //System.Console.Read();
        }
    }
}
