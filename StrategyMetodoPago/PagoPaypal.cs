using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyMetodoPago
{
    public class PagoPaypal : IMetodoPago
    {
        public void ProcesarPago(double monto)
        {
            Console.WriteLine($"Procesando pago de ${monto} con Paypal...");
        }
    }
}
