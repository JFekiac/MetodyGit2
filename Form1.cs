using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodyGit2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTime Za100dni(DateTime datum)
        {
            return datum.AddDays(100);
        }

        //Metoda 2 - ukáže aktuální datum a čas
        DateTime Metoda2(DateTime datum)
        {
            return datum = DateTime.Now;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dnes = DateTime.Today;
            DateTime datum = DateTime.Now;
            MessageBox.Show("Datum za 100 dní: " + Za100dni(dnes).ToShortDateString()); //Funguje
            MessageBox.Show("Aktualni datum je: " + Metoda2(datum).ToShortDateString());

        }
    }
}
