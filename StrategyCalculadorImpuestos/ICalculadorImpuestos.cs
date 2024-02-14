using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyCalculadorImpuestos
{
    public interface ICalculadorImpuestos
    {
        double CalcularImpuesto( double monto );
    }
}
