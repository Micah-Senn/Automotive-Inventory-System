using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Software1
{
    class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> Parts = new BindingList<Part>();

        public static void Populate()
        {
            Product truck = new Product(1, "Truck", 30000, 12, 10, 15);
            Product car = new Product(2, "Car", 15000, 8, 5, 10);
            Product dieselTruck = new Product(3, "Diesel Truck", 60000, 4, 4, 8);

            Products.Add(truck);
            Products.Add(car);
            Products.Add(dieselTruck);
            

            // add mach ids and comp names
            Part part1 = new InHousePart(1, "Hood", 400, 2, 1, 2, 012);
            Part part2 = new InHousePart(2, "Grille", 250, 3, 1, 4, 017);
            Part part3 = new InHousePart(3, "Bumper", 340, 1, 1, 2, 012);
            Part part4 = new InHousePart(4, "Fender", 150, 4, 2, 4, 012);
            Part part5 = new OutsourcedPart(5, "Spark Plug", 15, 8, 8, 16, "CarZone");
            Part part6 = new OutsourcedPart(6, "High Pressure Pump", 600, 2, 1, 4, "TechShop");
            Part part7 = new OutsourcedPart(7, "Distributor", 120, 4, 2, 6, "CarZone");
            Part part8 = new OutsourcedPart(8, "Glow Plug", 10, 16, 8, 16, "TechShop");

            Parts.Add(part1);
            Parts.Add(part2);
            Parts.Add(part3);
            Parts.Add(part4);
            Parts.Add(part5);
            Parts.Add(part6);
            Parts.Add(part7);
            Parts.Add(part8);

             //Add parts to respective Products
            truck.AssociatedParts.Add(part1);
            truck.AssociatedParts.Add(part2);
            truck.AssociatedParts.Add(part3);
            truck.AssociatedParts.Add(part4);
            truck.AssociatedParts.Add(part5);
            truck.AssociatedParts.Add(part7);
            car.AssociatedParts.Add(part1);
            car.AssociatedParts.Add(part3);
            car.AssociatedParts.Add(part4);
            car.AssociatedParts.Add(part5);
            dieselTruck.AssociatedParts.Add(part6);
            dieselTruck.AssociatedParts.Add(part8);
            
        }

        // Products Methods
        public static void AddProduct(Product prod)
        {
            Products.Add(prod);
        }

        // TO TEST
        public bool RemoveProduct(int productID)
        {
            bool success = false;
            foreach (Product prod in Products)
            {
                if (productID == prod.ProductID)
                {
                    Products.Remove(prod);
                    return success = true;
                }
                else
                {
                    MessageBox.Show("Removal failed.");
                    return false;
                }
            }
            return success;
        }

        // TO FINISH - not all paths return a value
        public static Product LookupProduct(int productID)
        {
            foreach (Product prod in Products)
            {
                if (prod.ProductID == productID)
                {
                    return prod;
                }
            }
            Product emptyProd = new Software1.Product();
            return emptyProd;
        }

        public static void ModifyProduct(int productID, Product modifyProduct)
        {
            foreach (Product currentProd in Products)
            {
                if (currentProd.ProductID == productID)
                {
                    currentProd.Name = modifyProduct.Name;
                    currentProd.Current_Inventory = modifyProduct.Current_Inventory;
                    currentProd.Price = modifyProduct.Price;
                    currentProd.Max = modifyProduct.Max;
                    currentProd.Min = modifyProduct.Min;
                    currentProd.AssociatedParts = modifyProduct.AssociatedParts;
                    return;
                }
            }

        }

       
        public static void AddPart(Part part)
        {
            Parts.Add(part);
        }

        
        public bool DeletePart(Part part)
        {
            try
            {
                Parts.Remove(part);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Part LookupPart(int partID)
        {
            foreach (Part part in Parts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            Part emptyPart = null;//new InHousePart();
            return emptyPart;
        }

        public static void ModifyInHousePart(int partID, InHousePart inHousePart)
        {
            for (int i = 0; i < Parts.Count; i++)
            {
                if (Parts[i].GetType() == typeof(Software1.InHousePart))
                {
                    InHousePart newPart = (InHousePart)Parts[i];

                    if (newPart.PartID == partID)
                    {
                        newPart.Name = inHousePart.Name;
                        newPart.Current_Inventory = inHousePart.Current_Inventory;
                        newPart.Price = inHousePart.Price;
                        newPart.Min = inHousePart.Min;
                        newPart.Max = inHousePart.Max;
                        newPart.MachineID = inHousePart.MachineID;
                    }
                }
            }
        }
        public static void ModifyOutsourcedPart(int partID, OutsourcedPart outsourcedPart)
        {
            for (int i = 0; i < Parts.Count; i++)
            {
                if (Parts[i].GetType() == typeof(Software1.OutsourcedPart))
                {
                    OutsourcedPart newPart = (OutsourcedPart)Parts[i];

                    if (newPart.PartID == partID)
                    {
                        newPart.Name = outsourcedPart.Name;
                        newPart.Current_Inventory = outsourcedPart.Current_Inventory;
                        newPart.Price = outsourcedPart.Price;
                        newPart.Min = outsourcedPart.Min;
                        newPart.Max = outsourcedPart.Max;
                        newPart.CompanyName = outsourcedPart.CompanyName;
                    }
                }
            }
        }
    }
}