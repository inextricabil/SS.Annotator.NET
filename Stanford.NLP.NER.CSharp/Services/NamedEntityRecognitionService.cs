using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using edu.stanford.nlp.ie.crf;
using Stanford.NLP.NER.CSharp.Interfaces;
using Stanford.NLP.NER.CSharp.Models;

namespace Stanford.NLP.NER.CSharp.Services
{
    public class NamedEntityRecognitionService : INamedEntityRecognitionService
    {
        public int[] GetPlacesIndexes(string text)
        {
            var classifiersDirectory = Environment.CurrentDirectory + @"\stanford-ner-2016-10-31\classifiers";

            var classifier = CRFClassifier.getClassifierNoExceptions(Path.Combine(classifiersDirectory, "english.muc.7class.distsim.crf.ser.gz"));

            var xmlContent = classifier.classifyToString(text, "xml", true);

            var xml = $"<WiCollection><parent>{xmlContent}</parent></WiCollection>";

            //Deserialized XML
            WiCollection wiCollection;

            //Deserialize XML
            var serializer = new XmlSerializer(typeof(WiCollection));
            using (TextReader reader = new StringReader(xml))
            {
                wiCollection = (WiCollection) serializer.Deserialize(reader);
            }

            //Iterate and print standard Entity types
            var entities = Enum.GetValues(typeof(Entity)).Cast<Entity>();
            var result = new StringBuilder();
            foreach (var entity in entities)
            {
                var tags = wiCollection.Wi.Where(x => string.Equals(x.Entity, entity.ToString(), StringComparison.InvariantCultureIgnoreCase));
               result.Append(string.Join(Environment.NewLine, tags.Select(w => w.Text)));
            }

            return new[] {1};
        }
    }
}
