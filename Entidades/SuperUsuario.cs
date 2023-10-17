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

        public void EliminarUsuario(int usuarioId)
        {
            List<Usuario> listaUsuarios = Serializadora.LeerXMLUsuario(@"..\..\..\..\DBxml\usuariosDB");
            listaUsuarios.RemoveAll(usuario => usuario.Id == usuarioId);
            Serializadora.EscribirXMLUsuarios(@"..\..\..\..\DBxml\usuariosDB", listaUsuarios);
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

            List<Usuario> listaUsuarios = Serializadora.LeerXMLUsuario(@"..\..\..\..\DBxml\usuariosDB");
            foreach (Usuario usuario in listaUsuarios)
            {
                if (usuario.Id == usuarioId)
                {
                    usuario.Rol = rolAAsignar;
                }
            }
            Serializadora.EscribirXMLUsuarios(@"..\..\..\..\DBxml\usuariosDB", listaUsuarios);
            return true;
        }
    }
}
