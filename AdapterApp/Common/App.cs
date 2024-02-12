using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterApp.Common
{
    abstract class App
    {
        protected abstract int TrsansactionProcessNumber { get; }
        protected abstract void Implementation();

        public void Run() { 
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine($"Operation {TrsansactionProcessNumber} App");
            Implementation();
            Console.WriteLine(new string('-', 20));
        }

    }
}
