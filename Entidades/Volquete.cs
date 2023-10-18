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

        //setea el comparador == para que compare los id de lso volquetes
        public static bool operator ==(Volquete volquete1, Volquete volquete2)
        {
            return volquete1.Id == volquete2.Id;
        }
        public static bool operator !=(Volquete volquete1, Volquete volquete2)
        {
            return !(volquete1.Id == volquete2.Id);
        }

        // se intenta parsear el numero ingreado, en caso de falla devuelve -1
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

        // se asignan los valores en caso de ser todo valid0
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

        //genera y asigna id
        private int GenerarId()
        {
            int actualId = Serializadora.LeerXMLId(RutasArchivos.idVolqueteDB);
            int idAsignable = actualId + 1;
            Serializadora.EscribirXMLId(RutasArchivos.idVolqueteDB, idAsignable);

            return idAsignable;
        }


        //le asigna el id del usuario que lo reservo
        public void ReservarVolquete(int usuarioId)
        {
            if (usuarioId > 0) 
            {
                List<Volquete> listaVolquetes = Serializadora.LeerXMLVolquete(RutasArchivos.volqueteDB);
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
                Serializadora.EscribirXMLVolquetes(RutasArchivos.volqueteDB, listaVolquetes);
            }
            
        }

        //le vuelve a asignar el id a 0 dando por finalizado el alquiler
        public void CancelarReserva(int usuarioId)
        {
            if (usuarioId > 0)
            {
                List<Volquete> listaVolquetes = Serializadora.LeerXMLVolquete(RutasArchivos.volqueteDB);
                foreach (Volquete volquete in listaVolquetes)
                {
                    if (this == volquete)
                    {
                        volquete.IdUsuarioReserva = 0;
                        break;
                    }
                }
                Serializadora.EscribirXMLVolquetes(RutasArchivos.volqueteDB, listaVolquetes);
            }

        }
        public override string ToString()
        {
            return $"Tipo: {this.tipo} Precio: {this.precio} Capacidad: {this.capacidad} Descripcion: {this.descripcion}";
        }
    }
}
