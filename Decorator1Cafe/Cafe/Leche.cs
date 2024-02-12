using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator1Cafe.Cafe
{
    public class Leche : ICafe
    {
        private ICafe _cafe;

        public Leche(ICafe cafe  )
        {
            _cafe = cafe;
        }

        public string ObtenerDescripcion()
        {
            return _cafe.ObtenerDescripcion() + ", Leche";
        }

        public double ObtenerPrecio()
        {
            return _cafe.ObtenerPrecio() + 0.5;
        }
    }
}
