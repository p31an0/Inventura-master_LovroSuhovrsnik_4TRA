using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    public class SoftwareItem : Item
    {
        public string LicenceKey { get; set; }
        public int SizeInMB { get; set; }

        public SoftwareItem()
        {

        }

        public SoftwareItem(int itemID, string itemName, double price, string licenceKey, int sizeInMB) : base (itemID, itemName, price)
        {
            LicenceKey = licenceKey;
            SizeInMB = sizeInMB;
        }

        public override string ToString() // neka metoda //overide- pozabi na tostring ki ga je dobil od Object-a
        {
            string stringToReturn;
            stringToReturn = "Software: "+ItemName+", Cena: "+Convert.ToString(Price)+ " €. Velikost v MB: "+SizeInMB+" MB";
            return stringToReturn;
        }
    }
}
