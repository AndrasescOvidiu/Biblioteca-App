using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_App
{
    public partial class Cautare : Form
    {
        public Cautare()
        {
            InitializeComponent();
        }

        private void iesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imprumutare_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Imprumutare");
        }

        private void returnare_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Returnare");
        }

        private void revenire_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
        }

        private void afisareListaCarti_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Afisare Lista cart");
        }
    }
}
