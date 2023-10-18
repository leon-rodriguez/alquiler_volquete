using Entidades;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        //si los datos son validos se crea por defecto un usuario comun y se agrega a la db
        private void btnRegistrarseRegistro_Click(object sender, EventArgs e)
        {
            string userName = txtUserRegistro.Text;
            string contraseña1 = txtContraseñaRegistro.Text;
            string contraseña2 = txtConfirmarContraseña.Text;
            string mail = txtMailRegistro.Text;

            UsuarioComun usuario = new UsuarioComun(userName, contraseña2, mail, Roles.usuario);

            if (usuario.ValidarRegistro(contraseña1) && Serializadora.AgregarUsuario(usuario))
            {
                usuario.AsignarId();
                HomeVolquetes homeVolquetes = new HomeVolquetes(usuario);
                homeVolquetes.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Alguno de los datos es incorrecto, por favor revisalos cuidadosamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
