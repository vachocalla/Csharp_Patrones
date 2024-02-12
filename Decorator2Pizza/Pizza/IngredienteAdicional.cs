using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator2Pizza.Pizza
{
    public abstract class IngredienteAdicional : IPizza
    {
        protected IPizza _pizza;
        public IngredienteAdicional(IPizza  pizza)
        {
            _pizza = pizza;
        }

        public virtual string ObtenerDescripcion()
        {
            return _pizza.ObtenerDescripcion();
        }

        public virtual double ObtenerPrecio()
        {
            return _pizza.ObtenerPrecio();
        }
    }
}
