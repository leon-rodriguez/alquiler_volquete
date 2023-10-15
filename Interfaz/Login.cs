using Entidades;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Interfaz
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro registro = new Registro();
            this.Hide();
            registro.Show();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string userName = txtUser.Text;
            string contraseña = txtContraseña.Text;
            Usuario user = new Usuario(userName, contraseña, "", Roles.usuario);

            if (user.IniciarSesion())
            {
                HomeVolquetes homeVolquetes = new HomeVolquetes(user);
                homeVolquetes.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No hay ninguna cuenta que coincida con estos datos, reviselos cuidadosamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}