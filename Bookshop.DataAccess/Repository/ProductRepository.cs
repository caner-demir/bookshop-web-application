using Bookshop.DataAccess.Data;
using Bookshop.DataAccess.Repository.IRepository;
using Bookshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookshop.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product product)
        {
            var ObjFromDb = _db.Products.FirstOrDefault(s => s.Id == product.Id);

            if (ObjFromDb != null)
            {
                if (product.ImageUrl != null)
                {
                    ObjFromDb.ImageUrl = product.ImageUrl;
                }

                ObjFromDb.ISBN = product.ISBN;
                ObjFromDb.Price = product.Price;
                ObjFromDb.Price50 = product.Price50;
                ObjFromDb.Price100 = product.Price100;
                ObjFromDb.ListPrice = product.ListPrice;
                ObjFromDb.Title = product.Title;
                ObjFromDb.Description = product.Description;
                ObjFromDb.CategoryId = product.CategoryId;
                ObjFromDb.Author = product.Author;
                ObjFromDb.CoverTypeId = product.CoverTypeId;
            }
        }
    }
}
