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
    public partial class LogApp : Form
    {
        public LogApp()
        {
            InitializeComponent();
        }

        private void accesButton_Click(object sender, EventArgs e)
        {
            if(passBox.Text.Trim() == "pass")
            {
                this.Hide();
                Inicio inicio = new Inicio();
                inicio.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseña errona, por favor vuelva a intentarlo.", "Error Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passBox.Clear();
            }

        }

        private void pressEnter(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if (passBox.Text.Trim() == "pass")
                {
                    this.Hide();
                    Inicio inicio = new Inicio();
                    inicio.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Contraseña errona, por favor vuelva a intentarlo.", "Error Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passBox.Clear();
                }
            }
        }
    }
}
