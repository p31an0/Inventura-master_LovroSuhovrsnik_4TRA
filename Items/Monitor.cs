using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    public class Monitor:HardwareItem
    {
        public string Resolution { get; set; }
        public string MonitorType { get; set; }

        public Monitor()
        {

        }

        public Monitor(int itemID, string itemName, double price, int weight, string resolution, string monitor_type) : base(itemID, itemName, price, weight)
        {
            Resolution = resolution;
            MonitorType = monitor_type;
        }

        public override string ToString() // neka metoda //overide- pozabi na tostring ki ga je dobil od Object-a
        {
            string stringToReturn;
            stringToReturn = "Monitor: " + ItemName + ", Cena: " + Convert.ToString(Price) + " € , Teža: " + Convert.ToString(Weight) + " kg, Resolucija: " + Resolution + ", Tip monitorja: " + MonitorType +".";
            return stringToReturn;
        }
    }
}
