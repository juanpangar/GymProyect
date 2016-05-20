using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace GymProject
{
    public partial class listasSociosMensual : Form
    {
        public listasSociosMensual()
        {
            InitializeComponent();
        }

        private void listasSociosMensual_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDClientesDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.bDClientesDataSet.Table);

        }

        private void pdfGenerateB_Click(object sender, EventArgs e)
        {
            //Fata ver como generarlo lo que habia buscado no sirve
        }
    }
}
