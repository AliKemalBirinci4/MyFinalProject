using Business.Concrete;
using DataAcces1.Concrete.EntityFramework;
using Entities.Concrete;
using NUnit.Util;

namespace CoreNew
{
    public class Class1
    {
        private static void Main(string[] args)
        {
            var context = new NorthwindContext();

            ProductTest();

            CategoryManager categorManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }




        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetByUnitPrice(40, 100))
            {
                Console.WriteLine(product.productName);
            }
        }
    }
}