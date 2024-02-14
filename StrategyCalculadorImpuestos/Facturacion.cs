using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyCalculadorImpuestos
{
    public class Facturacion
    {
        private ICalculadorImpuestos _calculadorImpuestos;
        public Facturacion(ICalculadorImpuestos calculadorImpuestos)
        {
            _calculadorImpuestos = calculadorImpuestos;
        }

        public double CalcularTotalConImpuestos(double monto) {
            double impuestos = _calculadorImpuestos.CalcularImpuesto(monto);
            return monto + impuestos;
        }
    }
}
