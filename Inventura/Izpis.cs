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
    public partial class Izpis : Form
    {
        public Izpis()
        {
            InitializeComponent();
            Display();
        }

        void Display() //funkcija za osveževanje - ob vsakem kliku na gumb mi avtomatsko doda, izbriše ter to tudi prikaže
        {
            SQLiteConnection con = new SQLiteConnection("datasource=itemsDatabase.db");
            con.Open();

            DataTable tabela = new DataTable();
            SQLiteDataAdapter adptr = new SQLiteDataAdapter("SELECT * FROM izdelki l", con);
            adptr.Fill(tabela);
            tabela.Columns[2].DataType = typeof(double);
            dataGridView1.Rows.Clear();
           // MessageBox.Show(tabela.Rows[0].ItemArray.ElementAt<double>(2));

            foreach (DataRow item in tabela.Rows)//za takojšen izpis vnosa
            {
                int x = dataGridView1.Rows.Add();
                dataGridView1.Rows[x].Cells[0].Value = item[0].ToString();//namesto stevilke indexa bi lahko določil kar ime stolpca             
                dataGridView1.Rows[x].Cells[1].Value = item[1].ToString(); //ime krvodajalca
                dataGridView1.Rows[x].Cells[2].Value = item[2].ToString(); //priimek krvodajalca
                dataGridView1.Rows[x].Cells[3].Value = item[3].ToString(); //Ime priimek zdravnika                
            }
            con.Close();
        }

        private void Izpis_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void UpdateIzpis_button_Click(object sender, EventArgs e)
        {
            int itemID = Convert.ToInt32(ItemIDtextBox.Text);
            string itemName = ItemNametextBox.Text;
            double price;

            
           
                Double.TryParse(PricetextBox.Text, out price);

                MessageBox.Show(price.ToString());

                Item updateItem = new Item(itemID, itemName, price);

                ItemsDatabase db = new ItemsDatabase();//klic konstruktorja, ki odpre povezavo z bazo

                if (db.UpdateItem(updateItem) == true)
                {
                    MessageBox.Show("Posodobitev uspešna.");
                    Display();
                }
           
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                ItemIDtextBox.Text = dataGridView1.SelectedRows[0].Cells["ItemID"].Value.ToString();
                ItemNametextBox.Text = dataGridView1.SelectedRows[0].Cells["ItemName"].Value.ToString();
                PricetextBox.Text = dataGridView1.SelectedRows[0].Cells["Price"].Value.ToString();
                KategorijaTextBox.Text = dataGridView1.SelectedRows[0].Cells["kategorija_id"].Value.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Izbrali ste prazno vrstico.");
            }
        }
    }
}
