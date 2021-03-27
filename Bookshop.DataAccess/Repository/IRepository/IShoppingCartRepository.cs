using Bookshop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookshop.DataAccess.Repository.IRepository
{
    public interface IShoppingCartRepository : IRepository<ShoppingCart>
    {
        void Update(ShoppingCart obj);
    }
}
