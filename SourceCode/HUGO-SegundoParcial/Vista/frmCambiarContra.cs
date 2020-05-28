using System;
using System.Windows.Forms;
using HUGO_SegundoParcial.Modelo;

namespace HUGO_SegundoParcial
{
    public partial class frmCambiarContra : Form
    {
        public frmCambiarContra()
        {
            InitializeComponent();
        }
    
        private void frmCambiarContra_Load_1(object sender, EventArgs e)
        {
            // Actualizar ComboBox
            cmbUsuario.DataSource = null;
            cmbUsuario.ValueMember = "password";
            cmbUsuario.DisplayMember = "username";
            cmbUsuario.DataSource = UsuarioDAO.getLista();
            Usuarioclass u = (Usuarioclass) cmbUsuario.SelectedItem;

        }

        private void btnCambiarContra_Click_1(object sender, EventArgs e)
        {

            Usuarioclass u = (Usuarioclass) cmbUsuario.SelectedItem;
            bool actualIgual = txtActual.Text.Equals(cmbUsuario.SelectedValue.ToString());
            bool nuevaIgual = txtNueva.Text.Equals(txtRepetir.Text);
            bool nuevaValida = txtNueva.Text.Length > 0;

            if (actualIgual && nuevaIgual && nuevaValida)
            {
                try
                {
                    UsuarioDAO.actualizarContra( u.idUser, txtNueva.Text);
                    MessageBox.Show("¡Contraseña actualizada exitosamente!", 
                        "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("¡Contraseña no actualizada! Favor intente mas tarde.", 
                        "Clase GUI 05", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  this.Close();

                }
            }
            else
                MessageBox.Show("¡¡Favor verifique que los datos sean correctos!", 
                    "Clase GUI 05", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);        
        }


        private void btnCancelar_Click_2(object sender, EventArgs e)
        {
            
            Hide();
            Form1 unaVentana = new Form1();
            unaVentana.ShowDialog();

        }
    }
}