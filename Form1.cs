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

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dnes = DateTime.Today;
            MessageBox.Show("Datum za 100 dní: " + Za100dni(dnes).ToShortDateString());
        }
    }
}
