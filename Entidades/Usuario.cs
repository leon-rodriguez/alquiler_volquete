using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Usuario))]
    [XmlInclude(typeof(UsuarioComun))]
    [XmlInclude(typeof(Administrador))]
    [XmlInclude(typeof(SuperUsuario))]
    public class Usuario
    {
        private int id;
        private string username;
        private string contraseña;
        private string mail;
        private Roles rol;

        public Usuario()
        {
            
        }
        public Usuario(string username, string contraseña, string mail)
        {
            this.Username = username;
            this.Contraseña = contraseña;
            this.Mail = mail;
        }
        public Usuario(string username, string contraseña, string mail, Roles rol)
        {
            this.Username = username;
            this.Contraseña = contraseña;
            this.Mail = mail;
            this.Rol = rol;
        }

        public string Username { get => username; set => username = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Mail { get => mail; set => mail = value; }
        public Roles Rol { get => rol; set => rol = value; }
        public int Id { get => id; set => id = value; }

        public bool IniciarSesion()
        {
            bool resultado = false;
            List<Usuario> usuarios = Serializadora.LeerXMLUsuario(RutasArchivos.usuariosDB);

            foreach (var item in usuarios)
            {
                if (item.username == this.username && item.contraseña == this.contraseña)
                {
                    this.mail = item.mail;
                    this.Rol = item.rol;
                    this.id = item.id;
                    resultado = true;
                    break;
                }


            }

            return resultado;
        }

        private bool ValidarNombre(string nombre)
        {
            if (!Regex.IsMatch(nombre, @"[^a-zA-Z\s]") && nombre.Trim().Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidarContraseña(string contraseña1, string contraseña2)
        {
            return contraseña1 == contraseña2;
        }

        private bool ValidarMail(string mail)
        {
            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(mail, patron);
        }

        public bool ValidarRegistro(string primeraContraseña)
        {
            bool respuesta = false;

            if (ValidarNombre(this.username) && ValidarContraseña(primeraContraseña, this.contraseña) && ValidarMail(this.mail))
            {
                respuesta = true;
            }

            return respuesta;
        }

        private int GenerarId()
        { 
            int actualId = Serializadora.LeerXMLId(RutasArchivos.idUsuarioDB);
            int idAsignable = actualId + 1;
            Serializadora.EscribirXMLId(RutasArchivos.idUsuarioDB, idAsignable);

            return idAsignable;
        }

        public void AsignarId()
        {
            this.id = GenerarId();
        }

        public override string ToString()
        {
            return $"nombre: {this.username} contraseña: {this.contraseña} mail: {this.mail} rol: {this.rol}";
        }
    }
}