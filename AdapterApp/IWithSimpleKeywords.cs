using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterApp
{
    public interface IWithSimpleKeywords
    {
        IEnumerable<string> Keywords { get; }

    }
}
