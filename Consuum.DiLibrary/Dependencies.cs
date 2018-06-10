using System;
using Consuum.Domain;

namespace Consuum.DiLibrary
{
    public class Dependencies
    {
        public static ITextToSpeech CheckoutTts(PlatformEnum platorm)
        {
            switch (platorm)
            {
                case PlatformEnum.MacOS:
                    return new Consuum.Tts.MacSpeech();
                case PlatformEnum.Linux:
                    throw new NotImplementedException();
                case PlatformEnum.Windows:
                    throw new NotImplementedException();
                default:
                    throw new NotImplementedException();
            }
        }

        public static ITextReader CheckoutTextReader(PlatformEnum platform)
        {
            switch (platform)
            {
                case PlatformEnum.MacOS:
                    return new Consuum.Clipboard.MacClipboard();
                case PlatformEnum.Linux:
                    throw new NotImplementedException();
                case PlatformEnum.Windows:
                    throw new NotImplementedException();
                default:
                    throw new NotImplementedException();
            }
        }
    }

    public enum PlatformEnum
    {
        MacOS,
        Windows,
        Linux
    }
}
