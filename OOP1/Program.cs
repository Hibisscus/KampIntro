using System; 


namespace OOP1
{
    class Program
    {

        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 510;
            product1.UnitInStock = 3;

            //Bu şekildede Tanımlayabilirz

            Product product1 = new Product {Id = 2, CategoryId = 5, UnitInStock = 10, 
                UnitPrice=35, ProductName="Kalem"  };

            //pascalcase    //camelcase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

        }
    }
}