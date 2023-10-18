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

            //se encarga de ademas de cambiar el rol cambiar el tipo de la instancia de usuario
            int index = 0;
            bool encontrado = false;
            Usuario usuarioEncontrado = null;
            foreach (Usuario usuario in listaUsuarios)
            {
                if (usuario.Id == usuarioId)
                {
                    usuarioEncontrado = usuario;
                    encontrado = true;
                    break;
                }
                index++;
            }
            if (encontrado)
            {
                Console.WriteLine(rolAAsignar);
                if (rolAAsignar == Roles.superUsuario)
                {
                    SuperUsuario superUsuarioEncontrado = new SuperUsuario(usuarioEncontrado.Username, usuarioEncontrado.Contraseña, usuarioEncontrado.Mail, rolAAsignar);
                    superUsuarioEncontrado.Id = usuarioEncontrado.Id;
                    listaUsuarios.RemoveAt(index);
                    listaUsuarios.Add(superUsuarioEncontrado);
                }
                else if(rolAAsignar == Roles.administrador)
                {
                    Administrador administrador = new Administrador(usuarioEncontrado.Username, usuarioEncontrado.Contraseña, usuarioEncontrado.Mail, rolAAsignar);
                    administrador.Id = usuarioEncontrado.Id;
                    listaUsuarios.RemoveAt(index);
                    listaUsuarios.Add(administrador);
                }
                else if (rolAAsignar == Roles.usuario)
                {
                    UsuarioComun usuarioComun = new UsuarioComun(usuarioEncontrado.Username, usuarioEncontrado.Contraseña, usuarioEncontrado.Mail, rolAAsignar);
                    usuarioComun.Id = usuarioEncontrado.Id;
                    listaUsuarios.RemoveAt(index);
                    listaUsuarios.Insert(index, usuarioComun);
                }
            }
            Serializadora.EscribirXMLUsuarios(RutasArchivos.usuariosDB, listaUsuarios);
            return true;
        }

        //agrega el volquete pasado por parametro
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

        public override string DevolverRolString()
        {
            return "Super usuario";
        }
    }
}
