using AdapterAnimal.Actual;
using AdapterAnimal.AdapterEsperado;

class Program
{
    static void Main(string[] args)
    {
        Gato miGato = new Gato();
        IAnimal animal = new AdaptadorGato(miGato);
        animal.HacerSonido(); // Ahora podemos llamar al método HacerSonido que internamente invoca Maullar()
    }
}