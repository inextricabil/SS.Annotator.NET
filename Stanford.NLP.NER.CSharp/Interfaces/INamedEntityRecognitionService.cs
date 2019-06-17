namespace Stanford.NLP.NER.CSharp.Interfaces
{
    public interface INamedEntityRecognitionService
    {
        string[] GetPlaces(string text);
    }
}