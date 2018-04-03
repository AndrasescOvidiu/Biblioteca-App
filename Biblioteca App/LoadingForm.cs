using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Biblioteca_App
{

    public partial class LoadingForm : Form
    {
        public int i = 1;
        public int k = 100;
        public LoadingForm()
        {
            InitializeComponent();
            Application.EnableVisualStyles();

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(i);
            i++;
            if (progressBar1.Value == k)
            {
              //  MessageBox.Show("test");
                i = 1;
                timer1.Stop();
                Form1 f = new Form1();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
