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
    public partial class HomeVolquetes : Form
    {
        private Usuario usuarioActual;
        private TiposVolquete seleccionUsuarioPantallaInicio;
        private Form formActivo;
        public HomeVolquetes(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioActual = usuario;
            abrirFormulario(new PrimeraPantallaVolquetes());
        }

        /*private void personalizarDiseño()
        {
            abrirFormularioHijo(new PrimeraPantallaVolquetes());
            panelVolquetesSubmenu.Visible = false;
            panelCuentaSubmenu.Visible = false;
            if (usuarioActual.Rol == Roles.administrador)
            {
                btnAdministrarUsuarios.Visible = false;
                panelCuentaSubmenu.Height = panelCuentaSubmenu.Height - 45;

                btnAñadirVolquete.Visible = false;
                panelVolquetesSubmenu.Height = panelVolquetesSubmenu.Height - 45;

            }
        }*/

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
            Console.WriteLine(this.usuarioActual.ToString());
            mostrarSubMenu(panelVolquetesSubmenu);
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelCuentaSubmenu);
        }

        public void abrirFormulario(Form formAbrir)
        {
            if (formActivo != null)
            {
                formActivo.Close();
            }
            formActivo = formAbrir;
            formAbrir.MdiParent = this;
            formAbrir.Show();
            formAbrir.Location = new Point(0, 0);
        }
        private void btnAlquileresUsuario_Click(object sender, EventArgs e)
        {
            //abrirFormularioHijo(new AlquileresUsuario());
            Console.WriteLine("gdiojhfodsis");
            //abrirFormularioHijo(new PrimeraPantallaVolquetes());

        }

        private void btnAdministrarUsuarios_Click(object sender, EventArgs e)
        {
            //abrirFormularioHijo(new AdministradorUsuarios());
            //abrirFormularioHijo(new PrimeraPantallaVolquetes());

        }

        private void btnAñadirVolquete_Click(object sender, EventArgs e)
        {
            abrirFormulario(new AñadirVolquete());
        }

        private void btnVerConstruccion_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Volquetes(TiposVolquete.construccion));

        }

        private void btnVerVolquetesResiduos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Volquetes(TiposVolquete.residuos));
        }
    }
}
