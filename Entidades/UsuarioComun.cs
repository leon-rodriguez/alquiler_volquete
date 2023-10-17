using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsuarioComun : Usuario
    {
        public UsuarioComun()
        {
        }
        public UsuarioComun(string username, string contraseña, string mail, Roles rol) : base(username, contraseña, mail, rol)
        {
        }

    }
}
