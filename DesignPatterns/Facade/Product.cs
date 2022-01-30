using System;

namespace DotnetWS.DesignPatterns.Facade
{
    public class Product
    {
        public Product()
        {

        }

        public void GetProductDetails()
        {
            Console.WriteLine("Fetching the Product Details");
        }
    }
}