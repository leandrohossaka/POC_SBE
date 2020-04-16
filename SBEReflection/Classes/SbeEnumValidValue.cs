using System.Xml;

namespace SBEReflection.Classes
{
    public class SbeEnumValidValue
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public SbeEnumValidValue(XmlNode node)
        {
            this.Name = node.Attributes["name"].Value;
            this.Value = node.InnerText;
        }
    }
}
