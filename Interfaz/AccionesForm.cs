using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    internal class AccionesForm
    {
        private static void limpiarPantalla(HomeVolquetes formPadre)
        {
            foreach (Form item in formPadre.MdiChildren)
            {
                if (item is VolqueteCard || item is LineaUsuario || item is MensajeNoDisponible || item is PrimeraPantallaVolquetes)
                {
                    item.Dispose();
                }
            }
        }

        //rellena volquetes en el home
        public static bool rellenarListBox(TiposVolquete tipoElegido, bool esParaAdministrar, Form formActivo, HomeVolquetes formPadre, Usuario usuarioActual, Panel panelMenuLateral)
        {
            Console.WriteLine("form activo" + formActivo);
            if (formActivo != null)
            {
                formActivo.Hide();
            }

            limpiarPantalla(formPadre);
            bool hayVolquetesDeMismoTipo = false;

            List<Volquete> listaVolquetes = Serializadora.LeerXMLVolquete(RutasArchivos.volqueteDB);
            if (listaVolquetes.Count == 0)
            {
                mostrarMensajeNoDisponible("No hay volquetes disponibles\nEspere a que se reponga el stock\nMuchas Gracias.", formPadre, formActivo, panelMenuLateral);
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
                    VolqueteCard volqueteCard = new VolqueteCard(volquete, formPadre, usuarioActual.Id, esParaAdministrar, usuarioActual, formActivo, panelMenuLateral);
                    volqueteCard.MdiParent = formPadre;
                    volqueteCard.Show();
                    if (x + (volqueteCard.Size.Width) * 2 > formPadre.Size.Width - panelMenuLateral.Size.Width)
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
                mostrarMensajeNoDisponible("No hay volquetes disponibles\nEspere a que se reponga el stock\nMuchas Gracias.", formPadre, formActivo, panelMenuLateral);
            }
            return hayVolquetesDeMismoTipo;
        }

        //muestra mensajes dependiendo de la situacion
        public static void mostrarMensajeNoDisponible(string mensajeAMostrar, HomeVolquetes padreForm, Form formActivo, Panel panelMenuLateral)
        {
            MensajeNoDisponible mensaje = new MensajeNoDisponible(mensajeAMostrar);
            abrirFormulario(mensaje, padreForm, formActivo);
            int mitadAncho = ((padreForm.Size.Width - panelMenuLateral.Size.Width) / 2) - (mensaje.Size.Width / 2);
            int mitadAlto = ((padreForm.Size.Height) / 2) - (mensaje.Size.Height / 2);
            mensaje.Location = new Point(mitadAncho, mitadAlto);
        }

        //maneja la apretura de formularios
        public static void abrirFormulario(Form formAbrir, HomeVolquetes formPadre, Form formActivo)
        {
            if (formActivo != null)
            {
                formActivo.Close();
            }

            limpiarPantalla(formPadre);

            formActivo = formAbrir;
            formAbrir.MdiParent = formPadre;
            formAbrir.Show();
            formAbrir.Location = new Point(0, 0);
        }

        //rellena los volquetes en tus alquieleres
        public static bool rellenarListBoxAdministrar(bool esParaAdministrar, Form formActivo, HomeVolquetes formPadre, Usuario usuarioActual, Panel panelMenuLateral)
        {
            if (formActivo != null)
            {
                formActivo.Close();
            }

            limpiarPantalla(formPadre);


            List<Volquete> listaVolquetes = Serializadora.LeerXMLVolquete(RutasArchivos.volqueteDB);
            if (listaVolquetes.Count == 0)
            {
                mostrarMensajeNoDisponible("No tienes reservas", formPadre, formActivo, panelMenuLateral);
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
                    VolqueteCard volqueteCard = new VolqueteCard(volquete, formPadre, usuarioActual.Id, esParaAdministrar, usuarioActual, formActivo, panelMenuLateral);
                    volqueteCard.MdiParent = formPadre;
                    volqueteCard.Show();
                    if (x + (volqueteCard.Size.Width) * 2 > formPadre.Size.Width - panelMenuLateral.Size.Width)
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
                mostrarMensajeNoDisponible("No tienes reservas", formPadre, formActivo, panelMenuLateral);
            }
            return hayVolquetesReservados;
        }

        //lista cada linea de usuarios en el admin de usuarios
        public static bool listarUsuarios(Form formActivo, HomeVolquetes formPadre, Usuario usuarioActual, Panel panelMenuLateral)
        {
            if (formActivo != null)
            {
                formActivo.Close();
            }

            limpiarPantalla(formPadre);

            List<Usuario> listaUsuarios = Serializadora.LeerXMLUsuario(RutasArchivos.usuariosDB);
            if (listaUsuarios.Count == 0)
            {
                mostrarMensajeNoDisponible("No existen usuarios :C", formPadre, formActivo, panelMenuLateral);
                return false;
            }
            int y = 0;
            int x = 0;
            int indicadorAlternante = 0;

            foreach (Usuario usuario in listaUsuarios)
            {
                LineaUsuario lineaUsuario = new LineaUsuario(usuario, usuarioActual, formPadre, formActivo, panelMenuLateral);
                lineaUsuario.MdiParent = formPadre;
                lineaUsuario.Show();
                lineaUsuario.Location = new System.Drawing.Point(x, y);
                lineaUsuario.Width = formPadre.Size.Width - panelMenuLateral.Size.Width - 20;

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
    }
}