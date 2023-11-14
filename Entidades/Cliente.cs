using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Cliente : Usuario
    {
        private string telefono;
        private string direccion;
        private int saldo;

        public Cliente(string nombreUsuario, string contraseña, string mail, string telefono, string direccion, int saldo) : base(nombreUsuario, contraseña, mail)
        {
            this.telefono = telefono;
            this.direccion = direccion;
            this.saldo = saldo;
        }

        private bool ReservarVolquete()
        {
            return true;
        }

        private bool RegistrarCliente()
        {
            return true;
        }

    }
}
