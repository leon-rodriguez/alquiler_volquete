using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
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
            int index = 0;
            foreach (Usuario usuarioEncontrado in listaUsuarios)
            {
                if (usuarioEncontrado.Username == "a")
                {
                    SuperUsuario superUsuario = new SuperUsuario(usuarioEncontrado.Username, usuarioEncontrado.Contraseña, usuarioEncontrado.Mail, Roles.superUsuario);
                    superUsuario.Id = usuarioEncontrado.Id;
                    listaUsuarios.RemoveAt(index);
                    listaUsuarios.Insert(index, superUsuario);
                    break;
                }
                index++;    
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
            Usuario usuarioProvicional = new UsuarioComun(userName, contraseña, "", Roles.usuario);

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
                    UsuarioComun usuarioComun = new UsuarioComun(userName, contraseña, "", Roles.usuario);
                    usuarioComun.IniciarSesion();
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

        private void btnAutoCompletar_Click(object sender, EventArgs e)
        {
            txtUser.Text = autocmpletar();
        }

        private string autocmpletar()
        {
            string txtInputUser = txtUser.Text;
            string respuesta = "";
            if (txtInputUser.Length == 0)
            {
                return respuesta;
            }
            List<Usuario> listaUsuarios = Serializadora.LeerXMLUsuario(@"..\..\..\..\DBxml\usuariosDB");
            bool huboCoincidencia = false;
            foreach (Usuario usuario in listaUsuarios)
            {
                if (usuario.Username.StartsWith(txtInputUser))
                {
                    respuesta = usuario.Username;
                    huboCoincidencia = true;
                    break;
                }
            }

            if (!huboCoincidencia) 
            {
                respuesta = txtInputUser;
            }
            return respuesta;

        }
    }
}