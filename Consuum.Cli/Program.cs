using System;
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
            clp.GetLines().ForEach(x => macSpeech.Speak(x, 300));
            //macSpeech.Speak("Hello Rosa, this is my test");
            System.Console.Read();
        }
    }
}
