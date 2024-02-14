using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyApp.Common
{
    abstract class App
    {
        protected abstract int TransactionProcessNumber { get; }

        protected abstract void Implementation();

        public void Run() {
            Console.WriteLine( $"TransactionNumber : {TransactionProcessNumber}" );
            Implementation();
            Console.WriteLine(new String('-', 20));
        }
    }
}
