namespace HUGO_SegundoParcial.Modelo
{
    public class Usuarioclass
    {
        public int idUser { get; set; }
        public string fullName { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool userType { get; set; }

        public Usuarioclass()
        {
            idUser= 1;
            fullName = "";
            username = "";
            password = "";
            userType = true;
        }
    }
}