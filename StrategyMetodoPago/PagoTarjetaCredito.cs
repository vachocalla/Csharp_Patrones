using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyMetodoPago
{
    public class PagoTarjetaCredito : IMetodoPago
    {
        public void ProcesarPago(double monto)
        {
            Console.WriteLine($"Procesando Pago de ${monto} con tarjeta de credito...");
        }
    }
}
