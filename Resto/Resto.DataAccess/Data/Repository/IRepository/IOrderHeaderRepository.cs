using System;
using System.Collections.Generic;
using System.Text;
using Resto.Models;

namespace Resto.DataAccess.Data.Repository.IRepository
{
    public interface IOrderHeaderRepository : IRepository<OrderHeader>
    {
        void Update(OrderHeader orderHeader);
    }
}
