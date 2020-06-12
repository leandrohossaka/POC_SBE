using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Xml;

namespace SBEReflection.Classes
{
    public class SbeMessage
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Description { get; set; }
        public List<SbeField> Fields { get; set; }

        public SbeMessage(XmlNode node)
        {
            this.Name = node.Attributes["name"].Value;
            this.Id = node.Attributes["id"].Value;
            this.Description = node.Attributes["description"].Value;

            if (node.ChildNodes.Count > 0)
            {
                this.Fields = new List<SbeField>();
                foreach (XmlNode child in node.ChildNodes)
                {
                    if (child.NodeType != XmlNodeType.Comment)
                    {
                        SbeField field = new SbeField(child);
                        this.Fields.Add(field);
                    }
                }
            }
        }

        public SbeMessage()
        {
            this.Fields = new List<SbeField>();
        }

        public SbeMessage Clone()
        {
            SbeMessage target = new SbeMessage();
            target.Description = this.Description;
            target.Id = this.Id;
            target.Name = this.Name;
            foreach (SbeField field in this.Fields)
                target.Fields.Add(field.Clone());
            return target;
        }

        internal void FillFields(Assembly assembly, object messageBodyObj)
        {
            foreach (SbeField field in this.Fields)
            {
                ReflectionHelper.GetField(assembly, field, this.Name, messageBodyObj);
            }
        }

        public string Crack()
        {
            StringBuilder sb = new StringBuilder();
            foreach (SbeField field in this.Fields)
            {
                sb.AppendLine(CrackHelper.CreateLine(field.Id, field.Name, field.Value, field.ValueRef));

                if (field.Fields != null && field.Fields.Count > 0)
                {
                    if (!field.Type.ToLower().Contains("encoding") || field.Type.ToLower().Contains("groupsizeencoding"))
                    {
                        foreach (SbeField child in field.Fields)
                        {
                            sb.AppendLine(CrackHelper.CreateLine(child.Id, "  " + child.Name, child.Value, child.ValueRef));
                        }
                    }
                }
            }

            return sb.ToString();
        }
    }
}
