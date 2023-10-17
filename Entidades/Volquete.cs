using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Volquete))]
    public class Volquete
    {
        private int id;
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
        public int Id { get => id; set => id = value; }

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
        public static bool operator ==(Volquete volquete1, Volquete volquete2)
        {
            return volquete1.Id == volquete2.Id;
        }
        public static bool operator !=(Volquete volquete1, Volquete volquete2)
        {
            return !(volquete1.Id == volquete2.Id);
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
                this.id = GenerarId();
                return true;
            }
        }

        private int GenerarId()
        {
            int actualId = Serializadora.LeerXMLId(@"..\..\..\..\DBxml\actualVolqueteIdDB");
            int idAsignable = actualId + 1;
            Serializadora.EscribirXMLId(@"..\..\..\..\DBxml\actualVolqueteIdDB", idAsignable);

            return idAsignable;
        }

        public void ReservarVolquete(int usuarioId)
        {
            if (usuarioId > 0) 
            {
                List<Volquete> listaVolquetes = Serializadora.LeerXMLVolquete(@"..\..\..\..\DBxml\volquetesDB");
                foreach (Volquete volquete in listaVolquetes)
                {
                    if (this == volquete)
                    {
                        volquete.IdUsuarioReserva = usuarioId;
                        Console.WriteLine(usuarioId);
                        Console.WriteLine(volquete.IdUsuarioReserva);
                        break;
                    }
                }
                Serializadora.EscribirXMLVolquetes(@"..\..\..\..\DBxml\volquetesDB", listaVolquetes);
            }
            
        }

        public void CancelarReserva(int usuarioId)
        {
            if (usuarioId > 0)
            {
                List<Volquete> listaVolquetes = Serializadora.LeerXMLVolquete(@"..\..\..\..\DBxml\volquetesDB");
                foreach (Volquete volquete in listaVolquetes)
                {
                    if (this == volquete)
                    {
                        volquete.IdUsuarioReserva = 0;
                        break;
                    }
                }
                Serializadora.EscribirXMLVolquetes(@"..\..\..\..\DBxml\volquetesDB", listaVolquetes);
            }

        }
        public override string ToString()
        {
            return $"Tipo: {this.tipo} Precio: {this.precio} Capacidad: {this.capacidad} Descripcion: {this.descripcion}";
        }
    }
}
