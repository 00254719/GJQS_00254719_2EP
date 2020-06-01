using System;
using System.Data;
using System.Windows.Forms;

namespace Preparcial.Controlador
{
    public static class ControladorPedido
    {
        public static DataTable GetPedidosUsuarioTable(string id)
        {
            DataTable pedidos = null;

            try
            {
                //Correción: Un enter para que no se saliera de la linea
                pedidos = ConexionBD.EjecutarConsulta("SELECT p.idPedido, i.nombreArt, p.cantidad, i.precio, " +
                                                      "(i.precio * p.cantidad) AS total" +
                                            " FROM PEDIDO p, INVENTARIO i, USUARIO u" +
                                            " WHERE p.idArticulo = i.idArticulo" +
                                            " AND p.idUsuario = u.idUsuario" +
                                            $" AND u.idUsuario = {id}");
            }
            //Correción: No se usa ex en ningún momento
            catch (Exception )
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            return pedidos;
        }

        public static DataTable GetPedidosTable()
        {
            DataTable pedidos = null;

            try
            {
                //Correción: Un enter para que no se saliera de la linea
                pedidos = ConexionBD.EjecutarConsulta("SELECT p.idPedido, i.nombreArt, p.cantidad, i.precio, " +
                                                      "(i.precio * p.cantidad) AS total" +
                                                      " FROM PEDIDO p, INVENTARIO i, USUARIO u" +
                                                      " WHERE p.idArticulo = i.idArticulo" +
                                                      " AND p.idUsuario = u.idUsuario");
            }
            
            //Correción: No se usa ex en ningún momento
            catch (Exception )
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            return pedidos;
        }

        public static void HacerPedido(string idUsuario, string idArticulo, string cantidad)
        {
            try
            {
                ConexionBD.EjecutarComando("INSERT INTO PEDIDO(idUsuario, idArticulo, cantidad) " +
                    $"VALUES({idUsuario}, {idArticulo}, {cantidad})");
            }
            
            //Correción: No se usa ex en ningún momento
            catch (Exception )
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}
