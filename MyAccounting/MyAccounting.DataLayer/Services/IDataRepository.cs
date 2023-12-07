using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyAccounting.DataLayer.Services
{
    public class IDataRepository<TEntity> where TEntity : class
    {  
        //Define connection string
        private MyAccountingDBEntities _db;
        private DbSet<TEntity> _dbSet;

        //Fill in the connection string
        public IDataRepository(MyAccountingDBEntities db)
        {
            _db = db;
            _dbSet = _db.Set<TEntity>();
        }
        // Get all the information
        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity,bool>> where = null)
        {
            IQueryable<TEntity> getall = _dbSet;
            if(where != null)
            {
                getall = getall.Where(where);
            }
            return getall.ToList();
        }
        // Get column by id
        public virtual TEntity GetByID(object id)
        {
            return _dbSet.Find(id);
        }
        //Insert column in the Database
        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }
        //Edit column
        public virtual void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
        }
        //Delete column in the database
        public virtual void Delete(TEntity entity)
        {
            if(_db.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }
        //Delete method overload
        public virtual void Delete(object id)
        {
            var entity = GetByID(id);
            Delete(entity);
        }
        

    }


}
