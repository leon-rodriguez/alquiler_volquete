using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class SuperAdministrador : Administrador
    { 
        SuperAdministrador(string nombreUsuario, string contraseña, string mail, string cuil) : base(nombreUsuario, contraseña, mail, cuil)
        {
        }

        private bool AñadirAdministrador()
        {
            return true;
        }

        private bool EliminarAdministrador() 
        {  
            return true; 
        }
    }
}
