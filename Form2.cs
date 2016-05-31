using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymProject
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void nuevoSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevoSocio nsocio = new nuevoSocio();
            nsocio.ShowDialog();
        }

        private void todosLosSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listaSocios lsocios = new listaSocios();
            lsocios.ShowDialog();
        }

        private void listaDeSociosMensualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listasSociosMensual lsmensual = new listasSociosMensual();
            lsmensual.ShowDialog();
        }

        private void listaDeSociosConImpagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listaSociosImpagos lsimpagos = new listaSociosImpagos();
            lsimpagos.ShowDialog();
        }

        private void searchB_Click(object sender, EventArgs e)
        {
            // TODO: Falta lo de buscar el cliente en concreto respecto a la textbox
            // esa parte se hara cuando se pueden inserta bien los datos en la base de datos
            Cliente cliente = new Cliente();
            cliente.ShowDialog();
        }

        private void pagoB_Click(object sender, EventArgs e)
        {
            Pago pago = new Pago();
            pago.ShowDialog();
        }

        //TODO: no olvidar la parte de impagos sera tambien de las ultimas partes en realizarse
    }
}
