using System;
using System.Collections.Generic;
using System.Data;

namespace HUGO_SegundoParcial.Modelo
{
    public static class AddressDAO
    {
        public  static List<Address> getListaG(int idUser)
        {
            string sql = String.Format(
                "SELECT ad.idAddress, ad.Address FROM ADDRESS ad WHERE idUser = {0}", idUser);

            DataTable dt = Conexion.ExecuteQuery(sql);

            List<Address> lista = new List<Address>();
            foreach (DataRow fila in dt.Rows)
            {
                Address u = new Address();
                u.idAddress = Convert.ToInt32(fila[0].ToString());
                u.address = fila[1].ToString();


                lista.Add(u);
            }

            return lista;
        }

        public static void crearNuevaDireccion( int idUser, string Address )
        {
            string sql = String.Format(
                "INSERT INTO ADDRESS( idUser, address) " +
                "VALUES ({0}, '{1}');", idUser, Address);
                
            Conexion.ExecuteNonQuery(sql);

        }
        public static void ModificarDireccion(int idAddress, string address)
        {
            string sql = String.Format(
                "UPDATE ADDRESS SET address='{1}' where idAddress={0};",
                idAddress, address);
            
            Conexion.ExecuteNonQuery(sql);
        }
        
        public static void EliminarDireccion(int idAddress)
                {
                    string sql = String.Format(
                        "DELETE FROM ADDRESS WHERE idAddress ={0};",
                        idAddress);
                    
                   Conexion.ExecuteNonQuery(sql);
                }
    
        public static DataTable DireccionUsuario(int idUser)
            {
                string sql = String.Format(
                    "SELECT ad.idAddress, ad.address FROM ADDRESS ad WHERE idUser = {0};",
                    idUser);
                DataTable dt = Conexion.ExecuteQuery(sql);
                return dt;
            }

        
    }
}