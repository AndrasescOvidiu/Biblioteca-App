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
            if (listBox1.SelectedIndex == -1)
                MessageBox.Show("Nu ati ales nici o carte!", "Info");
            else
            {
                string isbnL = listBox1.SelectedItem.ToString();
                string isbnLista = "";
                for (int i = 0; i < isbnL.Length; i++)
                {
                    if (isbnL[i] == ' ' && isbnL[i + 1] == '|')
                        break;
                    else
                        isbnLista += isbnL[i];

                }
                StreamReader rd = new StreamReader("CartiImprumutate.txt");
                string info = "";
                string isbn = "";
                int ok = 0;
                while ((info = rd.ReadLine()) != null)
                {
                    for (int i = 0; i < info.Length; i++)
                        if (info[i] != '|')
                            isbn += info[i];
                        else
                            break;
                    if (isbn == isbnLista)
                    {
                        ok = 1;
                        break;
                    }
                    else
                        isbn = "";
                } //isbnL contine toata schema
                rd.Close();
                if (ok == 0)
                {
                    DialogResult dg = MessageBox.Show("Cartea a fost adaugata la cartile ce vor fi imprumutate\nDoriti sa continuati la meniul Imprumutare Carte?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    StreamWriter wr = new StreamWriter("CartiImprumutate.txt", true);
                    string[] table = isbnL.Split(new[] { " | " }, StringSplitOptions.None);
                    wr.WriteLine(table[0] + "|" + table[1] + "|" + table[2] + "|" + table[3] + "|");
                    wr.Close();
                    if (dg == DialogResult.Yes)
                    {
                        this.Hide();
                        Imprumutare f = new Imprumutare();
                        f.ShowDialog();
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Cartea este adaugata deja la meniul Imprumutare Carte", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void returnare_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Vei fi redirectionat la meniu Returnare Carte,\nContinuati?", "Redirectionare", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(dg == DialogResult.Yes)
            {
                this.Hide();
                Returnare f = new Returnare();
                f.ShowDialog();
                this.Close();
            }
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
            if (comboBox1.SelectedItem.ToString() == "NUME")
            {
                listBox1.Items.Clear();
                StreamReader rd = new StreamReader("ListaCarti.txt");
                List<Carte> carti = new List<Carte>();
                string info = "";
                while((info=rd.ReadLine())!=null)
                {
                    string[] table = info.Split('|');
                    carti.Add(new Carte(table[1], table[0], table[2], table[3]));
                }
                
                rd.Close();
                List<Carte> SortedList = carti.OrderBy(o => o.get_n()).ToList();
                for (int i = 0; i < SortedList.Count; i++)
                {
                    listBox1.Items.Add(SortedList[i].get_i() + " | " + SortedList[i].get_n() + " | " +
                                        SortedList[i].get_a() + " | " + SortedList[i].get_e());
                }
            }
            if (comboBox1.SelectedItem.ToString() == "ISBN")
            {
                listBox1.Items.Clear();
                StreamReader rd = new StreamReader("ListaCarti.txt");
                List<Carte> carti = new List<Carte>();
                string info = "";
                while ((info = rd.ReadLine()) != null)
                {
                    string[] table = info.Split('|');
                    carti.Add(new Carte(table[1], table[0], table[2], table[3]));
                }

                rd.Close();
                List<Carte> SortedList = carti.OrderBy(o => o.get_i()).ToList();
                for (int i = 0; i < SortedList.Count; i++)
                {
                    listBox1.Items.Add(SortedList[i].get_i() + " | " + SortedList[i].get_n() + " | " +
                                        SortedList[i].get_a() + " | " + SortedList[i].get_e());
                }
            }
            if (comboBox1.SelectedItem.ToString() == "AUTOR")
            {
                listBox1.Items.Clear();
                StreamReader rd = new StreamReader("ListaCarti.txt");
                List<Carte> carti = new List<Carte>();
                string info = "";
                while ((info = rd.ReadLine()) != null)
                {
                    string[] table = info.Split('|');
                    carti.Add(new Carte(table[1], table[0], table[2], table[3]));
                }

                rd.Close();
                List<Carte> SortedList = carti.OrderBy(o => o.get_a()).ToList();
                for (int i = 0; i < SortedList.Count; i++)
                {
                    listBox1.Items.Add(SortedList[i].get_i() + " | " + SortedList[i].get_n() + " | " +
                                        SortedList[i].get_a() + " | " + SortedList[i].get_e());
                }
            }
            if (comboBox1.SelectedItem.ToString() == "EDITURA")
            {
                listBox1.Items.Clear();
                StreamReader rd = new StreamReader("ListaCarti.txt");
                List<Carte> carti = new List<Carte>();
                string info = "";
                while ((info = rd.ReadLine()) != null)
                {
                    string[] table = info.Split('|');
                    carti.Add(new Carte(table[1], table[0], table[2], table[3]));
                }

                rd.Close();
                List<Carte> SortedList = carti.OrderBy(o => o.get_e()).ToList();
                for (int i = 0; i < SortedList.Count; i++)
                {
                    listBox1.Items.Add(SortedList[i].get_i() + " | " + SortedList[i].get_n() + " | " +
                                        SortedList[i].get_a() + " | " + SortedList[i].get_e());
                }
            }
        }
    }
}
