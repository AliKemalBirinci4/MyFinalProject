using DataAcces1.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces1.Concrete.InMemory
{
   

    public class InMemoryProductDal : IProductDal
    {
        List<Product>? _products;
        public InMemoryProductDal()
        {
            //Oracle,Sql server,Postgres
            _products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=45,UnitsInStock=15},
                new Product{ProductId=2,CategoryId=1,ProductName="kamera",UnitPrice=500,UnitsInStock=3},
                new Product{ProductId=3,CategoryId=2,ProductName="telefon",UnitPrice=1500,UnitsInStock=2 },
                new Product{ProductId=4,CategoryId=2,ProductName="klavye",UnitPrice=150,UnitsInStock=65},
                new Product{ProductId=5,CategoryId=2,ProductName="fare",UnitPrice=85,UnitsInStock=1}
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete =  _products.SingleOrDefault(product1=>product1.ProductId==product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(product => product.CategoryId==categoryId).ToList();   
        }

        public void Update(Product product)
        {

            //gönderdiğim ürün id'sine sahip olan listedeki ürünü bul 
            Product productToUpdate = _products.SingleOrDefault(product1 => product1.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
