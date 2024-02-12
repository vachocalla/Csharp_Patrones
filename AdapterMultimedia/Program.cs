using AdapterMultimedia.Actual;
using AdapterMultimedia.AdapterEsperado;

class Program
{
    static void Main(string[] args)
    {
        // Simulación de búsqueda de libros y videos

        // Crear objetos de libros y videos
        Libro libro = new Libro { Nombre = "Cien años de soledad", Autor = "Gabriel García Márquez", PalabrasClave = "Realismo mágico" };
        Video video = new Video { Titulo = "Inception", Resumen = "Película de ciencia ficción y acción", FechaEstreno = new DateTime(2010, 7, 16) };

        // Crear adaptadores para libros y videos
        IMultimedia adaptadorLibro = new AdaptadorLibro(libro);
        IMultimedia adaptadorVideo = new AdaptadorVideo(video);

        // Mostrar información de libros y videos
        Console.WriteLine("Información del libro:");
        adaptadorLibro.MostrarInformacion();

        Console.WriteLine("\nInformación del video:");
        adaptadorVideo.MostrarInformacion();
    }
}