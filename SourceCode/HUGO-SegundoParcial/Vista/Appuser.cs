using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HUGO_SegundoParcial.Modelo;

namespace HUGO_SegundoParcial
{
    public partial class Appuser : UserControl
    {
    
         private Usuarioclass appuser;
        public Appuser(Usuarioclass pAppuser)
        {
            InitializeComponent();
            appuser = pAppuser; 
        }
            private void ActualizarControles2()
        {
            
            cmbDireccion.ValueMember = "idUser";
            cmbDireccion.DisplayMember = "address";
            cmbDireccion.DataSource = AddressDAO.getListaG(appuser.idUser);
            cmbEliminarD.ValueMember = "idUser";
            cmbEliminarD.DisplayMember = "address";
            cmbEliminarD.DataSource = AddressDAO.getListaG(appuser.idUser);
            cmbEliPro.ValueMember = "idOrder";
           cmbEliPro.DisplayMember = "productname";
           cmbEliPro.DataSource = ApporderDAO.getListaG(appuser.idUser);
           comboBox1.ValueMember = "idBusiness";
           comboBox1.DisplayMember = "name";
           comboBox1.DataSource = BusinessDAO.getLista();
          
           comboBox3.ValueMember = "idAddress";
           comboBox3.DisplayMember = "Address";
           comboBox3.DataSource = AddressDAO.getListaG(appuser.idUser);
           actualizarDatagrid3();
           
                        
        }
        private void btnAgregarDireccion_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDireccion.Text.Length >= 5)
                {
                    AddressDAO.crearNuevaDireccion( appuser.idUser,txtDireccion.Text );
                    
                    MessageBox.Show("¡Direccionm agregado exitosamente!", 
                        "Clase GUI 06", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    txtDireccion.Clear();
                    ActualizarControles2();
                }
                else
                    MessageBox.Show("Favor digite un usuario (longitud minima, 5 caracteres)", 
                        "Clase GUI 06", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("El usuario que ha digitado, no se encuentra disponible.", 
                    "Clase GUI 06", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }


        private void btnModificarD_Click(object sender, EventArgs e)
        {
            
                AddressDAO.ModificarDireccion(Convert.ToInt32(cmbDireccion.SelectedValue.ToString()), txtDireccion.Text);

                MessageBox.Show("¡Usuario actualizado exitosamente!",
                    "GAME-SHOP JS-GD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarControles2();

            }


        private void btnEliminarD_Click(object sender, EventArgs e)
        {
            AddressDAO.EliminarDireccion(Convert.ToInt32(cmbEliminarD.SelectedValue.ToString()));
            MessageBox.Show("¡Direccion eliminada exitosamente!",
                                "GAME-SHOP JS-GD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ActualizarControles2();

        }

        private void Appuser_Load(object sender, EventArgs e)
        {
            
            actualizarDatagrid3();
          ActualizarControles2();

        }
        
        private void btnAgregarNegocio_Click(object sender, EventArgs e)
        {
            ApporderDAO.IngresarOrder(Convert.ToInt32(comboBox2.SelectedValue.ToString()),
                            Convert.ToInt32(comboBox3.SelectedValue.ToString()));
                            MessageBox.Show("¡Orden realizada exitosamente!",
                            "GAME-SHOP JS-GD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             ActualizarControles2();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.ValueMember = "idProduct";
            comboBox2.DisplayMember = "name";
            comboBox2.DataSource = ProductDAO.getListaP(Convert.ToInt32(comboBox1.SelectedValue.ToString()));
        }

        private void btnEliminarArt_Click(object sender, EventArgs e)
        {
                ApporderDAO.EliminarOrden(Convert.ToInt32(cmbEliPro.SelectedValue.ToString()));
                    MessageBox.Show("¡Orden eliminada exitosamente!",
                                "GAME-SHOP JS-GD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarControles2();
        }
        
         private void actualizarDatagrid3()
                {
                    var dt = AddressDAO.DireccionUsuario(appuser.idUser);
                    dataGridView2.DataSource = dt;
                    var dt1 = ApporderDAO.OrdenUsuario(appuser.idUser);
                    dataGridView1.DataSource = dt1;
                }
    }
    }
