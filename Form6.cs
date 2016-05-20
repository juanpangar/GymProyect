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
    public partial class listaSociosImpagos : Form
    {
        public listaSociosImpagos()
        {
            InitializeComponent();
        }

        private void listaSociosImpagos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDClientesDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.bDClientesDataSet.Table);

        }
    }
}
