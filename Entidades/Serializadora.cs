using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Usuario))]

    public class Serializadora{ 
        private static void EscribirXML(string path, List<Usuario> usuario)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Usuario>));
                ser.Serialize(sw, usuario);
            }
        }

        public static bool AgregarUsuario(Usuario usuario)
        {
            string ruta;
            string path;
            List<Usuario> listaUsuarios;
            bool respuesta = true;


            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path = ruta + @"\volquetesDB";
            Serializadora.ExisteArchivo(path);


            listaUsuarios = Serializadora.LeerXML(path);

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
                Serializadora.EscribirXML(path, listaUsuarios);                
            }
            return respuesta;
        }

        public static List<Usuario> LeerXML(string path)
        {
            List<Usuario> listaUsuarios = null;

            using (StreamReader sr = new StreamReader(path))
            {
                XmlSerializer des = new XmlSerializer(typeof(List<Usuario>));

                listaUsuarios = (List<Usuario>)des.Deserialize(sr);
            }

            return listaUsuarios;
        }

        private static void ExisteArchivo(string path)
        {
            List<Usuario> listaVacia;
            listaVacia = new List<Usuario>();

            if (!File.Exists(path))
            {
                Serializadora.EscribirXML(path, listaVacia);
            }
        }

    }

}
