using Decorator2Pizza.Pizza;

class Program
{
    static void Main(string[] args)
    {
        // Creamos una pizza básica
        IPizza pizzaBasica = new PizzaBasica();
        Console.WriteLine("Pizza: " + pizzaBasica.ObtenerDescripcion());
        Console.WriteLine("Costo: " + pizzaBasica.ObtenerPrecio());
        Console.WriteLine("");

        // Agregamos queso a la pizza
        IPizza pizzaConQueso = new Queso(pizzaBasica);
        Console.WriteLine("Pizza: " + pizzaConQueso.ObtenerDescripcion());
        Console.WriteLine("Costo: " + pizzaConQueso.ObtenerPrecio());
        Console.WriteLine("");

        // Agregamos pepperoni a la pizza con queso
        IPizza pizzaConQuesoYPepperoni = new Pepperoni(pizzaConQueso);
        Console.WriteLine("Pizza: " + pizzaConQuesoYPepperoni.ObtenerDescripcion());
        Console.WriteLine("Costo: " + pizzaConQuesoYPepperoni.ObtenerPrecio());
        Console.WriteLine("");
    }
}