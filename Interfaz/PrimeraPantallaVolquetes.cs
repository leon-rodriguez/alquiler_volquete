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
        private Usuario usuario;
        private Panel panel;
        public PrimeraPantallaVolquetes(HomeVolquetes formPadre, Form formActivo, Usuario usuario, Panel panel)
        {
            InitializeComponent();
            this.formPadre = formPadre;
            this.formActivo = formActivo;
            this.usuario = usuario;
            this.panel = panel;
        }

        //printea los volquetes de contruccion
        private void btnVerConstruccion_Click(object sender, EventArgs e)
        {
            AccionesForm.rellenarListBox(TiposVolquete.construccion, false, formActivo, formPadre, usuario, panel);
        }


        //printea los volquetes de residuos
        private void btnVerResiduos_Click(object sender, EventArgs e)
        {
            AccionesForm.rellenarListBox(TiposVolquete.residuos, false, formActivo, formPadre, usuario, panel);
        }
    }
}
