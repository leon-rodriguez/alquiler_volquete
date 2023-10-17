using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SuperUsuario : Usuario
    {
        public SuperUsuario()
        {
        }
        public SuperUsuario(string username, string contraseña, string mail, Roles rol) : base(username, contraseña, mail, rol)
        {
        }

        public bool EliminarUsuario(int usuarioId, int usuarioLogueadoId)
        {
            if (usuarioId == usuarioLogueadoId)
            {
                return false;
            }
            //eliminar usuario
            List<Usuario> listaUsuarios = Serializadora.LeerXMLUsuario(RutasArchivos.usuariosDB);
            listaUsuarios.RemoveAll(usuario => usuario.Id == usuarioId);
            Serializadora.EscribirXMLUsuarios(RutasArchivos.usuariosDB, listaUsuarios);

            //desocupar los volquetes usados por ese usuario
            List<Volquete> listaVolquetes = Serializadora.LeerXMLVolquete(RutasArchivos.volqueteDB);
            foreach (Volquete volquete in listaVolquetes)
            {
                if (volquete.IdUsuarioReserva == usuarioId)
                {
                    volquete.IdUsuarioReserva = 0;
                }
            }
            Serializadora.EscribirXMLVolquetes(RutasArchivos.volqueteDB, listaVolquetes);

            return true;
        }

        public bool CambiarRoles(Roles rolActual, int usuarioId, int usuarioLogueadoId)
        {
            int rolActualNumero = (int)rolActual;
            int largoEnumRoles = Enum.GetNames(typeof(Roles)).Length - 1;

            if (usuarioId == usuarioLogueadoId)
            {
                return false;
            }

            if (rolActualNumero == largoEnumRoles)
            {
                rolActualNumero = 0;
            }
            else
            {
                rolActualNumero++;
            }

            Roles rolAAsignar = (Roles)Enum.ToObject(typeof(Roles), rolActualNumero);

            List<Usuario> listaUsuarios = Serializadora.LeerXMLUsuario(RutasArchivos.usuariosDB);
            foreach (Usuario usuario in listaUsuarios)
            {
                if (usuario.Id == usuarioId)
                {
                    usuario.Rol = rolAAsignar;
                }
            }
            Serializadora.EscribirXMLUsuarios(RutasArchivos.usuariosDB, listaUsuarios);
            return true;
        }

        public bool AgregarVolquete(Volquete volquete)
        {
            string ruta;
            string path;
            List<Volquete> listaVolquetes;
            bool respuesta = true;

            //path = @"..\..\..\..\DBxml\volquetesDB";
            Serializadora.ExisteArchivoVolquete(RutasArchivos.volqueteDB);


            listaVolquetes = Serializadora.LeerXMLVolquete(RutasArchivos.volqueteDB);


            listaVolquetes.Add(volquete);
            Serializadora.EscribirXMLVolquetes(RutasArchivos.volqueteDB, listaVolquetes);
            return respuesta;
        }
    }
}
