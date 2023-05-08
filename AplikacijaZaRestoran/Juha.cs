using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacijaZaRestoran
{
    public partial class Juha : Form
    {

        Pocetna pocetna;
        public Juha(Pocetna poc)
        {
            InitializeComponent();
            this.pocetna = poc;
         
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        
        public void pilecaJuha_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Pileća juha", "1", "4.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void povrtnaJuha_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Povrtna juha", "1", "3.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void ribljaJuha_Click(object sender, EventArgs e)
        {
        }

        private void gljiveJuha_Click(object sender, EventArgs e)
        {
            
        }

        private void rajcicaJuha_Click(object sender, EventArgs e)
        {
           
        }
    }
}
