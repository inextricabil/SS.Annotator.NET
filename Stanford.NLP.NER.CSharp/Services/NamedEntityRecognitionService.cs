﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using edu.stanford.nlp.ie.crf;
using Stanford.NLP.NER.CSharp.Interfaces;
using Stanford.NLP.NER.CSharp.Models;

namespace Stanford.NLP.NER.CSharp.Services
{
    public class NamedEntityRecognitionService : INamedEntityRecognitionService
    {
        public string[] GetPlaces(string text)
        {
            var classifiersDirectory = Environment.CurrentDirectory + @"\stanford-ner-2016-10-31\classifiers";
            var classifier = CRFClassifier.getClassifierNoExceptions(Path.Combine(classifiersDirectory, "english.muc.7class.distsim.crf.ser.gz"));
            var xmlContent = classifier.classifyWithInlineXML(text);

            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml($"<xml>{xmlContent}</xml>");

            var placesElements = xmlDoc.GetElementsByTagName("LOCATION");
            var places = new List<string>();
            for (var i = 0; i < placesElements.Count; i++)
            {
                if (placesElements[i].InnerXml.Length > 0)
                {
                    places.Add(placesElements[i].InnerXml);
                }
            }

            return places.Select(place => place.ToString()).ToArray();
        }
    }
}
