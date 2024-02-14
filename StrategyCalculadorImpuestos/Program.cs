using StrategyCalculadorImpuestos;

class Program
{
    static void Main(string[] args)
    {
        // Configuración del contexto con la estrategia de impuestos para Estados Unidos
        Facturacion facturacionUS = new Facturacion(new CalculadorImpuestosUS());
        double totalUS = facturacionUS.CalcularTotalConImpuestos(100);
        Console.WriteLine($"Total con impuestos en Estados Unidos: ${totalUS}");

        // Configuración del contexto con la estrategia de impuestos para Europa
        Facturacion facturacionEU = new Facturacion(new CalculadorImpuestosEU());
        double totalEU = facturacionEU.CalcularTotalConImpuestos(100);
        Console.WriteLine($"Total con impuestos en Europa: ${totalEU}");
    }
}