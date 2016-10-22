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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void iesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adaugare f = new Adaugare();
            f.ShowDialog();
            this.Close();

        }

        private void cautare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cautare f = new Cautare();
            f.ShowDialog();
            this.Close();
        }

        private void returnare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Returnare f = new Returnare();
            f.ShowDialog();
            this.Close();
        }

        private void imprumutare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Imprumutare f = new Imprumutare();
            f.ShowDialog();
            this.Close();
        }

        private void AfisareListaCarti_Click(object sender, EventArgs e)
        {
            this.Hide();
            AfisareListaCarti f = new AfisareListaCarti();
            f.ShowDialog();
            this.Close();
        }
    }
}
