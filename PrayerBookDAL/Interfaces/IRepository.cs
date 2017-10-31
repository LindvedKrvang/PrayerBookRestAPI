using System;
using System.Collections.Generic;
using System.Text;

namespace PrayerBookDAL.Interfaces
{
    public interface IRepository<TEntity>
    {
        TEntity Create(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        bool Delete(int id);
    }
}
