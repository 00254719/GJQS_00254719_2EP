using System;
using System.Windows.Forms;
using HUGO_SegundoParcial.Modelo;

namespace HUGO_SegundoParcial
{
    public partial class frmPrincipal : Form
    {
        private Usuarioclass user;
        private UserControl current = null;

        public frmPrincipal(Usuarioclass Puser)
        {
            InitializeComponent();
            user = Puser;
            current = new Administrador();
            tableLayoutPanel1.Controls.Add(current, 0, 1);
            current.Dock = DockStyle.Fill;

        }

        
        
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (user.userType)
            {
                tableLayoutPanel1.Controls.Remove(current);
                current = new Administrador();
                tableLayoutPanel1.Controls.Add(current, 0, 0);
                tableLayoutPanel1.SetColumnSpan(current,2);
                tableLayoutPanel1.SetRowSpan(current,2);
                current.Dock = DockStyle.Fill;

            }
            else
            {
                tableLayoutPanel1.Controls.Remove(current);
                current = new Appuser(user);
                tableLayoutPanel1.Controls.Add(current, 0, 0);
                tableLayoutPanel1.SetColumnSpan(current,2);
                tableLayoutPanel1.SetRowSpan(current,2);
                current.Dock = DockStyle.Fill;
            }        }
    }
}