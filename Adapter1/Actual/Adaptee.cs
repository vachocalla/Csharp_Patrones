using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter1.Actual
{
    public class Adaptee
    {
        // Clase que representa la fuente de datos externa (Adaptee)
        /*
         Objeto a adaptar (Adaptee): Es la clase existente que tiene una interfaz incompatible con la interfaz requerida por el cliente
         */
        public void SpecificRequest()
        {
            Console.WriteLine("Llamada a la fuente de datos externa...");
        }
    }
}
