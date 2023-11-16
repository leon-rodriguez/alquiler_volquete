using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Reserva
    {
        private int id;
        private DateTime fechaInicio;
        private DateTime fechaFinal;
        private int clienteId;
        public Reserva(int id, DateTime fechaInicio, DateTime fechaFinal, int clienteId)
        {
            this.id = id;
            this.fechaInicio = fechaInicio;
            this.fechaFinal = fechaFinal;
            this.clienteId = clienteId;
        }
    }


}
