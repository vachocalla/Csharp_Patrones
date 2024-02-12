using Adapter1.Actual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter1.AdapterEsperado
{
    // Adaptador que permite que la clase Adaptee trabaje como un ITarget
    /*
     Adaptador (Adapter): Es una clase que implementa la interfaz objetivo y actúa como un intermediario entre el cliente y el objeto a adaptar. El adaptador envuelve el objeto a adaptar y proporciona una interfaz compatible con el cliente.
     */

    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public void Request()
        {
            _adaptee.SpecificRequest();
        }
    }
}
