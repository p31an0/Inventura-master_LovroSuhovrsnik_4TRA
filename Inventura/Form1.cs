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

namespace Inventura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //item newItem = new Item ("dwa", "faw", 2.4);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int itemID = Convert.ToInt32(ItemIDtextBox.Text);
            string itemName = ItemNametextBox.Text;
            double price;


            Double.TryParse(PricetextBox.Text, out price);

            Item newItem = new Item(itemID, itemName,price);

            ItemsDatabase db = new ItemsDatabase();//klic konstruktorja, ki odpre povezavo z bazo
            

            if (db.SaveItem(newItem) == true)
            {
                MessageBox.Show("Vnos uspešen.");
            }

        }

        private void ItemIDtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (PricetextBox.Text.Contains(".") == true )
                {

                    int itemID;

                    int.TryParse(ItemIDtextBox.Text, out itemID);

                    ItemsDatabase db = new ItemsDatabase();

                    MessageBox.Show(db.ReadItem(itemID).ToString());

                }
                else
                {
                    MessageBox.Show("Namesto decimalne vejice vnesite piko.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vnesite ID izdelka");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int itemID = Convert.ToInt32(ItemIDtextBox.Text);
            string itemName = ItemNametextBox.Text;
            double price;

            if (PricetextBox.Text.Contains(".")==true)
            {
                Double.TryParse(PricetextBox.Text, out price);

                Item updateItem = new Item(itemID, itemName, price);

                ItemsDatabase db = new ItemsDatabase();//klic konstruktorja, ki odpre povezavo z bazo

                if (db.UpdateItem(updateItem) == true)
                {
                    MessageBox.Show("Posodobitev uspešna.");
                }
            }
            else
            {
                MessageBox.Show("Namesto decimalne vejice vnesite piko.");                
            }                
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int itemID = Convert.ToInt32(ItemIDtextBox.Text);
            string itemName = ItemNametextBox.Text;
            double price;
            Double.TryParse(PricetextBox.Text, out price);

            Item deleteItem = new Item(itemID, itemName, price);

            ItemsDatabase db = new ItemsDatabase();//klic konstruktorja, ki odpre povezavo z bazo

            if (db.DeleteItem(deleteItem) == true)
            {
                MessageBox.Show("Uspešno ste izbrisali izdelek.");
            }
        }
    }
}
