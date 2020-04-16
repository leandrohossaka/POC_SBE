using System.Collections.Generic;
using System.Xml;

namespace SBEReflection.Classes
{
    public class SbeCompositeType
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string SemanticType { get; set; }
        public List<SbeType> Fields { get; set; }

        public SbeCompositeType(XmlNode node)
        {
            this.Name = node.Attributes["name"] != null ? node.Attributes["name"].Value : "";
            this.Description = node.Attributes["description"] != null ? node.Attributes["description"].Value : "";
            this.SemanticType = node.Attributes["semanticType"] != null ? node.Attributes["semanticType"].Value : "";

            if (node.ChildNodes.Count > 0)
            {
                this.Fields = new List<SbeType>();
                foreach (XmlNode child in node.ChildNodes)
                {
                    SbeType type = new SbeType(child);
                    this.Fields.Add(type);
                }
            }
        }
    }
}
