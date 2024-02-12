using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterApp.Common
{
    static class EnumerableExtensions
    {
        public static string Join( this IEnumerable<string> sequence, string separator ) =>
            string.Join( separator, sequence );

        public static string ToSequenceString( this IEnumerable<object> sequence, string separator ) =>
            string.Join( separator, sequence.Select(item => item.ToString() ) );
    }
}
