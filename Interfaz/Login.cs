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
            //crearSuperUsuario();
        }

        /*private void crearSuperUsuario()
        {
            List<Usuario> listaUsuarios = Serializadora.LeerXMLUsuario(@"..\..\..\..\DBxml\usuariosDB");
            foreach (Usuario item in listaUsuarios)
            {
                if (item.Username == "a")
                {
                    item.Rol = Roles.superUsuario;
                }
            }
            Serializadora.EscribirXMLUsuarios(@"..\..\..\..\DBxml\usuariosDB", listaUsuarios);
        }*/

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
            Usuario usuarioProvicional = new Usuario(userName, contraseña, "", Roles.usuario);

            if (usuarioProvicional.IniciarSesion())
            {
                if (usuarioProvicional.Rol == Roles.superUsuario)
                {
                    SuperUsuario usuarioSuper = new SuperUsuario(userName, contraseña, "", Roles.superUsuario);
                    usuarioSuper.IniciarSesion();
                    HomeVolquetes homeVolquetes = new HomeVolquetes(usuarioSuper);
                    homeVolquetes.Show();
                    this.Hide();
                }
                else if (usuarioProvicional.Rol == Roles.administrador)
                {
                    Administrador usuarioAdmin = new Administrador(userName, contraseña, "", Roles.administrador);
                    usuarioAdmin.IniciarSesion();
                    HomeVolquetes homeVolquetes = new HomeVolquetes(usuarioAdmin);
                    homeVolquetes.Show();
                    this.Hide();
                }
                else
                {
                    Administrador usuarioComun = new Administrador(userName, contraseña, "", Roles.usuario);
                    HomeVolquetes homeVolquetes = new HomeVolquetes(usuarioComun);
                    homeVolquetes.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna cuenta que coincida con estos datos, reviselos cuidadosamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}