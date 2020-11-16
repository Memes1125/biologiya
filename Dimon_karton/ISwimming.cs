using System;
using System.Collections.Generic;
using System.Text;

namespace Dimon_karton
{
    interface ISwimming
    {
        void Swimm()
        {
            Console.WriteLine(this + " идет в новую точку");
        }
    }
}
