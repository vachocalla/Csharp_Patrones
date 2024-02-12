using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator2Pizza.Pizza
{
    public class Pepperoni : IngredienteAdicional
    {
        public Pepperoni(IPizza pizza) : base(pizza)
        {
        }

        public override string ObtenerDescripcion()
        {
            return base.ObtenerDescripcion() + ", Pepperoni";
        }

        public override double ObtenerPrecio()
        {
            return base.ObtenerPrecio() + 2.0;
        }
    }
}
