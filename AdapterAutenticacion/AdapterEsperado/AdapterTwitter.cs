using AdapterAutenticacion.Actual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterAutenticacion.AdapterEsperado
{
    public class AdapterTwitter : IAutenticacion
    {
        private readonly AutenticacionTwitter _autenticacionTwitter;
        public AdapterTwitter(AutenticacionTwitter autenticacionTwitter)
        {
            _autenticacionTwitter = autenticacionTwitter;
        }

        public void Autenticar(string usuario, string contraseña)
        {
            _autenticacionTwitter.SignInWithTwitter( usuario, contraseña );
        }
    }
}
