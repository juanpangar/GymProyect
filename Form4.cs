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
    public partial class listaSocios : Form
    {
        public listaSocios()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDClientesDataSet);

        }

        private void listaSocios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDClientesDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.bDClientesDataSet.Table);

        }
    }
}
