﻿using Bookshop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookshop.DataAccess.Repository.IRepository
{
    public interface IOrderHeaderRepository : IRepository<OrderHeader>
    {
        void Update(OrderHeader obj);
    }
}
