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
    public partial class VolqueteCard : Form
    {
        private HomeVolquetes padreForm;
        private Volquete volquete;
        private int usuarioId;
        private bool esParaAdministrar;
        public VolqueteCard(Volquete volquete, HomeVolquetes formPadre, int usuarioId, bool esParaAdministrar)
        {
            InitializeComponent();
            lblTipo.Text = volquete.Tipo.ToString();
            lblPrecio.Text = volquete.Precio.ToString();
            lblCapacidad.Text = volquete.Capacidad.ToString();
            lblDescripcion.Text = volquete.Descripcion;
            this.padreForm = formPadre;
            this.volquete = volquete;
            this.usuarioId = usuarioId;
            this.esParaAdministrar = esParaAdministrar;
            generarDiseños();
        }

        private void generarDiseños()
        {
            //osea que esta reservado
            if (volquete.IdUsuarioReserva != 0 && !esParaAdministrar)
            {
                btnReservar.Text = "En uso";
                btnReservar.Cursor = Cursors.Default;
                btnReservar.BackColor = Color.FromArgb(227, 227, 227);
                btnReservar.FlatAppearance.MouseOverBackColor = Color.Transparent;
                pnlContainer.BackColor = Color.FromArgb(227, 227, 227);
            }
            if (esParaAdministrar)
            {
                btnReservar.Text = "Finalizar";
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            if (volquete.IdUsuarioReserva == 0 && !esParaAdministrar)
            {
                volquete.ReservarVolquete(usuarioId);
                padreForm.rellenarListBox(volquete.Tipo, false);
            }
            if (esParaAdministrar)
            {
                volquete.CancelarReserva(usuarioId);
                padreForm.rellenarListBoxAdministrar(true);
            }
        }


    }
}
