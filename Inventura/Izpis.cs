using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            dataGridView1.Rows.Clear();

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
    }
}
