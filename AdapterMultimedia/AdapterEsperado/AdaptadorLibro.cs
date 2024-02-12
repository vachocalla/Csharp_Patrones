using AdapterMultimedia.Actual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterMultimedia.AdapterEsperado
{
    public class AdaptadorLibro : IMultimedia
    {
        private readonly Libro _libro;

        public AdaptadorLibro(Libro libro)
        {
            _libro = libro;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Libro: {_libro.Nombre} - Autor: {_libro.Autor}");
        }
    }
}
