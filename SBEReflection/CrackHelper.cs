using System;

namespace SBEReflection
{
    public static class CrackHelper
    {
        public static string CreateLine(string id, string name, string value, string valueref = "")
        {
            int inicio = 7;
            int meio = 25;
            String temp = "";
            if (String.IsNullOrEmpty(id))
                temp += "".PadLeft(inicio, ' ');
            else
                temp += id.PadLeft(inicio, ' ');
            temp += " ";
            if (String.IsNullOrEmpty(name))
                temp += "".PadRight(meio, '.');
            else
                temp += name.PadRight(meio, '.');
            temp += " ";

            if (!String.IsNullOrEmpty(value))
            {
                if (String.IsNullOrEmpty(valueref))
                    temp += value;
                else
                    temp += String.Format("{0} ({1})", value, valueref);
            }
            return temp;
        }
    }
}
