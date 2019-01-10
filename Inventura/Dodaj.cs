using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Items;
using System.Data.SQLite;

namespace Inventura
{
    public partial class Dodaj : Form
    {
        public Dodaj()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DodajIzdelekButton_Click(object sender, EventArgs e)
        {
            int itemID = Convert.ToInt32(IdIzdelkaTextBox.Text);
            string itemName = NazivIzdelkaTextBox.Text;
            double price;


            Double.TryParse(CenaIzdelkaTextBox.Text, out price);

            Item newItem = new Item(itemID, itemName, price);

            ItemsDatabase db = new ItemsDatabase();//klic konstruktorja, ki odpre povezavo z bazo


            if (db.SaveItem(newItem) == true)
            {
                MessageBox.Show("Vnos uspešen.");
            }
        }

        
    }
}
