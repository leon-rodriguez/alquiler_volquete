namespace Entidades
{
    public abstract class Usuario
    {
        private int id;
        private string nombreUsuario;
        private string contraseña;
        private string mail;

        protected Usuario(string nombreUsuario, string contraseña, string mail)
        {
            this.NombreUsuario = nombreUsuario;
            this.Contraseña = contraseña;
            this.Mail = mail;
        }

        public int Id { get => id; set => id = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Mail { get => mail; set => mail = value; }
        
        public bool IniciarSesion()
        {
            return true;
        }
    }

}