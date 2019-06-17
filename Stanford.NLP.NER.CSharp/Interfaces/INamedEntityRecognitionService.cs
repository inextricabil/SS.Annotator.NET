namespace Stanford.NLP.NER.CSharp.Interfaces
{
    public interface INamedEntityRecognitionService
    {
        int[] GetPlacesIndexes(string text);
    }
}