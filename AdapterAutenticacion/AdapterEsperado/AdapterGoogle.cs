using AdapterAutenticacion.Actual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterAutenticacion.AdapterEsperado
{
    public class AdapterGoogle : IAutenticacion
    {
        private readonly AutenticacionGoogle _autenticacionGoogle;
        public AdapterGoogle(AutenticacionGoogle autenticacionGoogle)
        {
            _autenticacionGoogle = autenticacionGoogle;
        }

        public void Autenticar(string usuario, string contraseña)
        {
            _autenticacionGoogle.SignInWithGoogle(usuario, contraseña);
        }
    }
}
