using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Usuario))]
    [XmlInclude(typeof(Volquete))]

    public class Serializadora
    {

        #region Dbusuarios      
        public static void EscribirXMLUsuarios(string path, List<Usuario> usuario)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Usuario>));
                ser.Serialize(sw, usuario);
            }
        }

        public static bool AgregarUsuario(Usuario usuario)
        {
            List<Usuario> listaUsuarios;
            bool respuesta = true;

            Serializadora.ExisteArchivoUsuario(RutasArchivos.usuariosDB);


            listaUsuarios = Serializadora.LeerXMLUsuario(RutasArchivos.usuariosDB);

            foreach (var item in listaUsuarios)
            {
                if(usuario.Mail == item.Mail)
                {
                    respuesta = false;
                    break;
                }
            }

            if (respuesta)
            {
                listaUsuarios.Add(usuario);
                Serializadora.EscribirXMLUsuarios(RutasArchivos.usuariosDB, listaUsuarios);                
            }
            return respuesta;
        }

        public static List<Usuario> LeerXMLUsuario(string path)
        {
            List<Usuario> listaUsuarios = null;
            Serializadora.ExisteArchivoUsuario(path);

            using (StreamReader sr = new StreamReader(path))
            {
                XmlSerializer des = new XmlSerializer(typeof(List<Usuario>));

                listaUsuarios = (List<Usuario>)des.Deserialize(sr);
            }

            return listaUsuarios;
        }

        private static void ExisteArchivoUsuario(string path)
        {
            List<Usuario> listaVacia;
            listaVacia = new List<Usuario>();

            if (!File.Exists(path))
            {
                Serializadora.EscribirXMLUsuarios(path, listaVacia);
            }
        }
        #endregion

        #region DBusuarioVolqueteId
        public static int LeerXMLId(string path)
        {
            int idActual;
            Serializadora.ExisteArchivoId(path);

            string json = File.ReadAllText(path);
            idActual = JsonConvert.DeserializeObject<int>(json);

            return idActual;
        }

        private static void ExisteArchivoId(string path)
        {
            int id = 1;

            if (!File.Exists(path))
            {
                Serializadora.EscribirXMLId(path, id);
            }
        }
        public static void EscribirXMLId(string path, int id)
        {
            string textoAGuardar = JsonConvert.SerializeObject(id,Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(path, textoAGuardar);
        }
        #endregion

        #region Dbvolquetes      
        public static void EscribirXMLVolquetes(string path, List<Volquete> volquete)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Volquete>));
                ser.Serialize(sw, volquete);
            }
        }

        public static List<Volquete> LeerXMLVolquete(string path)
        {
            List<Volquete> listaVolquetes = null;
            Serializadora.ExisteArchivoVolquete(path);

            using (StreamReader sr = new StreamReader(path))
            {
                XmlSerializer des = new XmlSerializer(typeof(List<Volquete>));

                listaVolquetes = (List<Volquete>)des.Deserialize(sr);
            }

            return listaVolquetes;
        }

        public static void ExisteArchivoVolquete(string path)
        {
            List<Volquete> listaVacia = new List<Volquete>();

            if (!File.Exists(path))
            {
                Serializadora.EscribirXMLVolquetes(path, listaVacia);
            }
        }
        #endregion
    }

}
