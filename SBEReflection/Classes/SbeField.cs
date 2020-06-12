using SBEReflection.Loaders;
using System;
using System.Collections.Generic;
using System.Xml;

namespace SBEReflection.Classes
{
    public class SbeField
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string Id { get; set; }
        public string Type { get; set; }
        public string SemanticType { get; set; }
        public string Presence { get; set; }
        public string ValueRef { get; set; }
        public int? Offset { get; set; }
        public string PrimitiveType { get; set; }
        public int? Length { get; set; }
        public string DimensionType { get; set; }
        public int? BlockLength { get; set; }
        public List<SbeField> Fields { get; set; }

        public string CharacterEncoding { get; set; }

        public SbeField(XmlNode node)
        {
            this.Value = "";
            this.Name = node.Attributes["name"].Value;
            this.Id = node.Attributes["id"].Value;
            this.Type = node.Attributes["type"] != null ? node.Attributes["type"].Value : "";
            this.SemanticType = node.Attributes["semanticType"] != null ? node.Attributes["semanticType"].Value : "";
            this.Presence = node.Attributes["presence"] != null ? node.Attributes["presence"].Value : "";
            this.ValueRef = node.Attributes["valueRef"] != null ? node.Attributes["valueRef"].Value : "";
            this.Offset = node.Attributes["offset"] != null ? int.Parse(node.Attributes["offset"].Value) : 0;
            this.DimensionType = node.Attributes["dimensionType"] != null ? node.Attributes["dimensionType"].Value : "";
            this.CharacterEncoding = node.Attributes["characterEncoding"] != null ? node.Attributes["characterEncoding"].Value : "";

            if (!string.IsNullOrEmpty(this.DimensionType))
                this.Type = this.DimensionType;
            if (node.Attributes["blockLength"] != null)
                this.BlockLength = int.Parse(node.Attributes["blockLength"].Value);
            this.Fields = new List<SbeField>();

            if (this.Type.ToLower().Equals("groupsizeencoding"))
            {
                this.Value = "1";
            }

            if (node.ChildNodes.Count > 0)
            {
                foreach (XmlNode child in node.ChildNodes)
                {
                    this.Fields.Add(new SbeField(child));
                }
            }
            else if (SbeLoader._CompositeTypes.Find(x => x.Name == this.Type) != null)
            {
                SbeCompositeType comp = SbeLoader._CompositeTypes.Find(x => x.Name == this.Type);
                if (!this.Type.Contains("Encoding"))
                {
                    foreach (SbeType type in comp.Fields)
                    {
                        SbeField f = new SbeField();
                        f.Name = type.Name;
                        f.Type = type.PrimitiveType;
                        f.ValueRef = type.ValueRef;
                        f.Presence = type.Presence;
                        f.Value = type.Value;
                        f.PrimitiveType = type.PrimitiveType;
                        if (this.Length == null)
                            f.Length = GetLengthByType(type.PrimitiveType);
                        this.Fields.Add(f);
                    }
                }
                else
                {
                    foreach (SbeType type in comp.Fields)
                    {
                        if (type.Name == "length")
                        {
                            SbeField f = new SbeField();
                            f.Name = type.Name;
                            f.Type = type.PrimitiveType;
                            f.PrimitiveType = type.PrimitiveType;
                            f.ValueRef = type.ValueRef;
                            f.Presence = type.Presence;
                            f.Value = type.Value;
                            f.Length = type.MaxValue;
                            f.CharacterEncoding = type.CharacterEncoding;
                            this.Fields.Add(f);
                        }
                        else
                        {
                            SbeField f = new SbeField();
                            f.Name = type.Name;
                            f.Type = type.PrimitiveType;
                            f.PrimitiveType = type.PrimitiveType;
                            f.ValueRef = type.CharacterEncoding;
                            f.Presence = type.Presence;
                            f.Value = type.Value;
                            f.Length = 0;
                            f.CharacterEncoding = type.CharacterEncoding;
                            this.Fields.Add(f);
                        }
                    }
                }
            }
            else if (SbeLoader._SimpleTypes.Find(x => x.Name == this.Type) != null)
            {
                SbeType comp = SbeLoader._SimpleTypes.Find(x => x.Name == this.Type);
                this.PrimitiveType = comp.PrimitiveType;
                this.Presence = comp.Presence;
                this.Value = comp.Value;
                this.Length = comp.Length;
                this.CharacterEncoding = comp.CharacterEncoding;
            }
            else if (SbeLoader._Enums.Find(x => x.Name == this.Type) != null)
            {
                SbeEnum comp = SbeLoader._Enums.Find(x => x.Name == this.Type);
                this.PrimitiveType = comp.EncodingType;
                if (this.Length == null)
                    this.Length = GetLengthByType(this.PrimitiveType);
            }

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

            if (this.Length == null)
                this.Length = GetLengthByType(this.PrimitiveType);
        }

        public SbeField Clone()
        {
            SbeField target = new SbeField();
            target.BlockLength = this.BlockLength;
            target.DimensionType = this.DimensionType;
            target.Id = this.Id;
            target.Length = this.Length;
            target.Name = this.Name;
            target.Offset = this.Offset;
            target.Presence = this.Presence;
            target.PrimitiveType = this.PrimitiveType;
            target.SemanticType = this.SemanticType;
            target.Type = this.Type;
            target.Value = this.Value;
            target.ValueRef = this.ValueRef;
            target.Fields = new List<SbeField>();
            target.CharacterEncoding = this.CharacterEncoding;
            if (this.Fields != null && this.Fields.Count > 0)
            {
                foreach (SbeField child in this.Fields)
                    target.Fields.Add(child.Clone());
            }
            return target;
        }

        public SbeField()
        {
            this.Fields = new List<SbeField>();
        }

        private int? GetLengthByType(string type)
        {
            if (type != null)
                if (type.Contains("8"))
                    return 1;
                else if (type.Contains("16"))
                    return 2;
                else if (type.Contains("32"))
                    return 4;
                else if (type.Contains("64"))
                    return 8;
                else if (type.Contains("char") && this.Length == null)
                    return 1;
            return null;
        }
    }
}
