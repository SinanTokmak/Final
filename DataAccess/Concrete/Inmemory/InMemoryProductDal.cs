using DataAccess.Abstract;
using DataAccess.DTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Inmemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>{
            new Product { CategoryID = 1, ProductId = 1, ProductName = "Merkez Bankası", UnitPrice = 128000000000, UnitsInStock = 1 },
            new Product { CategoryID = 2, ProductId = 2, ProductName = "Dinozor Heykeli", UnitPrice = 750000000, UnitsInStock = 1 },
            new Product { CategoryID = 3, ProductId = 3, ProductName = "VIP Uçak", UnitPrice = 400000000, UnitsInStock = 1 },
            new Product { CategoryID = 4, ProductId = 1, ProductName = "Kanal Istanbul", UnitPrice = 20000000000, UnitsInStock = 1 },
            new Product { CategoryID = 5, ProductId = 3, ProductName = "Mercedes-Maybach S 600 Pullmann Guard", UnitPrice = 80000000, UnitsInStock = 32000 },
        };

        }

        public List<Product> GetAll()
        {
            return _products;
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            #region This is old system. Prefer use Linq..
            /*
            Product productTodelete = null;
            foreach (var p in _products)
            {
                if(product.ProductID == p.ProductID)
                {
                    productTodelete = p;
                }
            }

            _products.Remove(productTodelete);*/
            #endregion

            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
        }

        public List<Product> GetAllByCategory(int categoryID)
        {
            return _products.Where(p => p.CategoryID == categoryID).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.ProductId = product.ProductId;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
