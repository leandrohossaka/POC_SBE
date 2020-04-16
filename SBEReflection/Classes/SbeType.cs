using SBEReflection.Loaders;
using System.Xml;

namespace SBEReflection.Classes
{
    public class SbeType
    {
        public string Name { get; set; }
        public string PrimitiveType { get; set; }
        public int? Length { get; set; }
        public string CharacterEncoding { get; set; }
        public string SemanticType { get; set; }
        public string Description { get; set; }
        public string Presence { get; set; }
        public string ValueRef { get; set; }
        public string Value { get; set; }
        public int? MaxValue { get; set; }

        public SbeType(XmlNode node)
        {
            this.Name = node.Attributes["name"].Value;
            this.PrimitiveType = node.Attributes["primitiveType"] != null ? node.Attributes["primitiveType"].Value : "";
            if (node.Attributes["length"] != null)
                this.Length = int.Parse(node.Attributes["length"].Value);
            this.CharacterEncoding = node.Attributes["characterEncoding"] != null ? node.Attributes["characterEncoding"].Value : "";
            this.SemanticType = node.Attributes["semanticType"] != null ? node.Attributes["semanticType"].Value : "";
            this.Description = node.Attributes["description"] != null ? node.Attributes["description"].Value : "";
            this.Presence = node.Attributes["presence"] != null ? node.Attributes["presence"].Value : "";
            this.ValueRef = node.Attributes["valueRef"] != null ? node.Attributes["valueRef"].Value : "";
            if (node.Attributes["maxValue"] != null)
                this.MaxValue = int.Parse(node.Attributes["maxValue"].Value);
            this.Value = node.InnerText;

            if (!string.IsNullOrEmpty(this.ValueRef))
            {
                string toFind = this.ValueRef;

                if (this.ValueRef.Contains("."))
                    toFind = this.ValueRef.Split('.')[0];

                if (SbeLoader._Enums.Find(x => x.Name == toFind) != null)
                {
                    SbeEnum comp = SbeLoader._Enums.Find(x => x.Name == toFind);
                    if (comp.ValidValues.Find(x => x.Name == this.ValueRef.Split('.')[1]) != null)
                        this.Value = comp.ValidValues.Find(x => x.Name == this.ValueRef.Split('.')[1]).Value;
                }
            }
        }
    }
}
