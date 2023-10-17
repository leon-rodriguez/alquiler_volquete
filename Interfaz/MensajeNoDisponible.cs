using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class MensajeNoDisponible : Form
    {
        private string mensajeAMostrar;
        public MensajeNoDisponible(string mensajeAMostrar)
        {
            InitializeComponent();
            this.mensajeAMostrar = mensajeAMostrar;
            lblMensaje.Text = mensajeAMostrar;
        }
    }
}
