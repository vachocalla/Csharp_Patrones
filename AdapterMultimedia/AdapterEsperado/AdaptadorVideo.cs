using AdapterMultimedia.Actual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterMultimedia.AdapterEsperado
{
    public class AdaptadorVideo : IMultimedia
    {
        private readonly Video _video;

        public AdaptadorVideo(Video video)
        {
            _video = video;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Video: {_video.Titulo} - Resumen: {_video.Resumen}");
        }
    }
}
