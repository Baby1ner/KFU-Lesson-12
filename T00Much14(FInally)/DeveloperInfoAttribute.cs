using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T00Much14_FInally_
{
    internal class DeveloperInfoAttribute : System.Attribute
    {
        public string Name { get; }
        public string datereliz { get; }

        public DeveloperInfoAttribute() { }
        public DeveloperInfoAttribute(string name, string datereliz)
        {
            Name = name;
            this.datereliz = datereliz;
        }
    }
}
