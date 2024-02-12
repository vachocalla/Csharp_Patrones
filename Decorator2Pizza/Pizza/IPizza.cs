using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator2Pizza.Pizza
{
    public interface IPizza
    {
        string ObtenerDescripcion();
        double ObtenerPrecio();
    }
}
