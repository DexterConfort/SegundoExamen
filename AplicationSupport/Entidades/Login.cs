namespace Entidades
{
    public class Login
    {
        public string Usuario { get; set; }
        public string Contrasena { get; set; }

        public Login()
        {
        }
        public Login(string usuario, string contrasena)
        {
            Usuario = usuario;
            Contrasena = contrasena;
        }

    }
}
