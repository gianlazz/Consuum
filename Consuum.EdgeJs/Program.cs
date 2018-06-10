using System;
using Consuum.DiLibrary;
using Consuum.Domain;

namespace Consuum.EdgeJs
{
    public class Program
    {
            public static PlatformEnum _platform = PlatformEnum.MacOS;
            public static ITextReader _txtReader = Dependencies.CheckoutTextReader(_platform);
            public static ITextToSpeech _tts = Dependencies.CheckoutTts(_platform);

    }
}
