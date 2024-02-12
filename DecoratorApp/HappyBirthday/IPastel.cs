using DecoratorApp.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorApp.HappyBirthday
{
    interface IPastel
    {
        string Nombre { get; }
        Size GetDimensions(Size propaganda);
    }
}
