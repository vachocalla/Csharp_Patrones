using DecoratorApp.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorApp.HappyBirthday
{
    class PastelPreparado : IPastel
    {
        public string? Nombre { get; }
        private Size? Dimensions { get; }

        public PastelPreparado(string? nombre, Size? dimensions)
        {
            Nombre = nombre;
            Dimensions = dimensions;
        }

        public Size GetDimensions(Size propaganda) =>
            Dimensions!.AddToTop(propaganda);

        public override string ToString() =>
            $"{Nombre} - {Dimensions}";
    }
}
