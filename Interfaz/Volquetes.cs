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
    public partial class Volquetes : Form
    {
        private TiposVolquete tipoAMostrar;
        public Volquetes(TiposVolquete tipoSeleccionado)
        {
            this.tipoAMostrar = tipoSeleccionado;
            InitializeComponent();
            rellenarListBox();
            //volquetito.MdiParent = this;
            //volquetito.Show();
        }

        private void rellenarListBox()
        {
            List<Volquete> listaVolquetes = Serializadora.LeerXMLVolquete(@"..\..\..\..\DBxml\volquetesDB");
            int y = 0;
            foreach (Volquete volquete in listaVolquetes)
            {
                if (volquete.Tipo == tipoAMostrar)
                {
                    Console.WriteLine("volquiete a mostrar");
                    //Controls.Add(new VolqueteCard());
                    //listBox1.Items.Add(volquete.ToString());
                    //listBox1.Items.Add(newCard);

                    /*
                    Panel dynamicPanel = new Panel();

                    dynamicPanel.Location = new System.Drawing.Point(26, y);
                    dynamicPanel.Name = "Panel1";
                    dynamicPanel.BackColor = Color.Black;
                    dynamicPanel.Size = new System.Drawing.Size(228, 200);
                    dynamicPanel.TabIndex = 0;*/

                    //Controls.Add(dynamicPanel);
                    /*VolqueteCard volquetito = new VolqueteCard();
                    volquetito.MdiParent = this;
                    volquetito.Location = new System.Drawing.Point(400, 400);
                    volquetito.Show();

                    */
                }
                VolqueteCard volquetito = new VolqueteCard(volquete);
                volquetito.Location = new System.Drawing.Point(0, y);
                Controls.Add(volquetito);
                y += volquetito.Size.Height;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
