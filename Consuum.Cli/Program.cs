using System;
using Consuum.Tts;

namespace Consuum.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var macSpeech = new MacSpeech();
            macSpeech.Speak("Hello Rosa, this is my test");
            System.Console.Read();
        }
    }
}
