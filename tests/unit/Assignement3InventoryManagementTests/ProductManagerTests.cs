using Assignments;
namespace Assignement3InventoryManagementTests
{
    public class ProductManagerTests
    {

        [Theory]
        [InlineData("1223")]
        [InlineData("12.134")]
        [InlineData("12.1")]
        public void ValidDoubleProductPrice_IsProductPricePositiveDouble_ReturnsTrue(string productPrice)
        {
            var productManager = new ProductManager();
            double productPriceOutput;

            var result = productManager.IsProductPricePositiveDouble(productPrice, out productPriceOutput);

            Assert.True(result);
        }

        [Theory]
        [InlineData("Ten")]
        [InlineData("Hundred")]
        [InlineData("-1000")]
        public void InvalidDoubleProductPrice_IsProductPricePositiveDouble_ReturnsFalse(string productPrice)
        {
            var productManager = new ProductManager();
            double productQuantityOutput;

            var result = productManager.IsProductPricePositiveDouble(productPrice, out productQuantityOutput);

            Assert.False(result);
        }

        [Theory]
        [InlineData("1223")]
        [InlineData("12")]
        public void ValidIntProductQuantityInt_IsProductQuantityUInt_ReturnsTrue(string productQuantity)
        {
            var productManager = new ProductManager();
            uint productQuantityOutput;

            var result = productManager.IsProductQuantityUInt(productQuantity, out productQuantityOutput);

            Assert.True(result);
        }
        [Theory]
        [InlineData("Ten")]
        [InlineData("Hundred")]
        [InlineData("-1")]
        public void InValidIntProductQuantityInt_IsProductQuantityUInt_ReturnsFalse(string productQuantity)
        {
            var productManager = new ProductManager();
            uint productPriceOutput;

            var result = productManager.IsProductQuantityUInt(productQuantity, out productPriceOutput);

            Assert.False(result);
        }


        [Theory]
        [InlineData("Mouse", "ELE12", 450, 20)]
        public void InputProductDetails_AddProductToTheList_ProductAdded(string productName, string productID, double productPrice, uint productQuantity)
        {
            ProductManager productManager = new ProductManager();
            Product product = new Product(productName, productID, productPrice, productQuantity);

            productManager.AddProductsToTheList(product);

            Assert.Contains(product, productManager.GetProducts());
        }
        [Theory]
        [InlineData("Sony Mouse", "ELE13", 500, 30)]

        public void InputProductDetails_EditProductWithreference_ProductEditted(string newProuctName, string newProductID, double newProductPrice, uint newProductQuanity)
        {
            var (product, productManager) = CreateProduct();

            productManager.EditProductsWithReference(product, newProuctName, newProductID, newProductPrice, newProductQuanity);

            Assert.Contains(product, productManager.GetProducts());

        }

        [Theory]
        [InlineData("Mouse")]

        public void AddedProductsToThelist_IsProductNameUnique_ReturnsFalse(string newProuctName)
        {
            var (product, productManager) = CreateProduct();

            var Result = productManager.IsProductNameExists(newProuctName);

            Assert.True(Result);

        }

        [Theory]
        [InlineData("KeyBoard")]
        public void AddedProductsToThelist_IsProductNameUnique_ReturnsTrue(string newProductName)
        {
            var (product, productManager) = CreateProduct();

            var Result = productManager.IsProductNameExists(newProductName);

            Assert.False(Result);
        

        }

        [Theory]
        [InlineData("ELE12")]
        public void AddedProductsToThelist_IsProductIdUnique_ReturnsTrue(string newProuctID)
        {
            var (product, productManager) = CreateProduct();

            var Result = productManager.IsProductIDExists(newProuctID);

            Assert.True(Result);

        }

        [Theory]
        [InlineData("ELE13")]
        public void AddedProductsToThelist_IsProductIdNotUnique_ReturnsFalse(string newProuctID)
        {
            var (product, productManager) = CreateProduct();

            var Result = productManager.IsProductIDExists(newProuctID);

            Assert.False(Result);

        }

        [Theory]
        [InlineData("Mouse")]
        public void AddedproductsToTheList_SearchProductsInTheList_ReturnsTheInstance(string searchNameOrID)
        {
            var (product, productManager) = CreateProduct();

            Product result = productManager.SearchProductInTheList(searchNameOrID);

            Assert.Equal(product, result);
        }

        [Theory]
        [InlineData("ELE13")]
        public void AddedproductsToTheList_SearchProductsNotInTheList_ReturnsNull(string searchNameOrID)
        {
            var (product, productManager) = CreateProduct();

            Product result = productManager.SearchProductInTheList(searchNameOrID);

            Assert.Null(result);
        }

        [Theory]
        [InlineData("Mouse1")]
        public void AddedproductsToTheList_TryingToRemoveproductWithDifferentProductName_ConatainsIntheList(string searchNameOrID)
        {
            var (product, productManager) = CreateProduct();

            Product result = productManager.SearchProductInTheList(searchNameOrID);

            productManager.DeleteProductFromTheList(result);

            Assert.Contains(product, productManager.GetProducts());
        }

        [Theory]
        [InlineData("Mouse")]
        public void AddedproductsToTheList_RemoveProductsFromTheList_DoesNotConatainIntheList(string NameOrIDToDelete)
        {
            var (product, productManager) = CreateProduct();
            Product result = productManager.SearchProductInTheList(NameOrIDToDelete);

            productManager.DeleteProductFromTheList(result);

            Assert.DoesNotContain(product, productManager.GetProducts());
        }


        public (Product, ProductManager) CreateProduct()
        {
            Product product = new Product("Mouse", "ELE12", 450, 20);
            ProductManager productManager = new ProductManager();
            productManager.AddProductsToTheList(product);
            return (product, productManager);

        }

    }
}
