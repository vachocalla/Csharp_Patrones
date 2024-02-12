using AdapterAutenticacion.Actual;
using AdapterAutenticacion.AdapterEsperado;

class Program
{
    static void Main(string[] args)
    {
        // Autenticación con Google
        IAutenticacion autenticacionGoogle = new AdapterGoogle(new AutenticacionGoogle());
        autenticacionGoogle.Autenticar("usuario_google", "contraseña_google");

        // Autenticación con Facebook
        IAutenticacion autenticacionFacebook = new AdapterFacebook(new AutenticacionFacebook());
        autenticacionFacebook.Autenticar("usuario_facebook", "contraseña_facebook");

        // Autenticación con Twitter
        IAutenticacion autenticacionTwitter = new AdapterTwitter(new AutenticacionTwitter());
        autenticacionTwitter.Autenticar("usuario_twitter", "contraseña_twitter");
    }
}