﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dimon_karton
{
    class Bird:Animal,IFlying
    {
        public string Name { get; set; }
        public Bird(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
        }
        public override string ToString() => Name;
    }
}
