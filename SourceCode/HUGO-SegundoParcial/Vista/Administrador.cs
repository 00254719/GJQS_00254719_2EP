using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HUGO_SegundoParcial.Modelo;

namespace HUGO_SegundoParcial
{
    public partial class Administrador : UserControl
    {
        public Administrador()
        {
            InitializeComponent();
        }
        private void ActualizarControles()
        {
            // Actualizar ComboBox
            cmbNombreNegEli.ValueMember = "idBusiness";
            cmbNombreNegEli.DisplayMember = "name";
            cmbNombreNegEli.DataSource = BusinessDAO.getLista();
            combNombreElim.ValueMember = "idUser";
            combNombreElim.DisplayMember = "username";
            combNombreElim.DataSource = UsuarioDAO.getLista();
            cmbVerNP.ValueMember = "idBusiness";
            cmbVerNP.DisplayMember = "name";
            cmbVerNP.DataSource = BusinessDAO.getLista();
            cmbPEli.ValueMember = "idProduct";
            cmbPEli.DisplayMember = "name";
            cmbPEli.DataSource = ProductDAO.getLista();
            actualizarDatagrid();
            actualizarDatagridOrdenes();

        }
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (textNombre.Text.Length >= 5)
                {
                    UsuarioDAO.crearNuevo(textNombre.Text, txtUsernameC.Text, rdioYes.Checked );
                    
                    MessageBox.Show("¡Usuario agregado exitosamente! Valores por defecto: " +
                                    "contrasena igual a username.", 
                        "Clase GUI 06", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    textNombre.Clear();
                    txtUsernameC.Clear();
                    actualizarDatagrid();
                    ActualizarControles();

                }
                else
                    MessageBox.Show("Favor digite un usuario (longitud minima, 5 caracteres)", 
                        "Clase GUI 06", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("El usuario que ha digitado, no se encuentra disponible.", 
                    "Clase GUI 06", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ActualizarControles();
            }
        }
        private void actualizarDatagrid()
               {
                   List<Usuarioclass> lista = UsuarioDAO.getLista();
            
                   // Tabla (data grid view)
                   dataGridView2.DataSource = null;
                   dataGridView2.DataSource = lista;            
               }
               
         private void actualizarDatagridNegocios()
                   {
                       List<Business> lista = BusinessDAO.getLista();
                       dataGridView1.DataSource = null;
                       dataGridView1.DataSource = lista;            
                   }
               
         private void actualizarDatagridProductos()
                   {
                       List<Product> lista = ProductDAO.getLista();
                       dataGridView3.DataSource = null;
                       dataGridView3.DataSource = lista;            
                   }

        private void Administrador_Load(object sender, EventArgs e)
        {
            actualizarDatagrid();
            actualizarDatagridNegocios();
            actualizarDatagridProductos();
            ActualizarControles();
            actualizarDatagridOrdenes();

        }

        private void btnAgregarNegocio_Click(object sender, EventArgs e)
        {
            try
                {
                    if (txtNegocio.Text.Length >= 2)
                            {
                                BusinessDAO.crearNuevoNegocio(txtNegocio.Text, txtDescripcion.Text );
                                
                                MessageBox.Show("¡Negocio agregado exitosamente!", 
                                    "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                                txtNegocio.Clear();
                                txtDescripcion.Clear();
                                ActualizarControles();
                               actualizarDatagridNegocios();


                            }
                            else
                                MessageBox.Show("Favor digite un negocio(longitud minima, 2 caracteres)", 
                                    "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("El Negocio que ha digitado, no se encuentra disponible.", 
                                "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            
                        }
                    }

        private void btnEliminarArt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar el Negocio " + cmbNombreNegEli.Text + "?",
                "GAME-SHOP JS-GD", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BusinessDAO.EliminarNegocio(Convert.ToInt32(cmbNombreNegEli.SelectedValue.ToString()));

                MessageBox.Show("¡Negocio eliminado exitosamente!",
                    "GAME-SHOP JS-GD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarControles();
                actualizarDatagridNegocios();

                                                

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar al usuario " + combNombreElim.Text + "?",
                "GAME-SHOP JS-GD", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UsuarioDAO.EliminarUsuario( Convert.ToInt32(combNombreElim.SelectedValue.ToString()) );

                MessageBox.Show("¡Usuario eliminado exitosamente!",
                    "GAME-SHOP JS-GD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                ActualizarControles();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                 try
                {
                    if (txtProducto.Text.Length >= 2)
                        {
                                ProductDAO.crearNuevoProducto(Convert.ToInt32(cmbVerNP.SelectedValue.ToString()), txtProducto.Text);
                                
                                MessageBox.Show("¡Producto agregado exitosamente!", 
                                    "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                txtProducto.Clear();
                                ActualizarControles();
                                actualizarDatagridProductos();

                            }
                            else
                                MessageBox.Show("Favor digite un producto(longitud minima, 2 caracteres)", 
                                    "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("El producto que ha digitado, no se encuentra disponible.", 
                                "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            
                        }        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar el producto " + cmbPEli.Text + "?",
            "GAME-SHOP JS-GD", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
              ProductDAO.EliminarProducto( Convert.ToInt32(cmbPEli.SelectedValue.ToString()) );
            
             MessageBox.Show("¡Producto eliminado exitosamente!",
             "GAME-SHOP JS-GD", MessageBoxButtons.OK, MessageBoxIcon.Information);
              ActualizarControles();
              actualizarDatagridProductos();
            
             }
        }
        private void actualizarDatagridOrdenes()
        {
            var dt = UsuarioDAO.AllUser();
            dataGridView4.DataSource = dt;
            var dtTable = ApporderDAO.Tabla();
            dataGridView1.DataSource = dtTable;

        }
    }
    }
