using Inventory2.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory2
{
    internal class Inventory
    {
        public static BindingList<Part> Parts = new BindingList<Part>();
        public static BindingList<Product> Products = new BindingList<Product>();

        public static void ExampleItems()
        {
            Product exampleProd = new Product(1, "Car", 5000.00m, 6, 1, 8);
            Products.Add(exampleProd);

            Product exampleProd2 = new Product(2, "Dirt Bike", 300.00m, 10, 1, 20);
            Products.Add(exampleProd2);


            Part examplePart = new InPart(1, "Chain", 20.00m, 3, 1, 50, "asf3234");
            Parts.Add(examplePart);

            Part examplePart2 = new OutPart(2, "Engine", 800.00m, 2, 1, 5, "Ford");
            Parts.Add(examplePart2);
        }

        //
        //IN HOUSE PART ADD
        //

        public static void AddInHousePart(string name, string price, string inStock, string min, string max, string machID)
        {
            try
            {
                decimal d = decimal.Parse(price);
                int stock = Int32.Parse(inStock);
                int mi = Int32.Parse(min);
                int ma = Int32.Parse(max);


                if (mi >= ma)
                {
                    MessageBox.Show("The minimum cannot be equal to or greater than the maximum.");
                    return;
                }
                else if (stock > ma || stock < mi)
                {
                    MessageBox.Show("The Inventory quantity must be within the values of Minimum and Maximum.");
                    return;
                }

                InPart newInPart = new InPart(45, name, d, stock, mi, ma, machID);
                Parts.Add(newInPart);
            }
            catch { MessageBox.Show("Letters can only be used in the Name and Machine ID fields."); }

            foreach (Part part in Parts)
            {
                part.PartID = Parts.IndexOf(part) + 1;
            }
        }

        //
        //OUT HOUSE PART ADD
        //

        public static void AddOutHousePart(string name, string price, string inStock, string min, string max, string company)
        {
            try
            {
                decimal d = decimal.Parse(price);
                int stock = Int32.Parse(inStock);
                int mi = Int32.Parse(min);
                int ma = Int32.Parse(max);

                if (mi >= ma)
                {
                    MessageBox.Show("The minimum cannot be equal to or greater than the maximum.");
                    return;
                }

                OutPart newOutPart = new OutPart(45, name, d, stock, mi, ma, company);
                Parts.Add(newOutPart);
            }
            catch { MessageBox.Show("Letters can only be used in the Name and Company Name fields."); }

            foreach (Part part in Parts)
            {
                part.PartID = Parts.IndexOf(part) + 1;
            }
        }

        //
        //ADD UPDATED PART
        //

        public static void UpdateInHousePart(string name, string price, string inStock,
                                             string min, string max, string machID, int id)
        {
            try
            {
                decimal d = decimal.Parse(price);
                int stock = Int32.Parse(inStock);
                int mi = Int32.Parse(min);
                int ma = Int32.Parse(max);


                if (mi >= ma)
                {
                    MessageBox.Show("The minimum cannot be equal to or greater than the maximum.");
                    return;
                }
                else if (stock > ma || stock < mi)
                {
                    MessageBox.Show("The Inventory quantity must be within the values of Minimum and Maximum.");
                    return;
                }

                for (int i = 0; i < Parts.Count; i++)
                {
                    Part p = Inventory.Parts[i];
                    if (p.PartID == id)
                    {
                        Inventory.Parts.Remove(p);

                        InPart newInPart = new InPart(id, name, d, stock, mi, ma, machID);

                        Inventory.Parts.Add(newInPart);
                    }
                }
            }
            catch { MessageBox.Show("Letters can only be used in the Name and Machine ID fields."); }

        }
        public static void UpdateOutHousePart(string name, string price, string inStock, string min, string max, string company, int id)
        {
            try
            {

                decimal d = decimal.Parse(price);
                int stock = Int32.Parse(inStock);
                int mi = Int32.Parse(min);
                int ma = Int32.Parse(max);


                if (mi >= ma)
                {
                    MessageBox.Show("The minimum cannot be equal to or greater than the maximum.");
                    return;
                }
                else if (stock > ma || stock < mi)
                {
                    MessageBox.Show("The Inventory quantity must be within the values of Minimum and Maximum.");
                    return;
                }

                for (int i = 0; i < Parts.Count; i++)
                {
                    Part p = (Part)Parts[i];
                    if (p.PartID == id)
                    {
                        Inventory.Parts.Remove(p);

                        OutPart newOutPart = new OutPart(id, name, d, stock, mi, ma, company);

                        Inventory.Parts.Add(newOutPart);
                    }
                }
            }
            catch { MessageBox.Show("Letters can only be used in the Name and Machine ID fields."); }

        }

        //
        //ADD NEW PRODUCT
        //

        public static void CreateNewProduct(string name, string price, string stock,
                                            string min, string max)
        {
            try
            {
                decimal d = decimal.Parse(price);
                int s = Int32.Parse(stock);
                int mi = Int32.Parse(min);
                int ma = Int32.Parse(max);
                int id = Inventory.Products.Count + 1;

                if (mi >= ma)
                {
                    MessageBox.Show("The minimum cannot be equal to or greater than the maximum.");
                    return;
                }
                else if (s > ma || s < mi)
                {
                    MessageBox.Show("Inventory stock must be between the values of minimum and maximum.");
                    return;
                }

                Product prod = new Product(id, name, d, s, mi, ma);
                foreach (Part part in AddProductForm.AddedParts)
                {
                    prod.AssociatedParts.Add(part);
                }
                Products.Add(prod);
                return;
            }
            catch { MessageBox.Show("Letters can only be used in the Name and Company Name fields."); }
        }

        public static void UpdateProduct(string name, string price, string inStock,
                                         string min, string max, int id)
        {
            try
            {
                decimal d = decimal.Parse(price);
                int stock = Int32.Parse(inStock);
                int mi = Int32.Parse(min);
                int ma = Int32.Parse(max);

                if (mi >= ma)
                {
                    MessageBox.Show("The minimum cannot be equal to or greater than the maximum.");
                    return;
                }
                else if (stock > ma || stock < mi)
                {
                    MessageBox.Show("The Inventory quantity must be within the values of Minimum and Maximum.");
                    return;
                }
                else 
                { 
                    for (int i = 0; i < Products.Count; i++)
                    {
                        Product p = Products[i];
                        if (p.ProductID == id)
                        {
                            p.ProductName = name;
                            p.ProductPrice = d;
                            p.ProductInStock = stock;
                            p.ProductMin = mi;
                            p.ProductMax = ma;

                            p.AssociatedParts.Clear();

                            foreach (Part part in ModifyProductForm.AddedParts)
                            {
                                p.AssociatedParts.Add(part);
                            }
                            
                        }
                    }
                }
            }
            catch { MessageBox.Show("Letters can only be used in the Name and Machine ID fields."); }
        }
    }
}
