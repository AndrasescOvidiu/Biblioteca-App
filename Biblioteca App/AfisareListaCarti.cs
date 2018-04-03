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
    public partial class AfisareListaCarti : Form
    {
        public AfisareListaCarti()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "NUME")
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                MessageBox.Show("Nu ati ales nici o carte !", "Info");
            else
            {
                string[] table = listBox1.SelectedItem.ToString().Split(new[] { " | " }, StringSplitOptions.None);
                StreamReader rd = new StreamReader("ListaCarti.txt");
                string info = "";
                List<String> carti = new List<string>();
                while ((info = rd.ReadLine()) != null)
                {
                    string isbn = "";
                    for (int i = 0; i < info.Length; i++)
                    {
                        if (info[i] != '|')
                            isbn += info[i];
                        else
                            break;
                    }
                    if (isbn != table[0])
                    {
                        carti.Add(info);
                    }
                    else
                        MessageBox.Show("Cartea care va fi strearsa este: " + table[0]);
                }
                rd.Close();
                StreamWriter wr = new StreamWriter("ListaCarti.txt");
                for (int i = 0; i < carti.Count; i++)
                {
                    wr.WriteLine(carti[i]);
                }
                wr.Close();
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }
    }
}
