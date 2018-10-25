using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    class Computer : HardwareItem
    {
        public int NoOfCores { get; set; }
        public int AmountOfRAM { get; set; }
        public int HDDSize { get; set; }

        public Computer(int itemID, string itemName, double price, int weight, int noofcores, int amountofram, int hdddsize ) : base(itemID, itemName, price, weight)
        {
            NoOfCores = noofcores;
            AmountOfRAM = amountofram;
            HDDSize = hdddsize;
            
        }

        public override string ToString() // neka metoda //overide- pozabi na tostring ki ga je dobil od Object-a
        {
            string stringToReturn;
            stringToReturn = "Computer: " + ItemName + ", Cena: " + Convert.ToString(Price) + " € , Teža: " + Weight + " kg, Količina RAM: "+AmountOfRAM+" GB, Število jeder: "+NoOfCores+", Velikost trdega diska: "+HDDSize+"GB.";
            return stringToReturn;
        }
    }
}
