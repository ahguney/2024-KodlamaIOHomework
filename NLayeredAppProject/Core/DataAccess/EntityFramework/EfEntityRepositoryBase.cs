using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TDbContext, TId> : IEntityRepository<TEntity, TId>
        where TEntity : class, IEntity<TId> , new() 
        where  TDbContext : DbContext,new()
    {
        public void Add(TEntity entity)
        {
            using (var context = new TDbContext())
            {
                //entity.CreatedAt = DateTime.UtcNow;
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TDbContext())
            {
                //entity.DeletedAt = DateTime.UtcNow;
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity? Get(Expression<Func<TEntity,bool>> expression = null)
        {
            using (var context = new TDbContext())
            {
                return expression == null
                     ? context.Set<TEntity>().FirstOrDefault()
                     : context.Set<TEntity>().FirstOrDefault(expression);
            }
        }

        public IList<TEntity> GetList(Expression<Func<TEntity,bool>> expression = null)
        {
            using (var context = new TDbContext())
            {
                return expression == null
                     ? context.Set<TEntity>().ToList()
                     : context.Set<TEntity>().Where(expression).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new TDbContext())
            {
                //entity.UpdatedAt = DateTime.UtcNow;
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
