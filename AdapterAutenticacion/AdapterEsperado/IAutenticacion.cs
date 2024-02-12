using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterAutenticacion.AdapterEsperado
{
    public interface IAutenticacion
    {
        void Autenticar( string usuario, string contraseña );
    }
}
