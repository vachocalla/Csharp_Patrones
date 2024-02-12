using AdapterAnimal.Actual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterAnimal.AdapterEsperado
{
    public class AdaptadorGato : IAnimal
    {
        private readonly Gato _gato;

        public AdaptadorGato(Gato gato)
        {
            _gato = gato;
        }

        public void HacerSonido()
        {
            _gato.Maullar(); // Adaptamos el método Maullar al método HacerSonido
        }
    }
}
