using StrategyApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyApp
{
    public interface IDeduction
    {
        Money From(Money a, Money b);
    }
}
