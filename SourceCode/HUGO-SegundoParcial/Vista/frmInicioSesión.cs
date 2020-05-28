using System;
using System.Windows.Forms;
using HUGO_SegundoParcial.Modelo;

namespace HUGO_SegundoParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void poblarControles()
        {
            // Actualizar ComboBox
            cmbUsuarioLogin.DataSource = null;
            cmbUsuarioLogin.ValueMember = "password";
            cmbUsuarioLogin.DisplayMember = "username";
            cmbUsuarioLogin.DataSource = UsuarioDAO.getLista();
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtContraLogin.Text.Equals(cmbUsuarioLogin.SelectedValue.ToString()))
            {

                Usuarioclass u = (Usuarioclass) cmbUsuarioLogin.SelectedItem;
                frmPrincipal ventana = new frmPrincipal(u);
                ventana.Show();
                this.Hide();
            }
            else
                MessageBox.Show("¡Contraseña incorrecta!", "GAME-SHOP JS-GD",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);        }

        private void btnCambiarContra_Click(object sender, EventArgs e)
        {
            Hide();
            frmCambiarContra unaVentana = new frmCambiarContra();
            unaVentana.ShowDialog();
            poblarControles();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            poblarControles();
        }
    }
}