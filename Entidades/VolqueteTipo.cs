using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //falta atributo demora al volver
    abstract class VolqueteTipo
    {
        private string marca;
        private string modelo;
        private int capacidad;
        private int ancho;
        private int largo;
        private int profundidad;
        private int precio;
        private int cantidad;//agregar a lconstructor

        protected VolqueteTipo(string marca, string modelo, int capacidad, int ancho, int largo, int profundidad, int precio)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Capacidad = capacidad;
            this.Ancho = ancho;
            this.Largo = largo;
            this.Profundidad = profundidad;
            this.Precio = precio;
        }

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
        public int Ancho { get => ancho; set => ancho = value; }
        public int Largo { get => largo; set => largo = value; }
        public int Profundidad { get => profundidad; set => profundidad = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
