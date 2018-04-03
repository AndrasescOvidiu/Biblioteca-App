using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_App
{
    class Carte
    {
        string nume, isbn, autor, editura;
        public Carte(string n,string i,string a,string e)
        {
            nume = n;
            isbn = i;
            autor = a;
            editura = e;
        }
        public string get_n()
        {
            return nume;
        }
        public string get_i()
        {
            return isbn;
        }
        public string get_a()
        {
            return autor;
        }
        public string get_e()
        {
            return editura;
        }
        public void afisare()
        {
            MessageBox.Show(nume + " " + isbn + " " + autor + " " + editura);
        }
    }
}
