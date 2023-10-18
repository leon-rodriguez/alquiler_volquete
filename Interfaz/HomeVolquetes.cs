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
            abrirFormulario(new PrimeraPantallaVolquetes(this, formActivo, usuarioActual, panelMenuLateral));
            aplicarVisibilidades();
        }

        #region AplicarEstilos
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

        public void abrirFormulario(Form formAbrir)
        {
            if (formActivo != null)
            {
                formActivo.Close();
            }
            foreach (Control control in this.Controls)
            {
                if (control is VolqueteCard || control is LineaUsuario)
                {
                    control.Dispose(); // Elimina el control si es una instancia de FormVolquete
                }
            }
            formActivo = formAbrir;
            formAbrir.MdiParent = this;
            formAbrir.Show();
            formAbrir.Location = new Point(0, 0);
        }

        private void aplicarVisibilidades()
        {
            if (usuarioActual is UsuarioComun)
            {
                btnAdministrarUsuarios.Visible = false;
                btnAñadirVolquete.Visible = false;

                panelVolquetesSubmenu.Height -= btnVolquetes.Height;
                panelCuentaSubmenu.Height -= btnAlquileresUsuario.Height;
            }
            if (usuarioActual.Rol == Roles.administrador)
            {
                btnAdministrarUsuarios.Visible = false;

                panelCuentaSubmenu.Height -= btnAlquileresUsuario.Height;
            }
        }
        #endregion

        #region AccionesBotones
        private void btnVolquetes_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelVolquetesSubmenu);
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelCuentaSubmenu);
        }
        private void btnAdministrarUsuarios_Click(object sender, EventArgs e)
        {
            AccionesForm.listarUsuarios(formActivo, this, usuarioActual, panelMenuLateral);
        }

        private void btnAñadirVolquete_Click(object sender, EventArgs e)
        {
            abrirFormulario(new AñadirVolquete(usuarioActual));
        }


        private void btnVerConstruccion_Click(object sender, EventArgs e)
        {
            AccionesForm.rellenarListBox(TiposVolquete.construccion, false, formActivo, this, usuarioActual, panelMenuLateral);
        }

        private void btnVerVolquetesResiduos_Click(object sender, EventArgs e)
        {
            AccionesForm.rellenarListBox(TiposVolquete.residuos, false, formActivo, this, usuarioActual, panelMenuLateral);
        }

        private void btnAlquileresUsuario_Click(object sender, EventArgs e)
        {
            AccionesForm.rellenarListBoxAdministrar(true, formActivo, this, usuarioActual, panelMenuLateral);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
        #endregion 
    }
}
