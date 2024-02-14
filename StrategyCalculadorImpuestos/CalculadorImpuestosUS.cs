using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyCalculadorImpuestos
{
    public class CalculadorImpuestosUS : ICalculadorImpuestos
    {
        public double CalcularImpuesto(double monto)
        {
            return monto * 0.1;
        }
    }
}
