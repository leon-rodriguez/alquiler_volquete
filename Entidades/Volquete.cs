using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Volquete
    {
        private TiposVolquete tipo;
        private string descripcion;
        private int precio;
        private int capacidad;
        private int idUsuarioReserva;

        public TiposVolquete Tipo { get => tipo; set => tipo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
        public int IdUsuarioReserva { get => idUsuarioReserva; set => idUsuarioReserva = value; }

        public Volquete()
        {
            
        }

        public Volquete(TiposVolquete tipo, string descripcion, int precio, int capacidad)
        {
            this.tipo = tipo;
            this.descripcion = descripcion;
            this.precio = precio;
            this.capacidad = capacidad;
            this.idUsuarioReserva = 0;
        }
        private int ValidarNumeroIngresado(string numeroIngresado)
        {
            int respuesta = 1;
            try
            {
                respuesta = int.Parse(numeroIngresado);
            }
            catch
            {
                respuesta = -1;
            }
            return respuesta;
        }

        public bool ValidarVolquete(string precioIngresado, string capacidadIngresada, TiposVolquete tipo, string descripcion)
        {
            int precioParseado = ValidarNumeroIngresado(precioIngresado);
            int capacidadParseada = ValidarNumeroIngresado(capacidadIngresada);

            if (precioParseado < 0 || capacidadParseada < 0)
            {
                return false;
            }
            else
            {
                this.tipo = tipo;
                this.precio = precioParseado;
                this.capacidad = capacidadParseada;
                this.descripcion = descripcion;
                return true;
            }
        }

        public override string ToString()
        {
            return $"Tipo: {this.tipo} Precio: {this.precio} Capacidad: {this.capacidad} Descripcion: {this.descripcion}";
        }
    }
}
