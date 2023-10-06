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
    public partial class HomeVolquetes : Form
    {
        public HomeVolquetes()
        {
            InitializeComponent();
            personalizarDiseño();
        }

        private void personalizarDiseño()
        {
            panelVolquetesSubmenu.Visible = false;
            panelCuentaSubmenu.Visible = false;
        }

        private void ocultarSubmenu()
        {
            if (panelVolquetesSubmenu.Visible == true)
            {
                panelVolquetesSubmenu.Visible = false;
            }
            if (panelCuentaSubmenu.Visible == true)
            {
                panelCuentaSubmenu.Visible = false;
            }
        }

        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void btnVolquetes_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelVolquetesSubmenu);
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelCuentaSubmenu);
        }
        private Form formularioActivo = null;
        private void abrirFormularioHijo(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                Console.WriteLine("gola");
                formularioActivo.Close();
            }
                formularioActivo = formularioHijo;
                formularioHijo.TopLevel = false;
                formularioHijo.FormBorderStyle = FormBorderStyle.None;
                formularioHijo.Dock = DockStyle.Fill;
                panelHijoInicio.Controls.Add(formularioHijo);
                panelHijoInicio.Tag = formularioHijo;
                formularioHijo.BringToFront();
                formularioHijo.Show();
        }

        private void btnAlquileresUsuario_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new AlquileresUsuario());

        }

        private void btnAdministrarUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new AdministradorUsuarios());
        }
    }
}
