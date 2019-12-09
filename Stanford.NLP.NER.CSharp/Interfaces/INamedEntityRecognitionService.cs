namespace Stanford.NLP.NER.CSharp.Interfaces
{
    public interface INamedEntityRecognitionService
    {
        string[] GetPlaces(string text);
        string[] GetTimexs(string text);
        string[] GetPersons(string text);
    }
}