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
    public partial class nuevoSocio : Form
    {
        public nuevoSocio()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDClientesDataSet);

        }

        private void tableBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDClientesDataSet);

        }

        private void nuevoSocio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDClientesDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.bDClientesDataSet.Table);

        }

        private void addPictureB_Click(object sender, EventArgs e)
        {
            try
            {
                if (openDialogImagen.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openDialogImagen.FileName;
                    fotoPictureBox.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }
    }
}
