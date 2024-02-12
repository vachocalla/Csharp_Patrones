using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterMultimedia.Actual
{
    public class Video
    {
        public string Titulo { get; set; }
        public string Resumen { get; set; }
        public DateTime FechaEstreno { get; set; }

        public void BuscarVideo(string consulta)
        {
            Console.WriteLine($"Buscando video '{consulta}' en la base de datos...");
        }
    }
}
