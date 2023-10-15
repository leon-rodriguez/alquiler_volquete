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

        private void btnRegistrarseRegistro_Click(object sender, EventArgs e)
        {
            string userName = txtUserRegistro.Text;
            string contraseña1 = txtContraseñaRegistro.Text;
            string contraseña2 = txtConfirmarContraseña.Text;
            string mail = txtMailRegistro.Text;

            Usuario usuario = new Usuario(userName, contraseña2, mail, Roles.usuario);

            if (usuario.ValidarRegistro(contraseña1))
            {
                usuario.AsignarId();
                Serializadora.AgregarUsuario(usuario);
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

        private void txtUserRegistro_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void txtContraseñaRegistro_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
