// See https://aka.ms/new-console-template for more information
using System;
using Business.Concrete;
using DataAcces1.Concrete.EntityFramework;
using DataAcces1.Concrete.InMemory;

public class Program
{

    private static void Main(string[] args)
    {
        var context = new NorthwindContext();

        if (CheckDatabaseConnection(context))
        {
            Console.WriteLine("Veritabanına başarıyla bağlanıldı!");
        }
        else
        {
            Console.WriteLine("Veritabanına bağlantı sağlanamadı.");
        }

        foreach (var item in context.Products.ToList())
        {
            Console.WriteLine($"Item Value {item.ProductName}");
        }


        /*ProductManager productManager = new ProductManager(new EfProductDal());

        foreach (var product in productManager.GetAll())
        {
            Console.WriteLine(product.ProductName);
        }

        Console.WriteLine("Can not get");*/


    }
    public static bool CheckDatabaseConnection(NorthwindContext context)
    {
        try
        {
            return context.Database.CanConnect();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Hata: {ex.Message}");
            return false;
        }

    }
}


