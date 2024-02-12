using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator1Cafe.Cafe
{
    public class CafeSimple : ICafe
    {
        public string ObtenerDescripcion()
        {
            return "Cafe simple";
        }

        public double ObtenerPrecio()
        {
            return 1.0;
        }
    }
}
