using System;

namespace _13Ocak2021_2.GunOdevi
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product() { Id = 10, CategoryId = 3, Brand = "Adidas", ProductName="Hoodie", 
                UnitPrice=179.90, DiscountedPrice=149.90, UnitsInStock=45 };

            Product product2 = new Product() { Id=13, CategoryId=5, Brand="Nike", ProductName= "Sneakers", 
                UnitPrice=649.90, DiscountedPrice=599.90, UnitsInStock=22 };

            Product product3 = new Product() { Id=17, CategoryId=6, Brand="Puma", ProductName="T-shirt", 
                UnitPrice=99.99, DiscountedPrice=79.99, UnitsInStock=17};

            Product[] products = new Product[] {product1, product2, product3 };

            Console.WriteLine("-------------------- For loop --------------------");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Product name is "+products[i].ProductName+".");
                Console.WriteLine("Its brand is "+products[i].Brand+".");
                Console.WriteLine("Its price is " + products[i].UnitPrice+" lira.");
                Console.WriteLine("Its discounted price is "+products[i].DiscountedPrice+" lira.");
                Console.WriteLine(products[i].UnitsInStock + " left in stock.");
                Console.WriteLine("----------------------------------");
            }

            Console.WriteLine("-------------------- Foreach loop --------------------");

            foreach (Product product in products)
            {
                Console.WriteLine("Product name is " + product.ProductName + ".");
                Console.WriteLine("Its brand is " + product.Brand + ".");
                Console.WriteLine("Its price is " + product.UnitPrice + " lira.");
                Console.WriteLine("Its discounted price is " + product.DiscountedPrice + " lira.");
                Console.WriteLine(product.UnitsInStock + " left in stock.");
                Console.WriteLine("----------------------------------");

            }

            Console.WriteLine("-------------------- While loop --------------------");


            int x = 0;
            while (x<3)
            {
                Console.WriteLine("Product name is " + products[x].ProductName + ".");
                Console.WriteLine("Its brand is " + products[x].Brand + ".");
                Console.WriteLine("Its price is " + products[x].UnitPrice + " lira.");
                Console.WriteLine("Its discounted price is " + products[x].DiscountedPrice + " lira.");
                Console.WriteLine(products[x].UnitsInStock + " left in stock.");
                Console.WriteLine("----------------------------------");

                x++;
            }
            Console.WriteLine("----------------- Add the product to the cart -----------------");

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Add(product2);
            productManager.Add(product3);

        }
    }
}
