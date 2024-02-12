using Adapter1.Actual;
using Adapter1.AdapterEsperado;

class Program
{
    static void Main(string[] args)
    {
        // Creamos un objeto de la fuente de datos externa
        Adaptee adaptee = new Adaptee();

        // Creamos un adaptador
        ITarget adapter = new Adapter(adaptee);

        // El cliente interactúa con el adaptador, que a su vez llama a la fuente de datos externa
        adapter.Request();
    }
}