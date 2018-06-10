using System;
using System.Threading.Tasks;
using Consuum.DiLibrary;
using Consuum.Domain;

namespace Consuum.EdgeJs
{
    public class Program
    {
        public static PlatformEnum _platform = PlatformEnum.MacOS;
        public static ITextReader _txtReader = Dependencies.CheckoutTextReader(_platform);
        public static ITextToSpeech _tts = Dependencies.CheckoutTts(_platform);

        public static async Task<object> TestClipboard()
        {
            return _txtReader.GetLines()[0];
        }

        // public async Task<object> Invoke(dynamic input)
        // {
        //     Person person = new Person();
        //     return person;
        // }
    }
}
