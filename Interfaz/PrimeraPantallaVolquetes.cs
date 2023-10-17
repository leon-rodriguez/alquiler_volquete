using Entidades;
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
    public partial class PrimeraPantallaVolquetes : Form
    {
        private HomeVolquetes formPadre;
        private Form formActivo;
        public PrimeraPantallaVolquetes(HomeVolquetes formPadre, Form formActivo)
        {
            InitializeComponent();
            this.formPadre = formPadre;
            this.formActivo = formActivo;
        }

        private void btnVerConstruccion_Click(object sender, EventArgs e)
        {
            formPadre.rellenarListBox(TiposVolquete.construccion, false);
        }

        private void btnVerResiduos_Click(object sender, EventArgs e)
        {
            formPadre.rellenarListBox(TiposVolquete.residuos, false);
        }
    }
}
