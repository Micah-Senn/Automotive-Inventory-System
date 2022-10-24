using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software1
{
    public class InHousePart : Part
    {
        private int machineID;
        public int MachineID { get; set; }
        public InHousePart() { }
        public InHousePart(int partID, string name, decimal price, int inStock, int min, int max)
        {
            PartID = partID;
            Name = name;
            Current_Inventory = inStock;
            Price = price.ToString();
            Min = min;
            Max = max;
        }
        public InHousePart(int partID, string name, decimal price, int inStock, int min, int max, int machineID)
        {
            PartID = partID;
            Name = name;
            Price = price.ToString();
            Current_Inventory = inStock;
            Min = min;
            Max = max;
            MachineID = machineID;
        }

    }
}
