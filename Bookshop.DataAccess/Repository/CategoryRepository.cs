using Bookshop.DataAccess.Data;
using Bookshop.DataAccess.Repository.IRepository;
using Bookshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookshop.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            var ObjFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);

            if (ObjFromDb != null)
            {
                ObjFromDb.Name = category.Name;
            }
        }
    }
}
