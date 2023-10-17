﻿using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Interfaz
{
    public partial class AñadirVolquete : Form
    {
        public AñadirVolquete()
        {
            InitializeComponent();
        }

        private void btnAñadirVolquete_Click(object sender, EventArgs e)
        {
            TiposVolquete tipo = TiposVolquete.construccion;
            if (!rdbtnConstruccion.Checked)
            {
                tipo = TiposVolquete.residuos;
            }
            string descripcion = txtDescripcionVolquete.Text;

            Volquete volquete = new Volquete();
            if (volquete.ValidarVolquete(txtPrecioVolquete.Text, txtCapacidadVolquete.Text, tipo, descripcion))
            {
                Serializadora.AgregarVolquete(volquete);
                txtPrecioVolquete.Text = "";
                txtCapacidadVolquete.Text = "";
                txtDescripcionVolquete.Text = "";
                MessageBox.Show("Volquete añadido exitosamente", "Volquete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Los datos introducidos son erroneos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
