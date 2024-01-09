namespace Assignments
{/// <summary>
/// Parent class called product
/// </summary>
        public class Product
        {
        //public string ProductName;
        //public string ProductID;
        //public double ProductPrice;
        //public int ProductQuantity;
        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// T
        /// </summary>
        /// <param name="productName">Mouse</param>
        /// <param name="productID">ELe12</param>
        /// <param name="productPrice">500</param>
        /// <param name="productQunatity">100</param>
        public Product(string productName, string productID, double productPrice, int productQunatity)
            {
                this.ProductName = productName;
                this.ProductID = productID;
                this.ProductPrice = productPrice;
                this.ProductQuantity = productQunatity;
            }
        /// <summary>
        /// Gets or sets ProductName
        /// </summary>
        /// <value>
        /// Mouse
        /// </value>
        public string ProductName { get; set; }
        /// <summary>
        /// Gets or sets Productid
        /// </summary>
        /// <value>
        /// ele12
        /// </value>
        public string ProductID { get; set; }
        /// <summary>
        /// Gets or sets ProductPrice
        /// </summary>
        /// <value>
        /// productprice
        /// </value>
        public double ProductPrice { get; set; }
        /// <summary>
        /// Gets or sets ProductQuantity
        /// </summary>
        /// <value>
        /// ProductQuantity
        /// </value>
        public int ProductQuantity { get; set; }
        }    
}