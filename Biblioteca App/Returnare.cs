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
    public partial class Returnare : Form
    {
        public Returnare()
        {
            InitializeComponent();
        }

        private void iesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void returnareCarte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Returnareee");
        }

        private void revenireMeniu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
        }
    }
}
