using System;
using System.Collections.Generic;
using System.Text;

namespace Dimon_karton
{
    interface IFlying
    {
        void Fly()
        {
            Console.WriteLine(this + " идет в новую точку");
        }
    }
}
