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
            abrirFormulario(new PrimeraPantallaVolquetes(this, formActivo));
            aplicarVisibilidades();
        }

        public bool rellenarListBox(TiposVolquete tipoElegido, bool esParaAdministrar)
        {
            if (formActivo != null)
            {
                formActivo.Close();
            }

            foreach (Form item in this.MdiChildren)
            {
                if (item is VolqueteCard || item is LineaUsuario)
                {
                    item.Dispose();
                }
            }
            bool hayVolquetesDeMismoTipo = false;

            List<Volquete> listaVolquetes = Serializadora.LeerXMLVolquete(@"..\..\..\..\DBxml\volquetesDB");
            if (listaVolquetes.Count == 0)
            {
                mostrarMensajeNoDisponible("No hay volquetes disponibles\nEspere a que se reponga el stock\nMuchas Gracias.");
                return hayVolquetesDeMismoTipo;
            }
            int y = 10;
            int x = 10;
            bool flag = true;
            foreach (Volquete volquete in listaVolquetes)
            {
                if (volquete.Tipo == tipoElegido)
                {
                    hayVolquetesDeMismoTipo = true;
                    VolqueteCard volqueteCard = new VolqueteCard(volquete, this, usuarioActual.Id, esParaAdministrar);
                    volqueteCard.MdiParent = this;
                    volqueteCard.Show();
                    if (x + (volqueteCard.Size.Width) * 2 > this.Size.Width - panelMenuLateral.Size.Width)
                    {
                        y += volqueteCard.Size.Height + 20;
                        x = 10;
                    }
                    else
                    {
                        if (!flag)
                        {
                            x += volqueteCard.Size.Width + 10;
                        }
                        flag = false;
                    }
                    volqueteCard.Location = new System.Drawing.Point(x, y);
                }

            }
            if (!hayVolquetesDeMismoTipo)
            {
                mostrarMensajeNoDisponible("No hay volquetes disponibles\nEspere a que se reponga el stock\nMuchas Gracias.");
            }
            return hayVolquetesDeMismoTipo;
        }

        public bool listarUsuarios()
        {
            if (formActivo != null)
            {
                formActivo.Close();
            }

            foreach (Form item in this.MdiChildren)
            {
                if (item is LineaUsuario || item is VolqueteCard)
                {
                    item.Dispose();
                }
            }

            List<Usuario> listaUsuarios = Serializadora.LeerXMLUsuario(@"..\..\..\..\DBxml\usuariosDB");
            if (listaUsuarios.Count == 0)
            {
                mostrarMensajeNoDisponible("No existen usuarios :C");
                return false;
            }
            int y = 0;
            int x = 0;
            int indicadorAlternante = 0;

            foreach (Usuario usuario in listaUsuarios)
            {
                LineaUsuario lineaUsuario = new LineaUsuario(usuario, usuarioActual, this);
                lineaUsuario.MdiParent = this;
                lineaUsuario.Show();
                lineaUsuario.Location = new System.Drawing.Point(x, y);
                lineaUsuario.Width = this.Size.Width - panelMenuLateral.Size.Width - 20;

                lineaUsuario.BackColor = Color.FromArgb(235, 235, 235);
                if (indicadorAlternante % 2 == 0)
                {
                    lineaUsuario.BackColor = Color.White;
                }

                y += lineaUsuario.Size.Height;
                indicadorAlternante++;
            }
            return true;
        }
        public bool rellenarListBoxAdministrar(bool esParaAdministrar)
        {
            if (formActivo != null)
            {
                formActivo.Close();
            }

            foreach (Form item in this.MdiChildren)
            {
                if (item is VolqueteCard || item is LineaUsuario)
                {
                    item.Dispose();
                }
            }

            List<Volquete> listaVolquetes = Serializadora.LeerXMLVolquete(@"..\..\..\..\DBxml\volquetesDB");
            if (listaVolquetes.Count == 0)
            {
                mostrarMensajeNoDisponible("No tienes reservas");
                return false;
            }
            int y = 10;
            int x = 10;
            bool flag = true;
            bool hayVolquetesReservados = false;
            foreach (Volquete volquete in listaVolquetes)
            {
                if (volquete.IdUsuarioReserva == usuarioActual.Id)
                {
                    hayVolquetesReservados = true;
                    VolqueteCard volqueteCard = new VolqueteCard(volquete, this, usuarioActual.Id, esParaAdministrar);
                    volqueteCard.MdiParent = this;
                    volqueteCard.Show();
                    if (x + (volqueteCard.Size.Width) * 2 > this.Size.Width - panelMenuLateral.Size.Width)
                    {
                        y += volqueteCard.Size.Height + 20;
                        x = 10;
                    }
                    else
                    {
                        if (!flag)
                        {
                            x += volqueteCard.Size.Width + 10;
                        }
                        flag = false;
                    }
                    volqueteCard.Location = new System.Drawing.Point(x, y);
                }

            }
            if (!hayVolquetesReservados)
            {
                mostrarMensajeNoDisponible("No tienes reservas");
            }
            return hayVolquetesReservados;
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
            if (usuarioActual.Rol == Roles.usuario)
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

        private void mostrarMensajeNoDisponible(string mensajeAMostrar)
        {
            MensajeNoDisponible mensaje = new MensajeNoDisponible(mensajeAMostrar);
            abrirFormulario(mensaje);
            int mitadAncho = ((this.Size.Width - panelMenuLateral.Size.Width) / 2) - (mensaje.Size.Width / 2);
            int mitadAlto = ((this.Size.Height) / 2) - (mensaje.Size.Height / 2);
            mensaje.Location = new Point(mitadAncho, mitadAlto);
        }

        private void btnAdministrarUsuarios_Click(object sender, EventArgs e)
        {
            listarUsuarios();
        }

        private void btnAñadirVolquete_Click(object sender, EventArgs e)
        {
            abrirFormulario(new AñadirVolquete());

        }


        private void btnVerConstruccion_Click(object sender, EventArgs e)
        {
            rellenarListBox(TiposVolquete.construccion, false);
        }

        private void btnVerVolquetesResiduos_Click(object sender, EventArgs e)
        {
            rellenarListBox(TiposVolquete.residuos, false);
        }

        private void btnAlquileresUsuario_Click(object sender, EventArgs e)
        {
            rellenarListBoxAdministrar(true);
        }
    }
}
