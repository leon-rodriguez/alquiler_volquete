using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class VolqueteInvernal : VolqueteTipo
    {
        private int temperaturaResistida;
        private bool contieneSal;
        private bool tieneCalefaccion;

        public VolqueteInvernal(string marca, string modelo, int capacidad, int ancho, int largo, int profundidad, int precio, int temperaturaResistida, bool contieneSal, bool tieneCalefaccion) : base(marca, modelo, capacidad, ancho, largo, profundidad, precio)
        {
            this.TemperaturaResistida = temperaturaResistida;
            this.ContieneSal = contieneSal;
            this.TieneCalefaccion = tieneCalefaccion;
        }

        public int TemperaturaResistida { get => temperaturaResistida; set => temperaturaResistida = value; }
        public bool ContieneSal { get => contieneSal; set => contieneSal = value; }
        public bool TieneCalefaccion { get => tieneCalefaccion; set => tieneCalefaccion = value; }
    }
}
