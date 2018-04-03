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
    public partial class Imprumutare : Form
    {
        public Imprumutare()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.BackColor = Color.Red;
            if (textBox2.Text == "")
                textBox2.BackColor = Color.Red;
            if (listBox1.SelectedIndex == -1)
                MessageBox.Show("Nu ati ales nici o carte!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    
                    int ok = 0;
                    StreamReader rd = new StreamReader("Cititori.txt");
                    string info = "";
                    while ((info = rd.ReadLine()) != null)
                    {

                        string[] table = info.Split('|');

                        if (
                            (table[0].ToUpper() == textBox1.Text.ToUpper() && table[1].ToUpper() == textBox2.Text.ToUpper()) ||
                            (table[1].ToUpper() == textBox1.Text.ToUpper() && table[0].ToUpper() == textBox2.Text.ToUpper())
                            )
                        {
                            MessageBox.Show("Persoana are deja o carte imprumutata!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ok = 1;
                            break;
                        }
                    }
                    rd.Close();
                    if (ok == 0)
                    {
                        string[] isbn = listBox1.SelectedItem.ToString().Split(new[] { " | " }, StringSplitOptions.None);

                        MessageBox.Show("Imprumutare realizata!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        StreamWriter wr = new StreamWriter("Cititori.txt", true);
                        wr.WriteLine(textBox1.Text.Trim() + "|" + textBox2.Text.Trim() + "|"+isbn[0]+"|");
                        wr.Close();
                        textBox1.Text = "";
                        textBox2.Text = "";
                        List<String> carti = new List<string>();
                        StreamReader rdl = new StreamReader("CartiImprumutate.txt");
                        string info1 = "";
                        while((info1=rdl.ReadLine())!=null)
                        {
                            string[] table = info1.Split('|');
                            if (isbn[0] != table[0])
                                carti.Add(info1);

                        }
                        rdl.Close();
                        listBox1.Items.Clear();
                        StreamWriter wrd = new StreamWriter("CartiImprumutate.txt");
                        for(int i=0;i<carti.Count;i++)
                        {
                            wrd.WriteLine(carti[i]);
                            string[] table = carti[i].Split('|');
                            listBox1.Items.Add(table[0]+" | "+table[1]+" | "+table[2]+" | "+table[3]+" | ");
                        }
                        wrd.Close();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

        private void Imprumutare_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            StreamReader rd = new StreamReader("CartiImprumutate.txt");
            string info = "";
            while ((info = rd.ReadLine()) != null)
            {
                string[] table = info.Split('|');
                listBox1.Items.Add(table[0] + " | " + table[1] + " | " + table[2] + " | " + table[3] + " | ");
            }
            rd.Close();
        }
    }
}
