# Inventory Management Console

## Features
 -User friendly Console
 -Error free Product Entry
 -Stores in Memory (Run Time)
 -Ale to search edit and delete with product name and IDs
 -Easy to debug as uses different methods inside the class
 -Menu Bar for easy access 

 ## Class

 The parent class Product is used and the Each product is created as objects in that instance. 
 Lis of objects were created to store products with its aspects. This list of objects makes easily accesbile 
 and user friendly

 ## Methods

 ### AddProduct()

  Product product = new Product(proName, proID, proPrice, proQuantity);
  _productList.Add(product);

 It uses List.Add() to add the objects in the list _productLit
 Only add the elements as defined, .i.e
 Name - String, ProductID - String, Price - Double or Int, Quantity - Int
 Used do while loop and try parse to have this error handling
 Each Product will have objects of the CLass Product. 
 
 ### DeleteProduct()

 The index of the object in the list _productList is acceses via a for loop which is iterated with count of list
 by the index value the element i.e object is deleted via a fuction

  _productList.RemoveAt(i);

  Removes the particular element i.e object craeted for the product


 ### ViewProducts()

 Foreach loop is used to acces the filed of the objects which is stored in the list. which will print the all details of 
 all products in the list

   foreach (var products in _productList)
                {
                    Console.WriteLine("Product Name" + "\t" + "Product ID" + "\t" + "Product Price" + "Available Quantity");
                    Console.WriteLine(products.ProductName + "\t" + products.ProductID + "\t" + products.ProductPrice + "\t" + products.ProductQuantity);
                }
this above code snippet is used to print the values
****It will only executed if the list has some items in it. it will show no pruducts if the list is empty

 ### EditProduct()

 Same as delete product a for loop which returns the index of the object is retuned the specific 

  _productList[i].ProductName = proName;
  _productList[i].ProductID = proID;
  _productList[i].ProductPrice = proPrice;
  _productList[i].ProductQuantity = proQuantity;

  this is edited with syntax used in the above code snippets


****It will only executed if the list has some items in it. it will show no pruducts if the list is empty

 ## SearchProduct()

 This method is as same as we used in edit and delete products. But it just checks the entered product ID or Name is equal to the existing 
 one in the list if its same it print the details. 

 foreach (var products in _productList)
                {
                    if (products.ProductName == searchName || products.ProductID == searchName)
                    {
                        Console.WriteLine("You Might Want");
                        Console.WriteLine("ProductName :" + products.ProductName + "\n" + "ProductID:" + products.ProductID +
                            "\n" + "ProductPrice: " + products.ProductPrice + "\n" + "ProductQuantity" + products.ProductQuantity + "\t");
                    }
                }
this code snippet expians the method
 ****It will only executed if the list has some items in it. it will show no pruducts if the list is empty  