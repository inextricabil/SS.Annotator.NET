using System;
using System.Collections.Generic;

namespace TreeBank.Domain
{
    [Serializable]
    public class ExceptValuesOf:Element
    {
        public string AttributeName { get; set; }
        public IList<string> Values { get; set; }
    }
}