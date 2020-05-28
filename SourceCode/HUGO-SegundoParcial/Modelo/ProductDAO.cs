using System;
using System.Collections.Generic;
using System.Data;

namespace HUGO_SegundoParcial.Modelo
{
    public static class ProductDAO
    {
         public static List<Product> getLista()
                    {
                        string sql = "SELECT * FROM PRODUCT";
            
                        DataTable dt = Conexion.ExecuteQuery(sql);
            
                        List<Product> lista = new List<Product>();
                        foreach (DataRow fila in dt.Rows)
                        {
                            Product u = new Product();
                            u.idProduct = Convert.ToInt32(fila[0].ToString());
                            u.idBusiness = Convert.ToInt32(fila[1].ToString());
                            u.name = fila[2].ToString();
                           
                            lista.Add(u);
                        }
                        return lista;
                    }
         public static List<Product> getListaP(int idBusiness)
         {
             string sql = String.Format(
                 "SELECT p.idProduct, p.name FROM PRODUCT p WHERE idBusiness = {0};",
                 idBusiness);
             DataTable dt = Conexion.ExecuteQuery(sql);
            
             List<Product> lista = new List<Product>();
             foreach (DataRow fila in dt.Rows)
             {
                 Product u = new Product();
                 u.idProduct = Convert.ToInt32(fila[0].ToString());
                 u.name = fila[1].ToString();
                 
                           
                 lista.Add(u);
             }
             return lista;
         }
         public static void crearNuevoProducto(int idBusiness, string name)
         {
             string sql = String.Format(
                 "INSERT INTO PRODUCT (idBusiness, name)" +
                 " VALUES ('{0}','{1}' );",
                 idBusiness, name);
                    
             Conexion.ExecuteNonQuery(sql);
         }   
         public static void EliminarProducto( int idProduct)
         {
             string sql = String.Format(
                 "delete from PRODUCT where idProduct ='{0}';",
                 idProduct);
            
             Conexion.ExecuteNonQuery(sql);
         }
    }
}