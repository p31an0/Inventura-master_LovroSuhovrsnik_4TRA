using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    public class Item
    {
        // prop + 2x TAB
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public double Price { get; set; }

        public double Kategorija { get; set; }

        public Item()
        {

        }

        public Item(int itemid, string itemname, double price) // Konstruktor - Bližnica ctor + 2xTAB
        {

            ItemID = itemid;
            ItemName = itemname;
            Price = price;

        }

        public override string ToString() // neka metoda //overide- pozabi na tostring ki ga je dobil od Object-a
        {
            string stringToReturn;
            stringToReturn = ItemID + " " + ItemName + " " + Price;
            return stringToReturn;
        }
    }

    
}
