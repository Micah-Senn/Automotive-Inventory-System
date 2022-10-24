using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software1
{
    public class OutsourcedPart : Part
    {
        private string companyName;
        public string CompanyName { get; set; }
        public OutsourcedPart() { }
        public OutsourcedPart(int partID, string name, decimal price, int inStock, int min, int max)
        {
            PartID = partID;
            Name = name;
            Price = price.ToString();
            Current_Inventory = inStock;
            Min = min;
            Max = max;
        }
        public OutsourcedPart(int partID, string name, decimal price, int inStock, int min, int max, string companyName)
        {
            PartID = partID;
            Name = name;
            Price = price.ToString();
            Current_Inventory = inStock;
            Min = min;
            Max = max;
            CompanyName = companyName;
        }
    }
}
