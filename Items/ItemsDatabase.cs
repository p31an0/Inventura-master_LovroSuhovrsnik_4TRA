using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Items
{
    public class ItemsDatabase
    {
        private SQLiteConnection con;

        public ItemsDatabase()
        {
            con = new SQLiteConnection("datasource=itemsDatabase.db");
            con.Open();
           
        }

        public bool SaveItem(Item itemToSave)
        {
            
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "INSERT INTO Izdelki (ItemID, ItemName, Price) VALUES ('" + itemToSave.ItemID + "', '" + itemToSave.ItemName + "', '" + itemToSave.Price + "')";
                com.ExecuteNonQuery();
                com.Dispose();
            }            

            return true;
                
        }

        public Item ReadItem(int ID)
        {
            Item toReturn = null;

            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "SELECT * FROM Izdelki WHERE ItemID = '"+ID+"'";
                SQLiteDataReader reader = com.ExecuteReader();               

                
                if(reader.HasRows)
                {
                    reader.Read();

                    toReturn = new Item(reader.GetInt32(0),reader.GetString(1),reader.GetDouble(2));

                }                               
                com.Dispose();
                reader.Close();

            }
            return toReturn;

        }

        //ReadItem(int ID) - vrne en Item
        //ReadItems() - prebere in vrne vse
        //UpdateItem(int ID, Item itemToUpdate)

        public bool UpdateItem(Item toUpdate)
        {
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "UPDATE Izdelki SET ItemName ='"+toUpdate.ItemName+"',Price = '"+toUpdate.Price+"' WHERE ItemID = '"+ toUpdate.ItemID + "';";
                //com.CommandText = "UPDATE Izdelki SET (ItemName ='CPU',Price =500) WHERE ItemID =1;";
                com.ExecuteNonQuery();
                com.Dispose();

            }
            return true;


        }

        public bool DeleteItem(Item toDelete)
        {
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText ="DELETE FROM Izdelki WHERE ItemID = '"+toDelete.ItemID+"';";
                com.ExecuteNonQuery();
                com.Dispose();
            }
            return true;
        }
        //DeleteItem(int ID)
    }
}
