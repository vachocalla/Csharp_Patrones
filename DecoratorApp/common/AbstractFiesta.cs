using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorApp.common
{
    abstract class AbstractFiesta
    {
        protected abstract int EventNumber { get; }
        protected abstract void Implementation();

        public void Run() {
            Console.WriteLine($"Fiesta Evento {EventNumber}");
            Implementation();
            Console.WriteLine( new string('-',20) );
            Console.WriteLine();
        }
    }
}
