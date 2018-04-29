using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolaNaukowe.web.Repositories
{
    public interface IGenericRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        TEntity Add(TEntity item);
        void Update(TEntity item);
        void Remove(int id);
    }
}
