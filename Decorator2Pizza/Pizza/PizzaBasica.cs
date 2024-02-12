using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator2Pizza.Pizza
{
    public class PizzaBasica : IPizza
    {
        public string ObtenerDescripcion()
        {
            return "Pizza Basica"; 
        }

        public double ObtenerPrecio()
        {
            return 5.0;
        }
    }
}
