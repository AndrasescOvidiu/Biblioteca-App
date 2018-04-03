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

namespace Biblioteca_App
{
    public partial class Adaugare : Form
    {
        public Adaugare()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("iesiree");
            //this.Close();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isbnText.Text == "")
                isbnText.BackColor = Color.Red;
            if (numeleText.Text == "")
                numeleText.BackColor = Color.Red;
            if (edituraText.Text == "")
                edituraText.BackColor = Color.Red;
            if (autorulText.Text == "")
                autorulText.BackColor = Color.Red;
            if (isbnText.Text != "" && numeleText.Text != "" && edituraText.Text != "" && autorulText.Text != "")
            {
                int ok = 0;
                StreamReader rd = new StreamReader("ListaCarti.txt");
                string info = "";
                while((info=rd.ReadLine())!=null)
                {
                    string isbn = "";
                    for (int i = 0; i < info.Length; i++)
                        if (info[i] != '|')
                            isbn += info[i];
                        else break;
                    if (isbnText.Text == isbn)
                    {
                        MessageBox.Show("Mai exista o carte cu acel ISBN !!!\nVa rugam verificati ISBN-ul", "Eroare la adaugare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ok = 1;
                    }
                }
                rd.Close();
                if (ok == 0)
                {
                    StreamWriter wr = new StreamWriter("ListaCarti.txt", true);
                    wr.WriteLine(isbnText.Text.Trim() + "|" + numeleText.Text.Trim() + "|" + autorulText.Text + "|"+edituraText.Text.Trim());
                    MessageBox.Show("Cartea a fost adaugata","Info");
                    isbnText.Text = "";
                    numeleText.Text = "";
                    edituraText.Text = "";
                    autorulText.Text = "";
                    wr.Close();
                }
            }
            else
                MessageBox.Show("Va rugam sa completati toate campurile!", "Info");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
        }

        private void isbnText_TextChanged(object sender, EventArgs e)
        {
            isbnText.BackColor = Color.White;
        }

        private void numeleText_TextChanged(object sender, EventArgs e)
        {
            numeleText.BackColor = Color.White;
        }

        private void autorulText_TextChanged(object sender, EventArgs e)
        {
            autorulText.BackColor = Color.White;
        }

        private void edituraText_TextChanged(object sender, EventArgs e)
        {
            edituraText.BackColor = Color.White;
        }
    }
}
