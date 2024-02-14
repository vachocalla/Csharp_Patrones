using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyMetodoPago
{
    public class ProcesadorPagos
    {
        private IMetodoPago? _metodoPago;

        public ProcesadorPagos()
        {
        }

        public ProcesadorPagos(IMetodoPago? metodoPago)
        {
            _metodoPago = metodoPago;
        }

        public void EstablecerMetodoPago(IMetodoPago metodoPago)
        {
            _metodoPago = metodoPago;
        }

        public void RealizarPago(double monto) {
            _metodoPago!.ProcesarPago(monto);
        }
    }
}
