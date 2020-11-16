using System;
using System.Collections.Generic;
using System.Text;

namespace Dimon_karton
{
    class Fish:Animal,ISwimming
    {
        public string Name { get; set; }
        public Fish(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
        }
        public override string ToString() => Name;
    }
}
