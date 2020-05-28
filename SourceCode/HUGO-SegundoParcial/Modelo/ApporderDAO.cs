using System;
using System.Collections.Generic;
using System.Data;

namespace HUGO_SegundoParcial.Modelo
{
    public static class ApporderDAO
    {
        public static List<APPORDER> getListaG(int idUser)
        {
            string sql = String.Format("SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, " +
                                       "ad.address FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au " +
                                       "WHERE ao.idProduct = pr.idProduct AND ao.idAddress = ad.idAddress " +
                                       "AND ad.idUser = au.idUser AND au.idUser = {0};", idUser);
            DataTable dt = Conexion.ExecuteQuery(sql);

            List<APPORDER> lista = new List<APPORDER>();
            foreach (DataRow fila in dt.Rows)
            {
                APPORDER a = new APPORDER();
                a.idOrder = Convert.ToInt32(fila[0].ToString());
                a.createDate = fila[1].ToString();
                a.productname = fila[2].ToString();
                a.fullname = fila[2].ToString();
                lista.Add(a);
            }

            return lista;

        }

        public static void EliminarOrden(int idOrder)
        {
            string sql = String.Format(
                "DELETE FROM APPORDER WHERE idOrder ={0};",
                idOrder);
            Conexion.ExecuteNonQuery(sql);
            
        }
        
        public static DataTable Tabla()
                {
                    string sql =String.Format("SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, "+
                                              "ad.address FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au "+
                                              "WHERE ao.idProduct = pr.idProduct AND ao.idAddress = ad.idAddress " +
                                              "AND ad.idUser = au.idUser ");
                    DataTable dt = Conexion.ExecuteQuery(sql);
                    return dt;
                }
                
     public static DataTable OrdenUsuario(int idUser)
             {
                 string sql =String.Format("SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, "+
                                           "ad.address FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au "+
                                           "WHERE ao.idProduct = pr.idProduct AND ao.idAddress = ad.idAddress "+
                                           "AND ad.idUser = au.idUser AND au.idUser = {0};", idUser);
                 DataTable dt = Conexion.ExecuteQuery(sql);
                 return dt;
             }           
 
     public static void IngresarOrder(int idProduct, int idAddress)
             {
                 string sql = String.Format(
                     "INSERT INTO APPORDER(createDate, idProduct, idAddress) VALUES ('{0}', {1}, {2});", 
                     DateTime.Now.ToString("yyyy-MM-dd"), idProduct, idAddress);
                 Conexion.ExecuteNonQuery(sql);
             }
    }
}