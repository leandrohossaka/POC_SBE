using System.Collections.Generic;
using System.Xml;

namespace SBEReflection.Classes
{
    public class SbeEnum
    {
        public string Name { get; set; }
        public string EncodingType { get; set; }
        public string SemanticType { get; set; }

        public List<SbeEnumValidValue> ValidValues { get; set; }

        public SbeEnum(XmlNode node)
        {
            this.Name = node.Attributes["name"] != null ? node.Attributes["name"].Value : "";
            this.EncodingType = node.Attributes["encodingType"] != null ? node.Attributes["encodingType"].Value : "";
            this.SemanticType = node.Attributes["semanticType"] != null ? node.Attributes["semanticType"].Value : "";

            if (node.ChildNodes.Count > 0)
            {
                this.ValidValues = new List<SbeEnumValidValue>();
                foreach (XmlNode child in node.ChildNodes)
                {
                    SbeEnumValidValue valid = new SbeEnumValidValue(child);
                    this.ValidValues.Add(valid);
                }
            }
        }
    }
}
