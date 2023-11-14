using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Administrador : Usuario
    {
        private string cuil;


        public Administrador(string nombreUsuario, string contraseña, string mail, string cuil) : base(nombreUsuario, contraseña, mail)
        {
            this.Cuil = cuil;
        }
        
        public string Cuil { get => cuil; set => cuil = value; }

        private bool EditarReserva()
        {
            return true;
        }

        private bool EliminarReserva()
        {
            return true;
        }

        private bool AñadirStock()
        {
            return true;
        }

        private bool EliminarStock() 
        {
            return true;
        }
    }
}
