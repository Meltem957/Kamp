using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> products;
        private List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId = 1,CategoryId = 1,ProductName = "Bardak",UnitPrice = 15,UnitsInStock = 15},
                new Product{ProductId = 2,CategoryId = 1,ProductName = "Kamera",UnitPrice = 500,UnitsInStock = 3},
                new Product{ProductId = 3,CategoryId = 2,ProductName = "Telefon",UnitPrice = 1500,UnitsInStock = 2},
                new Product{ProductId = 4,CategoryId = 2,ProductName = "Klavye",UnitPrice = 150,UnitsInStock = 65},
                new Product{ProductId = 5,CategoryId = 2,ProductName = "Fare",UnitPrice = 85,UnitsInStock = 1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.productId == product.ProductId);
            _products.Remove(product);
        }
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId = 1,CategoryId = 1,ProductName = "Bardak",UnitPrice = 15,UnitsInStock = 15},
                new Product{ProductId = 2,CategoryId = 1,ProductName = "Kamera",UnitPrice = 500,UnitsInStock = 3},
                new Product{ProductId = 3,CategoryId = 2,ProductName = "Telefon",UnitPrice = 1500,UnitsInStock = 2},
                new Product{ProductId = 4,CategoryId = 2,ProductName = "Klavye",UnitPrice = 150,UnitsInStock = 65},
                new Product{ProductId = 5,CategoryId = 2,ProductName = "Fare",UnitPrice = 85,UnitsInStock = 1}
            };
        }
    }

        public List<Product> GetAll()
        {
        return _products;
        }

        public void Update(Product product)
        {
          if (productToUpdate != null)
          {
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
           }
        }
    }
}
