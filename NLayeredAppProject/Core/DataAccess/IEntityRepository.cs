using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<TEntity,TId>
        where TEntity : class, IEntity<TId> ,new()
    {
        IList<TEntity> GetList(Expression<Func<TEntity,bool>> expression = null);
        TEntity Get(Expression<Func<TEntity,bool>> expression=null);
        void Add(TEntity entity);

        void Update(TEntity entity);    

        void Delete(TEntity entity);
    }
}
