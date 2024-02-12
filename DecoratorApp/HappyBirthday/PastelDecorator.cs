using DecoratorApp.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorApp.HappyBirthday
{
    abstract class PastelDecorator : IPastel
    {
        public virtual string Nombre => Target.Nombre!;
        private IPastel Target { get;  }
        protected PastelDecorator( IPastel pastel ) {
            Target = pastel;
        }
        public virtual Size GetDimensions(Size propaganda) => 
            Target.GetDimensions(propaganda);
    }
}
