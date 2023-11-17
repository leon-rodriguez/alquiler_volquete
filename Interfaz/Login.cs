
using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Interfaz
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //DB.Insert("Caruana", "Fabiano", 42);
            DB.Select();
            Console.WriteLine("hola como estan");
        }
    }
}