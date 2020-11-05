using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Get(int id);
        IQueryable<T> GetAll();

    }
}
