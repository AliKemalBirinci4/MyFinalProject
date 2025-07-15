// See https://aka.ms/new-console-template for more information
using System;
using Business.Concrete;
using DataAcces1.Concrete.EntityFramework;
using DataAcces1.Concrete.InMemory;

 public class Program
{
    private static void Main(string[] args)
    {
        ProductManager productManager = new ProductManager(new EfProductDal());

        foreach (var product in productManager.GetAll())
        {
            Console.WriteLine(product.ProductName);
        }

        Console.WriteLine("Can not get");

        
    
    }
}


