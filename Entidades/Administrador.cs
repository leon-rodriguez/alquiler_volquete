using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrador : Usuario
    {
        public Administrador()
        {
        }
        public Administrador(string username, string contraseña, string mail, Roles rol) : base(username, contraseña, mail, rol)
        {
        }

        public bool AgregarVolquete(Volquete volquete)
        {
            List<Volquete> listaVolquetes;
            bool respuesta = true;

            Serializadora.ExisteArchivoVolquete(RutasArchivos.volqueteDB);


            listaVolquetes = Serializadora.LeerXMLVolquete(RutasArchivos.volqueteDB);


            listaVolquetes.Add(volquete);
            Serializadora.EscribirXMLVolquetes(RutasArchivos.volqueteDB, listaVolquetes);
            return respuesta;
        }
    }
}
