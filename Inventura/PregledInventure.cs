using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventura
{
    public partial class PregledInventure : Form
    {
        public PregledInventure()
        {
            InitializeComponent();
        }

        private void IzpisButton_Inventura_Click(object sender, EventArgs e)
        {
            Izpis izpis = new Izpis();
            izpis.Show();
        }

        private void DodajButton_Inventura_Click(object sender, EventArgs e)
        {

        }

        private void SpremeniButton_inventura_Click(object sender, EventArgs e)
        {

        }
    }
}
