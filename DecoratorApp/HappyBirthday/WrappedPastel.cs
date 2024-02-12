using DecoratorApp.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorApp.HappyBirthday
{
    class WrappedPastel : PastelDecorator
    {
        public WrappedPastel(IPastel pastel) : base(pastel)
        { }

        public override Size GetDimensions(Size propaganda) => 
            base.GetDimensions(propaganda)
            .Add(new Size(
                7 * Length.Millimeter, 
                7 * Length.Millimeter, 
                7 * Length.Millimeter)
            );
    }
}
