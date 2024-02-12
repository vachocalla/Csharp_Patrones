using Decorator1Cafe.Cafe;

public class Program
{
    public static void Main(string[] args)
    {
        ICafe cafeSimple = new CafeSimple();
        Console.WriteLine("Cafe: " + cafeSimple.ObtenerDescripcion());
        Console.WriteLine("Precio: $" + cafeSimple.ObtenerPrecio());

        Console.WriteLine("");

        ICafe cafeConLeche = new Leche(cafeSimple);
        Console.WriteLine("Cafe: " + cafeConLeche.ObtenerDescripcion());
        Console.WriteLine("Precio: $" + cafeConLeche.ObtenerPrecio());

    }
}