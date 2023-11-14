using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class VolqueteObra : VolqueteTipo
    {
        private MaterialesObra materialSoportado;
        
        public VolqueteObra(string marca, string modelo, int capacidad, int ancho, int largo, int profundidad, int precio, MaterialesObra materialSoportado) :base(marca, modelo, capacidad, ancho, largo, profundidad, precio)
        {
            this.MaterialSoportado = materialSoportado;
        }

        public MaterialesObra MaterialSoportado { get => materialSoportado; set => materialSoportado = value; }


    }
}
