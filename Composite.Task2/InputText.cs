using System;

namespace Composite.Task2
{
    public class InputText : IComponent
    {
        string name;
        string value;

        public InputText(string name, string value)
        {
            this.name = name;
            this.value = value;
        }

        public string ConvertToString(int depth = 0)
        {

            return string.Format("<inputText name='{0}' value='{1}'/>" , name, value).PadLeft(depth , ' ');
        }
    }
}
