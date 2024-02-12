using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterApp
{
    class KeywordsRepository
    {
        public IEnumerable<string> FindFor(string videoHandle) => 
            videoHandle == "laguna" ? new[] { "cinema", "paraiso" } : Enumerable.Empty<string>();
        }
}
