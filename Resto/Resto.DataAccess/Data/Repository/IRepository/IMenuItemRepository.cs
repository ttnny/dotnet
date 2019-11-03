using System;
using System.Collections.Generic;
using System.Text;
using Resto.Models;

namespace Resto.DataAccess.Data.Repository.IRepository
{
    public interface IMenuItemRepository : IRepository<MenuItem>
    {
        void Update(MenuItem menuItem);
    }
}
