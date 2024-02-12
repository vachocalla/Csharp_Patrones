using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterApp
{
    public class Libro : IWithSimpleKeywords
    {
        public string? Titulo { get; set; }
        public IEnumerable<string>? Keywords { get; }
        public Libro( string titulo, params string[] keywords ) { 
            Titulo = titulo;
            Keywords = keywords;
        }
        public override string ToString() => Titulo!;
    }
}
