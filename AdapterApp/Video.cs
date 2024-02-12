using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterApp
{
    public class Video
    {
        public string? Titulo { get; }
        public string? Handle { get; }
        public Video( string? titulo, string? handle ) { 
            Titulo = titulo;
            Handle = handle;
        }
        public override string ToString() => Titulo!;
    }
}
