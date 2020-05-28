namespace HUGO_SegundoParcial.Modelo
{
    public class APPORDER
    {
        public int idOrder { get; set; }
        public string createDate { get; set; }
        public string productname { get; set; } 
        public string fullname { get; set; }

        public APPORDER()
        {
            idOrder = 1;
            createDate = "";
            productname= "";
            fullname = "";
        }
    }
}