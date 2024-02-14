using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyMetodoPago
{
    public interface IMetodoPago
    {
        void ProcesarPago(double monto);
    }
}
