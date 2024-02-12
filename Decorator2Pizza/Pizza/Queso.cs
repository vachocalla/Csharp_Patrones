using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator2Pizza.Pizza
{
    public class Queso : IngredienteAdicional
    {
        public Queso(IPizza pizza) : base(pizza)
        {
        }

        public override string ObtenerDescripcion() {
            return base.ObtenerDescripcion() + ", Queso";
        }
        public override double ObtenerPrecio()
        {
            return base.ObtenerPrecio() + 1.0;
        }
    }
}
