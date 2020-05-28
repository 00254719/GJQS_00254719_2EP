using System;
using System.Data;
using System.Collections.Generic;

namespace HUGO_SegundoParcial.Modelo
{
    public static class BusinessDAO
    {
     public static List<Business> getLista()
            {
                string sql = "SELECT * FROM BUSINESS";
    
                DataTable dt = Conexion.ExecuteQuery(sql);
    
                List<Business> lista = new List<Business>();
                foreach (DataRow fila in dt.Rows)
                {
                    Business u = new Business();
                    u.idBusiness = Convert.ToInt32(fila[0].ToString());
                    u.name = fila[1].ToString();
                    u.description = fila[2].ToString();
                   
                    lista.Add(u);
                }
                return lista;
            }
             public static void crearNuevoNegocio(string name, string description)
                      {
                        string sql = String.Format(
                         "INSERT INTO BUSINESS( name, description)" +
                          " VALUES ('{0}', '{1}' );",
                                    name, description);
                                
                                Conexion.ExecuteNonQuery(sql);
                       }
             
             public static void EliminarNegocio( int idBusiness)
             {
                 string sql = String.Format(
                     "delete from BUSINESS where idBusiness ='{0}';",
                     idBusiness);
            
                 Conexion.ExecuteNonQuery(sql);
             }
        
    }
}