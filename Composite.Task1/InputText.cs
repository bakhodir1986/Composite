using System;

namespace Composite.Task1
{
    public class InputText
    {
        string name;
        string value;

        public InputText(string name, string value)
        {
            this.name = name;
            this.value = value;
        }

        public string ConvertToString()
        {
            return string.Format("<inputText name='{0}' value='{1}'/>" , name, value);
        }
    }
}
