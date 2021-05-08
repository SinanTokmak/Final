using Business.Concrete;
using DataAccess.Concrete.EntitiyFramework;
using DataAccess.Concrete.Inmemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            

            foreach (var product in productManager.GetAll())
            {
                //Console.WriteLine("Ürün adı: " + product.ProductName + " Fiyatı: " + product.UnitPrice + " Stok " + product.UnitsInStock);
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
