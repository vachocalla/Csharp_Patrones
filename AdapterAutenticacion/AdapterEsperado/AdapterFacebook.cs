using AdapterAutenticacion.Actual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterAutenticacion.AdapterEsperado
{
    public class AdapterFacebook : IAutenticacion
    {
        private readonly AutenticacionFacebook _autenticacionFacebook;
        public AdapterFacebook(AutenticacionFacebook autenticacionFacebook)
        {
            _autenticacionFacebook = autenticacionFacebook;
        }

        public void Autenticar(string usuario, string contraseña)
        {
            _autenticacionFacebook.SignInWithFacebook(usuario, contraseña);
        }
    }
}
