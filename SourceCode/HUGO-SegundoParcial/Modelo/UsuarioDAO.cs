using System;
using System.Collections.Generic;
using System.Data;

namespace HUGO_SegundoParcial.Modelo
{
    public static class UsuarioDAO
    {
        public static List<Usuarioclass> getLista()
        {
            string sql = "SELECT * FROM APPUSER";

            DataTable dt = Conexion.ExecuteQuery(sql);

            List<Usuarioclass> lista = new List<Usuarioclass>();
            foreach (DataRow fila in dt.Rows)
            {
                Usuarioclass u = new Usuarioclass();
                u.idUser = Convert.ToInt32(fila[0].ToString());
                u.fullName = fila[1].ToString();
                u.username = fila[2].ToString();
                u.password = fila[3].ToString();
                u.userType = Convert.ToBoolean(fila[4].ToString());

                lista.Add(u);
            }
            return lista;
        }
        public static void actualizarContra(int idUser, string nuevaContra)
        {
            string sql = String.Format(
                "UPDATE APPUSER SET password ='{0}' WHERE idUser ='{1}';",
                nuevaContra, idUser);
            
            Conexion.ExecuteNonQuery(sql);
        }
        
          public static void crearNuevo(string fullName, string username,bool userType)
                      {
                        string sql = String.Format(
                         "INSERT INTO APPUSER(fullname, username, password, userType)" +
                          " VALUES ('{0}', '{1}' ,'{2}', " + userType + " );",
                                    fullName,username,username);
                                
                                Conexion.ExecuteNonQuery(sql);
                       }
          
          public static void EliminarUsuario (int idUser)
          {
              string sql = String.Format(
                  "delete from APPUSER where idUser ='{0}'; ", 
                  idUser );
                     
              Conexion.ExecuteNonQuery(sql);
          }  
          
          public static DataTable AllUser()
          {
              string sql ="SELECT * FROM APPUSER";
              DataTable dt = Conexion.ExecuteQuery(sql);
              return dt;
          }
           
    }
}