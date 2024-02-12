using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter1.AdapterEsperado
{
    // Interfaz objetivo que espera el cliente
    /*
     * Interfaz objetivo (Target): Es la interfaz que el cliente espera y con la que desea interactuar
     */
    public interface ITarget
    {
        void Request();
    }
}
