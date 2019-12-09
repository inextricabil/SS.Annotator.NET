﻿using edu.stanford.nlp.ling;
using edu.stanford.nlp.pipeline;
using edu.stanford.nlp.tagger.maxent;
using edu.stanford.nlp.time;
using edu.stanford.nlp.util;
using java.util;
using Stanford.NLP.SUTime.CSharp.Interfaces;
using System;
using System.Text;

namespace Stanford.NLP.SUTime.CSharp
{
    public class SUTimeService : ISUTimeService
    {

        public string[] GetTimexs(string text)
        {
            var jarRoot = Environment.CurrentDirectory + @"\nlp.stanford.edu\stanford-corenlp-full-2016-10-31\models";
            var modelsDirectory = jarRoot + @"\edu\stanford\nlp\models";

            // Annotation pipeline configuration
            var pipeline = new AnnotationPipeline();
            pipeline.addAnnotator(new TokenizerAnnotator(false));
            pipeline.addAnnotator(new WordsToSentencesAnnotator(false));

            // Loading POS Tagger and including them into pipeline
            var tagger = new MaxentTagger(modelsDirectory +
                         @"\pos-tagger\english-left3words\english-left3words-distsim.tagger");
            pipeline.addAnnotator(new POSTaggerAnnotator(tagger));

            // SUTime configuration
            var sutimeRules = modelsDirectory + @"\sutime\defs.sutime.txt,"
                              + modelsDirectory + @"\sutime\english.holidays.sutime.txt,"
                              + modelsDirectory + @"\sutime\english.sutime.txt";
            var props = new Properties();
            props.setProperty("sutime.rules", sutimeRules);
            props.setProperty("sutime.binders", "0");
            pipeline.addAnnotator(new TimeAnnotator("sutime", props));

            // Sample text for time expression extraction
            //var text = "Three interesting dates are 18 Feb 1997, the 20th of july and 4 days from today.";
            var annotation = new Annotation(text);
            annotation.set(new CoreAnnotations.DocDateAnnotation().getClass(), "2013-07-14");
            pipeline.annotate(annotation);

            var sb = new StringBuilder();
            sb.AppendLine(annotation.get(new CoreAnnotations.TextAnnotation().getClass()).ToString());

            var timexAnnsAll = annotation.get(new TimeAnnotations.TimexAnnotations().getClass()) as java.util.ArrayList;
            foreach (CoreMap cm in timexAnnsAll)
            {
                var tokens = cm.get(new CoreAnnotations.TokensAnnotation().getClass()) as List;
                var first = tokens.get(0);
                var last = tokens.get(tokens.size() - 1);
                var time = cm.get(new TimeExpression.Annotation().getClass()) as TimeExpression;
                sb.AppendLine($"{cm} [from char offset {first} to {last}] --> {time.getTemporal()}");
            }

            return new string[0];
        }
    }
}