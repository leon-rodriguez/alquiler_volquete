using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class LineaUsuario : Form
    {
        private Usuario usuario;
        private Usuario usuarioLogueado;
        private HomeVolquetes padreForm;
        public LineaUsuario(Usuario usuario, Usuario usuarioLogeado, HomeVolquetes formPadre)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.usuarioLogueado = usuarioLogeado;
            this.padreForm = formPadre;
            Console.WriteLine("actual usuario id" + usuarioLogueado.Id);

            lblUsuario.Text = usuario.Username;
            lblContraseña.Text = usuario.Contraseña;
            lblMail.Text = usuario.Mail;
            lblRol.Text = usuario.Rol.ToString();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (usuarioLogueado is SuperUsuario superUsuario)
            {
                bool respuesta = superUsuario.EliminarUsuario(usuario.Id, usuarioLogueado.Id);
                if (!respuesta)
                {
                    MessageBox.Show("No puedes eliminarte a vos mismo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                padreForm.listarUsuarios();
            }
        }

        private void btnCambiarRol_Click(object sender, EventArgs e)
        {
            if (usuarioLogueado is SuperUsuario superUsuario)
            {
                bool respuesta = superUsuario.CambiarRoles(usuario.Rol, usuario.Id, superUsuario.Id);
                if (!respuesta)
                {
                    MessageBox.Show("No puedes cambiarte el rol a vos mismo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                padreForm.listarUsuarios();
            }
        }
    }
}
