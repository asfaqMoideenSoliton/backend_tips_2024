using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace Assignments
{ /// <summary>
/// JKbdnck
/// </summary>
    internal partial class Program
    {
        private static List<Product> _productList = new List<Product>();
        /// <summary>
        /// Method to add products
        /// </summary>
        /// <param name="productName">Mouse</param>
        /// <param name="productID">ele12</param>
        /// <param name="productPrice">500</param>
        /// <param name="productQunatity">100</param>
        private static void Main()
        {
            string option;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("Please Enter a Option");
                Console.WriteLine("[V]iew all Products");
                Console.WriteLine("[A]dd a Product");
                Console.WriteLine("[E]dit a Product");
                Console.WriteLine("[D]elete a Product");
                Console.WriteLine("[S]earch Product");
                Console.WriteLine("[Q]uit");
                option = Console.ReadLine();

                if (option != null)
                {
                    if (option == "V" || option == "v")
                    {
                        ViewProducts();
                    }
                    else if (option == "A" || option == "a")
                    {
                        AddPrducts();
                    }
                    else if (option == "E" || option == "e")
                    {
                        EditProduct();
                    }
                    else if (option == "D" || option == "d")
                    {
                        DeleteProduct();
                    }
                    else if (option == "S" || option == "s")
                    {
                        SearchProducts();
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid option");
                    }
                }
            }
            while (option != "Q" && option != "q");
        }
        private static void AddPrducts()
        {
            bool temp, temp1;
            int proQuantity;
            double proPrice;
            Console.WriteLine("Enter Product Name");
            string proName = Console.ReadLine();
            Console.WriteLine("Enter Product !D");
            string proID = Console.ReadLine();

            do
            {
               Console.WriteLine("Enter Product Price (Type - Double)");
               string tempPrice = Console.ReadLine();
               temp = double.TryParse(tempPrice, out proPrice);   
            } 
            while(temp != true);
            do
            {
                Console.WriteLine("Enter Product Quantity (Type - Integer)");
                string tempQuan = Console.ReadLine();
                temp1 = int.TryParse(tempQuan, out proQuantity);
            }
            while(temp1 != true);

            Console.WriteLine("Product Added");
            Product product = new Product(proName, proID, proPrice, proQuantity);
            _productList.Add(product);

            Console.WriteLine("[A]dd another Product or [M]enu");
            string option = Console.ReadLine();
            if (option == "A" || option == "a")
            {
                AddPrducts();
            }
            else
            {
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("Redirecing to Menu");
              // Main();
            }
        }
        private static void ViewProducts()
        {
            if (_productList.Count > 0)
            {
                Console.WriteLine("List of Products");
                foreach (var products in _productList)
                {
                    Console.WriteLine("Product Name" + "\t" + "Product ID" + "\t" + "Product Price" + "Available Quantity");
                    Console.WriteLine(products.ProductName + "\t" + products.ProductID + "\t" + products.ProductPrice + "\t" + products.ProductQuantity);
                }
            }
            else
            {
                Console.WriteLine("No Products yet");
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("Redirecing to Menu");
               // Main();
            }
        }
        private static void SearchProducts()
        {
            if (_productList.Count > 0)
            {
                Console.WriteLine("Enter Name or ID of the Product");
                string searchName = Console.ReadLine();
                foreach (var products in _productList)
                {
                    if (products.ProductName == searchName || products.ProductID == searchName)
                    {
                        Console.WriteLine("You Might Want");
                        Console.WriteLine("ProductName :" + products.ProductName + "\n" + "ProductID:" + products.ProductID +
                            "\n" + "ProductPrice: " + products.ProductPrice + "\n" + "ProductQuantity" + products.ProductQuantity + "\t");
                    }
                }
            }
            else
            {
                Console.WriteLine("No Products yet");
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("Redirecing to Menu");
                //Main();
            }
        } 
        private static void DeleteProduct()
        {
            if (_productList.Count > 0)
            {
                Console.WriteLine("Enter Name or ID of the Product to Delete");
                string searchName = Console.ReadLine();
                for (int i = 0; i < _productList.Count; i++)
                {
                    foreach (var products in _productList)
                    {
                        if (products.ProductName == searchName || products.ProductID == searchName)
                        {
                            Console.WriteLine("You Might Want to delete");
                            Console.WriteLine("ProductName :" + products.ProductName + "\n" + "ProductID:" + products.ProductID +
                                "\n" + "ProductPrice: " + products.ProductPrice + "\n" + "ProductQuantity: " + products.ProductQuantity + "\t");
                            Console.WriteLine("Confirm Deletion of Product - [Y]es - [C]ancel");
                            string option = Console.ReadLine();

                            if (option == "Y" || option == "y")
                            {
                                _productList.RemoveAt(i);
                                Console.WriteLine("Product Deleted :(");
                                Main();
                            }
                            else if (option == "C" || option == "c")
                            {
                                Main();
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No Products yet");
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("Redirecing to Menu");
                Main();
            }
        }
        private static void EditProduct()
        {
            if (_productList.Count > 0) 
            {
                Console.WriteLine("Enter Name or ID of the Product to Edit");
                string searchName = Console.ReadLine();
                for (int i = 0; i < _productList.Count; i++)
                {
                    foreach (var products in _productList)
                    {
                        if (products.ProductName == searchName || products.ProductID == searchName)
                        {
                            Console.WriteLine("You Might Want to delete");
                            Console.WriteLine("ProductName :" + products.ProductName + "\n" + "ProductID:" + products.ProductID +
                                "\n" + "ProductPrice: " + products.ProductPrice + "\n" + "ProductQuantity: " + products.ProductQuantity + "\t");
                            Console.WriteLine("Confirm Editing the Product - [Y]es - [C]ancel");
                            string option = Console.ReadLine();

                            if (option == "Y" || option == "y")
                            {
                                bool temp, temp1;
                                int proQuantity;
                                double proPrice;
                                Console.WriteLine("Enter Product Name");
                                string proName = Console.ReadLine();
                                Console.WriteLine("Enter Product !D");
                                string proID = Console.ReadLine();

                                do
                                {
                                    Console.WriteLine("Enter Product Price (Type - Double)");
                                    string tempPrice = Console.ReadLine();
                                    temp = double.TryParse(tempPrice, out proPrice);
                                }
                                while (temp != true);
                                do
                                {
                                    Console.WriteLine("Enter Product Quantity (Type - Integer)");
                                    string tempQuan = Console.ReadLine();
                                    temp1 = int.TryParse(tempQuan, out proQuantity);
                                }
                                while (temp1 != true);
                                _productList[i].ProductName = proName;
                                _productList[i].ProductID = proID;
                                _productList[i].ProductPrice = proPrice;
                                _productList[i].ProductQuantity = proQuantity;
                                Console.WriteLine("Product Edited Succesfully :)");
                            }
                            else if (option == "C" || option == "c")
                            {
                                Main();
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No Products yet");
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("Redirecing to Menu");
            }
        }
    }
}