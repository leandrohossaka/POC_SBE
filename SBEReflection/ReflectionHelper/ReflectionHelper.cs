using SBEReflection.Classes;
using SBEReflection.Loaders;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SBEReflection
{
    public static class ReflectionHelper
    {
        public static Type GetType(Assembly assembly, string TypeName)
        {
            foreach (System.Type t in assembly.GetTypes())
            {
                if (t.FullName.ToLower().Contains(TypeName.ToLower()))
                {
                    return t;
                }
            }
            return null;
        }

        public static Type GetMessageTypeByTemplateId(Assembly assembly, string TemplateId)
        {
            foreach (System.Type t in assembly.GetTypes())
            {
                FieldInfo fi = t.GetField("TemplateId");
                if (fi != null)
                {
                    if (fi.GetRawConstantValue().ToString() == TemplateId)
                        return t;
                }
            }
            return null;
        }

        public static object GetObjectByType(Assembly assembly, string TypeName)
        {
            Type type = GetType(assembly, TypeName);
            if (type != null)
                return Activator.CreateInstance(type);
            return null;
        }

        public static PropertyInfo GetPropertyByName(Assembly assembly, string TypeName, string Property)
        {
            Type type = GetType(assembly, TypeName);
            if (type != null)
            {
                PropertyInfo[] properties = type.GetProperties();
                foreach (PropertyInfo pi in properties)
                {
                    if (pi.Name.ToLower().Contains(Property.ToLower()) || pi.PropertyType.Name.ToLower().Contains(Property.ToLower()))
                        return pi;
                }
            }
            return null;
        }

        public static FieldInfo GetFieldByName(Assembly assembly, string TypeName, string Field)
        {
            Type type = GetType(assembly, TypeName);
            if (type != null)
            {
                FieldInfo[] fields = type.GetFields();
                foreach (FieldInfo fi in fields)
                {
                    if (fi.Name.ToLower().Contains(Field.ToLower()))
                        return fi;
                }
            }
            return null;
        }

        public static MethodInfo GetMethodByName(Assembly assembly, string TypeName, string MethodName)
        {
            Type type = GetType(assembly, TypeName);
            if (type != null)
            {
                MethodInfo[] methods = type.GetMethods();
                foreach (MethodInfo mi in methods)
                {
                    if (mi.Name.ToLower().Contains(MethodName.ToLower()))
                        return mi;
                }
            }
            return null;
        }

        public static MethodInfo GetNestedMethodByName(Assembly assembly, string TypeName, string NestedTypeName, string MethodName)
        {
            Type type = GetType(assembly, TypeName);
            if (type != null)
            {
                Type[] nested = type.GetNestedTypes();
                foreach (Type nest in nested)
                {
                    if (nest.Name.ToLower().Equals(NestedTypeName.ToLower()))
                    {
                        MethodInfo[] methods = nest.GetMethods();
                        foreach (MethodInfo mi in methods)
                        {
                            if (mi.Name.ToLower().Equals(MethodName.ToLower()))
                                return mi;
                        }
                    }
                }
            }
            return null;
        }

        public static PropertyInfo GetNestedPropertyByName(Assembly assembly, string TypeName, string NestedTypeName, string Property)
        {
            Type type = GetType(assembly, TypeName);
            if (type != null)
            {
                Type[] nested = type.GetNestedTypes();
                foreach (Type nest in nested)
                {
                    if (nest.Name.ToLower().Equals(NestedTypeName.ToLower()))
                    {
                        PropertyInfo[] properties = nest.GetProperties();
                        foreach (PropertyInfo pi in properties)
                        {
                            if (pi.Name.ToLower().Contains(Property.ToLower()))
                                return pi;
                        }
                    }
                }
            }
            return null;
        }

        public static MethodInfo GetMethodByName(Assembly assembly, string TypeName, string MethodName, string Parameter)
        {
            Type type = GetType(assembly, TypeName);
            if (type != null)
            {
                MethodInfo[] methods = type.GetMethods();
                foreach (MethodInfo mi in methods)
                {
                    if (mi.IsPublic && mi.Name.ToLower().Contains(MethodName.ToLower()))
                    {
                        if (mi.GetParameters().Length > 0)
                        {
                            foreach (ParameterInfo pi in mi.GetParameters())
                            {
                                if (pi.ParameterType.Name.ToLower().Contains(Parameter))
                                {
                                    return mi;
                                }
                            }
                        }
                    }
                }
            }
            return null;
        }

        public static MethodInfo GetMethodByName(Assembly assembly, string TypeName, string MethodName, string Parameter, int NroParameters)
        {
            Type type = GetType(assembly, TypeName);
            if (type != null)
            {
                MethodInfo[] methods = type.GetMethods();
                foreach (MethodInfo mi in methods)
                {
                    if (mi.IsPublic && mi.Name.ToLower().Contains(MethodName.ToLower()))
                    {
                        if (mi.GetParameters().Length > 0)
                        {
                            if (mi.GetParameters().Length == NroParameters)
                                foreach (ParameterInfo pi in mi.GetParameters())
                                {
                                    if (pi.ParameterType.Name.ToLower().Contains(Parameter))
                                    {
                                        return mi;
                                    }
                                }
                        }
                    }
                }
            }
            return null;
        }

        public static void SetEnumerationField(Assembly assembly, SbeField field, object MessageBody, string MessageName)
        {
            if (field.Presence.Contains("constant") || String.IsNullOrEmpty(field.Value))
                return;

            Type _enumType = ReflectionHelper.GetType(assembly, field.Type);
            if (_enumType.IsEnum)
            {
                SbeEnum _enum = SbeLoader._Enums.Find(x => x.Name == field.Type);
                SbeEnumValidValue valid = _enum.ValidValues.Find(x => x.Value == field.Value);

                PropertyInfo pi = ReflectionHelper.GetPropertyByName(assembly, MessageName, field.Name);
                pi.SetValue(MessageBody, Enum.Parse(_enumType, valid.Name));
            }
        }

        public static void SetField(Assembly assembly, SbeField field, String MessageName, object MessageBody)
        {
            if (SbeLoader._Enums.Find(x => x.Name == field.Type) != null)
            {
                #region Enumeration
                SetEnumerationField(assembly, field, MessageBody, MessageName);
                #endregion
            }
            else if (SbeLoader._SimpleTypes.Find(x => x.Name == field.Type) != null)
            {
                #region Simple Type
                if (field.Presence.Contains("constant") || String.IsNullOrEmpty(field.Value))
                    return;

                //SimpleType
                SbeType simple = SbeLoader._SimpleTypes.Find(x => x.Name == field.Type);
                if (simple.PrimitiveType.ToLower().Equals("char"))
                {
                    FieldInfo fi = ReflectionHelper.GetFieldByName(assembly, MessageName, field.Name + "CharacterEncoding");
                    byte[] fieldByte = System.Text.Encoding.GetEncoding(fi.GetValue(MessageBody).ToString()).GetBytes(field.Value);
                    MethodInfo mi = ReflectionHelper.GetMethodByName(assembly, MessageName, "Set" + field.Name, "byte[]");
                    mi.Invoke(MessageBody, new object[] { fieldByte, 0 });
                }
                else
                {
                    PropertyInfo pi = ReflectionHelper.GetPropertyByName(assembly, MessageName, field.Name);
                    pi.SetValue(MessageBody, Convert.ChangeType(field.Value, pi.PropertyType));
                }
                #endregion
            }
            else if (SbeLoader._CompositeTypes.Find(x => x.Name == field.Type) != null)
            {
                #region Composite
                if (field.Type.ToLower().Equals("groupsizeencoding"))
                {
                    #region groupsizeencoding
                    //var sides = cross.NoSidesCount(2);
                    //sides.Next();
                    //sides.Side = Side.BUY;
                    //sides.Account = 111;
                    //sides.ClOrdID = 12345;
                    //sides.Next();
                    //sides.Side = Side.SELL;
                    //sides.Account = 222;
                    //sides.ClOrdID = 67890;
                    MethodInfo mi = ReflectionHelper.GetMethodByName(assembly, MessageName, field.Name + "Count");
                    var repeatGroup = mi.Invoke(MessageBody, new object[] { int.Parse(field.Value) });

                    MethodInfo next = ReflectionHelper.GetNestedMethodByName(assembly, MessageName, field.Name + "Group", "next");

                    SbeMessage _Original = SbeLoader.LoadMessageByName(MessageName);
                    SbeField _OriginalField = _Original.Fields.Find(x => x.Name == field.Name).Clone();

                    foreach (SbeField child in field.Fields)
                    {
                        if (child.Name == _OriginalField.Fields[0].Name)
                            next.Invoke(repeatGroup, null);

                        if (!String.IsNullOrEmpty(child.Value))
                            if (SbeLoader._Enums.Find(x => x.Name == child.Type) != null)
                            {
                                if (child.Presence.Contains("constant") || String.IsNullOrEmpty(child.Value))
                                    continue;

                                Type _enumType = ReflectionHelper.GetType(assembly, child.Type);
                                if (_enumType.IsEnum)
                                {
                                    SbeEnum _enum = SbeLoader._Enums.Find(x => x.Name == child.Type);
                                    SbeEnumValidValue valid = _enum.ValidValues.Find(x => x.Value == child.Value);

                                    PropertyInfo pi = ReflectionHelper.GetNestedPropertyByName(assembly, MessageName, field.Name + "Group", child.Name);
                                    pi.SetValue(repeatGroup, Enum.Parse(_enumType, valid.Name));
                                }
                            }
                            else
                            {
                                PropertyInfo pi = ReflectionHelper.GetNestedPropertyByName(assembly, MessageName, field.Name + "Group", child.Name);
                                pi.SetValue(repeatGroup, Convert.ChangeType(child.Value, pi.PropertyType));
                            }
                    }
                    #endregion
                }
                else
                {
                    PropertyInfo pi = ReflectionHelper.GetPropertyByName(assembly, MessageName, field.Type);
                    if (pi != null)
                    {
                        object parent = pi.GetValue(MessageBody);

                        foreach (SbeField child in field.Fields)
                        {
                            if (child.Presence.Contains("constant") || String.IsNullOrEmpty(child.Value))
                                continue;

                            PropertyInfo pi2 = ReflectionHelper.GetPropertyByName(assembly, field.Type, child.Name);
                            pi2.SetValue(parent, Convert.ChangeType(child.Value, pi2.PropertyType));
                        }
                    }
                    else
                    {
                        // Manufacturer = Encoding.GetEncoding(Car.ManufacturerCharacterEncoding).GetBytes("Honda");
                        // car.SetManufacturer(Manufacturer, srcOffset, Manufacturer.Length);
                        FieldInfo fi = ReflectionHelper.GetFieldByName(assembly, MessageName, field.Name + "CharacterEncoding");
                        byte[] fieldByte = System.Text.Encoding.GetEncoding(fi.GetValue(MessageBody).ToString())
                            .GetBytes(field.Value);
                        MethodInfo mi = ReflectionHelper.GetMethodByName(assembly, MessageName, "Set" + field.Name, "byte[]");
                        mi.Invoke(MessageBody, new object[] { fieldByte, 0, fieldByte.Length });
                        //mi.Invoke(MessageBody, new object[] { fieldByte, 0 });
                    }
                }
                #endregion
            }
        }

        public static void GetEnumerationField(Assembly assembly, SbeField field, object MessageBody, string MessageName)
        {
            if (field.Presence.Contains("constant"))
                return;

            Type _enumType = ReflectionHelper.GetType(assembly, field.Type);
            if (_enumType.IsEnum)
            {
                SbeEnum _enum = SbeLoader._Enums.Find(x => x.Name == field.Type);

                PropertyInfo pi = ReflectionHelper.GetPropertyByName(assembly, MessageName, field.Name);
                field.ValueRef = Convert.ChangeType(pi.GetValue(MessageBody), pi.PropertyType).ToString();


                SbeEnumValidValue valid = _enum.ValidValues.Find(x => x.Name == field.ValueRef);
                if (valid != null)
                    field.Value = valid.Value;
            }
        }

        public static SbeField GetField(Assembly assembly, SbeField field, String MessageName, object MessageBody)
        {
            if (SbeLoader._Enums.Find(x => x.Name == field.Type) != null)
            {
                #region Enumeration
                GetEnumerationField(assembly, field, MessageBody, MessageName);
                #endregion
            }
            else if (SbeLoader._SimpleTypes.Find(x => x.Name == field.Type) != null)
            {
                #region Simple Type
                if (field.Presence.Contains("constant"))
                    return field;

                //SimpleType
                SbeType simple = SbeLoader._SimpleTypes.Find(x => x.Name == field.Type);
                if (simple.PrimitiveType.ToLower().Equals("char"))
                {
                    FieldInfo l = ReflectionHelper.GetFieldByName(assembly, MessageName, field.Name + "Length");
                    int length = (int)l.GetValue(MessageBody);

                    var fieldByte = new byte[length];
                    MethodInfo mi = ReflectionHelper.GetMethodByName(assembly, MessageName, "Get" + field.Name, "byte[]");
                    mi.Invoke(MessageBody, new object[] { fieldByte, 0 }).ToString();

                    FieldInfo fi = ReflectionHelper.GetFieldByName(assembly, MessageName, field.Name + "CharacterEncoding");
                    string enc = fi.GetValue(MessageBody).ToString();
                    field.Value = Encoding.GetEncoding(enc).GetString(fieldByte, 0, length);
                }
                else
                {
                    PropertyInfo pi = ReflectionHelper.GetPropertyByName(assembly, MessageName, field.Name);
                    field.Value = Convert.ChangeType(pi.GetValue(MessageBody), pi.PropertyType).ToString();
                }
                #endregion
            }
            else if (SbeLoader._CompositeTypes.Find(x => x.Name == field.Type) != null)
            {
                #region Composite
                if (field.Type.ToLower().Equals("groupsizeencoding"))
                {
                    #region groupsizeencoding
                    //var fuelFiguresGroup = car.FuelFigures;
                    //while (fuelFiguresGroup.HasNext)
                    //{
                    //var fuelFigures = fuelFiguresGroup.Next();
                    //sb.Append("\ncar.fuelFigures.speed=").Append(fuelFigures.Speed);
                    //sb.Append("\ncar.fuelFigures.mpg=").Append(fuelFigures.Mpg);
                    //}
                    PropertyInfo no = ReflectionHelper.GetPropertyByName(assembly, MessageName, field.Name);
                    var repeat = no.GetValue(MessageBody);

                    PropertyInfo hasNext = ReflectionHelper.GetPropertyByName(assembly, field.Name, "HasNext");
                    bool nextValue = (bool)hasNext.GetValue(repeat);

                    SbeMessage _Original = SbeLoader.LoadMessageByName(MessageName);
                    SbeField _OriginalField = _Original.Fields.Find(x => x.Name == field.Name).Clone();
                    field.Fields.Clear();

                    MethodInfo next = ReflectionHelper.GetNestedMethodByName(assembly, MessageName, field.Name + "Group", "next");

                    int size = 0;
                    while (nextValue)
                    {
                        size++;
                        next.Invoke(repeat, null);
                        foreach (SbeField child in _OriginalField.Fields)
                        {
                            if (!child.Presence.Contains("constant"))
                                if (SbeLoader._Enums.Find(x => x.Name == child.Type) != null)
                                {

                                    Type _enumType = ReflectionHelper.GetType(assembly, child.Type);
                                    if (_enumType.IsEnum)
                                    {
                                        SbeEnum _enum = SbeLoader._Enums.Find(x => x.Name == child.Type);

                                        PropertyInfo pi = ReflectionHelper.GetPropertyByName(assembly, field.Name + "Group", child.Name);
                                        child.ValueRef = Convert.ChangeType(pi.GetValue(repeat), pi.PropertyType).ToString();

                                        SbeEnumValidValue valid = _enum.ValidValues.Find(x => x.Name == child.ValueRef);
                                        if (valid != null)
                                            child.Value = valid.Value;
                                    }
                                }
                                else
                                {
                                    PropertyInfo pi = ReflectionHelper.GetNestedPropertyByName(assembly, MessageName, field.Name + "Group", child.Name);
                                    child.Value = pi.GetValue(repeat).ToString();
                                }
                            field.Fields.Add(child.Clone());
                        }

                        nextValue = (bool)hasNext.GetValue(repeat);
                    }
                    field.Value = size.ToString();
                    #endregion
                }
                else
                {
                    PropertyInfo pi = ReflectionHelper.GetPropertyByName(assembly, MessageName, field.Type);
                    if (pi != null)
                    {
                        object parent = pi.GetValue(MessageBody);

                        foreach (SbeField child in field.Fields)
                        {
                            if (child.Presence.Contains("constant"))
                                continue;

                            PropertyInfo pi2 = ReflectionHelper.GetPropertyByName(assembly, field.Type, child.Name);
                            child.Value = pi2.GetValue(parent).ToString();
                        }
                    }
                    else
                    {
                        // length = car.GetManufacturer(buffer, 0, buffer.Length);
                        //sb.Append("\ncar.manufacturer=").Append(Encoding.GetEncoding(Car.ManufacturerCharacterEncoding).GetString(buffer, 0, length));
                        // length = car.GetModel(buffer, 0, buffer.Length);
                        //sb.Append("\ncar.model=").Append(Encoding.GetEncoding(Car.ModelCharacterEncoding).GetString(buffer, 0, length));

                        FieldInfo fi = ReflectionHelper.GetFieldByName(assembly, MessageName, field.Name + "CharacterEncoding");
                        var buffer = new byte[128];
                        MethodInfo mi = ReflectionHelper.GetMethodByName(assembly, MessageName, "Get" + field.Name, "byte[]");

                        int len = (int)(mi.Invoke(MessageBody, new object[] { buffer, 0, buffer.Length }));
                        field.Value = Encoding.GetEncoding(fi.GetValue(MessageBody).ToString()).GetString(buffer, 0, len);
                    }
                }
                #endregion
            }

            return field;
        }
    }
}
