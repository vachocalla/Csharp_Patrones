using StrategyMetodoPago;

class Program
{
    static void Main(string[] args)
    {
        // Configuración del contexto con diferentes estrategias de pago
        ProcesadorPagos procesador = new ProcesadorPagos();

        // Ejemplo de pago con tarjeta de crédito
        procesador.EstablecerMetodoPago(new PagoTarjetaCredito());
        procesador.RealizarPago(100.50);

        // Ejemplo de pago con PayPal
        procesador.EstablecerMetodoPago(new PagoPaypal());
        procesador.RealizarPago(75.25);

        // Ejemplo de pago con transferencia bancaria
        procesador.EstablecerMetodoPago(new PagoTransferenciaBancaria());
        procesador.RealizarPago(150.75);
    }
}