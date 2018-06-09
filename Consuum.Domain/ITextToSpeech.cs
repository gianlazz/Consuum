namespace Consuum.Domain
{
    public interface ITextToSpeech
    {
         void Speak(string input, int? wpm = 0);
    }
}