using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class VolqueteResiduo : VolqueteTipo
    {
        private TiposResiduos residuoSoportado;
        private bool esHermetico;

        public VolqueteResiduo(string marca, string modelo, int capacidad, int ancho, int largo, int profundidad, int precio, TiposResiduos residuoSoportado, bool esHermetico):base(marca, modelo, capacidad, ancho, largo, profundidad, precio)
        {
            this.ResiduoSoportado = residuoSoportado;
            this.EsHermetico = esHermetico;
        }

        public TiposResiduos ResiduoSoportado { get => residuoSoportado; set => residuoSoportado = value; }
        public bool EsHermetico { get => esHermetico; set => esHermetico = value; }
    }
}
