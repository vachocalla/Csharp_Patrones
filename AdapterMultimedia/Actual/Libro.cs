using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterMultimedia.Actual
{
    public class Libro
    {
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public string PalabrasClave { get; set; }

        public void BuscarLibro(string consulta)
        {
            Console.WriteLine($"Buscando libro '{consulta}' en la base de datos...");
        }
    }
}
