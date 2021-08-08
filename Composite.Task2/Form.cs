using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Task2
{
    public class Form : IComponent
    {
        String name;
        private List<IComponent> components;

        public Form(String name)
        {
            this.name = name;
            components = new List<IComponent>();
        }

        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }

        public string ConvertToString(int depth = 0)
        {
            var sb = new StringBuilder();
            sb.Append(string.Format("<form name='{0}'>", name));
            sb.Append(Environment.NewLine);

            foreach (var element in components)
            {
                sb.Append(element.ConvertToString()); sb.Append(Environment.NewLine);
            }

            sb.Append("</form>");

            return sb.ToString().PadLeft(depth , ' ');
        }
    }
}