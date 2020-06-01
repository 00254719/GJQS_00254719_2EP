namespace Preparcial.Modelo
{
    public class Usuario
    {
        public string IdUsuario { get; set; }

        public string Nombre { get; set; }
        
        //Correción: Nombre erroneo (contrasena en vez de contrasenia )
        public string Contrasena { get; set; }

        public bool Admin { get; set; }

        public Usuario(string idUsuario, string nombre, string contrasena, bool admin)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            Contrasena = contrasena;
            Admin = admin;
        }
    }
}
