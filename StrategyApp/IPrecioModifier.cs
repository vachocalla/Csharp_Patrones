using StrategyApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyApp
{
    public interface IPrecioModifier
    {
        (Money first, Money second) ApplyTo(Money a, Money b);
    }
}
