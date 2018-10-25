using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    class HardwareItem:Item
    {
        public int Weight { get; set; }

        public HardwareItem() { }

        public HardwareItem(int itemID, string itemName, double price, int weight) : base(itemID, itemName, price)
        {
            Weight = weight;
        }

        public override string ToString() // neka metoda //overide- pozabi na tostring ki ga je dobil od Object-a
        {
            string stringToReturn;
            stringToReturn = "Hardware: " + ItemName + ", Cena: " + Convert.ToString(Price) + " € , Teža: "+Weight+" kg";
            return stringToReturn;
        }
    }
}
