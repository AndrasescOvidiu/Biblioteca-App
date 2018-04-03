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
            if (listBox1.SelectedIndex == -1)
                MessageBox.Show("Alegeti o persoana din lista!", "Info");
            else
            {
                string t = listBox1.SelectedItem.ToString();
                string[] tableNew = t.Split(new[] {" | "}, StringSplitOptions.None);
                //table[2];

                StreamReader rdl = new StreamReader("Cititori.txt");
                string info = "";
                List<String> cititori = new List<string>();
                while((info=rdl.ReadLine())!=null)
                {
                    string[] tableCititori = info.Split('|');
                    if (tableCititori[2] != tableNew[2])
                        cititori.Add(info);
                }
                rdl.Close();
                listBox1.Items.Clear();
                StreamWriter wrd = new StreamWriter("Cititori.txt");
                for(int i=0;i<cititori.Count;i++)
                {
                    wrd.WriteLine(cititori[i]);
                    string[] table = cititori[i].Split('|');
                    listBox1.Items.Add(table[0] + " | " + table[1] + " | " + table[2] + " | ");
                }
                wrd.Close();
                
                StreamReader rd = new StreamReader("ListaCarti.txt");
                info = "";
                while((info = rd. ReadLine())!=null)
                {
                    
                    string[] searchIsbn = info.Split('|');
                    if (searchIsbn[0] == tableNew[2])
                    {
                        MessageBox.Show("Cartea a fost returnata!\nDetalii carte: \nISBN: "+searchIsbn[0]+"  |  Nume: "+searchIsbn[1]+"\nAutor: " +searchIsbn[2]+ "  |  Editura: "+searchIsbn[3], "Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                rd.Close();
            }
        }

        private void revenireMeniu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
        }

        private void Returnare_Load(object sender, EventArgs e)
        {
            StreamReader rd = new StreamReader("Cititori.txt");
            string info = "";
            while((info = rd.ReadLine())!=null)
            {
                string[] table = info.Split('|');
                listBox1.Items.Add(table[0] + " | " + table[1]+" | "+table[2]+" | ");
            }
            rd.Close();
        }
    }
}
