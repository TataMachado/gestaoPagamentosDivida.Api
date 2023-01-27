
using gestaoPagamentoDivida.Domain.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace gestaoPagantoDivida.Repository
{
    public class RepositoryEntity<TEntity>: IRepositoryEntity<TEntity> where TEntity:class
    {
        private readonly SqlDatabaseContext sqlDatabaseContext;
        public RepositoryEntity(SqlDatabaseContext sqlDatabaseContext)

        {
            this.sqlDatabaseContext = sqlDatabaseContext;   

        }
        public void Add(TEntity obj)
        {
            try
            {
                sqlDatabaseContext.Set<TEntity>().Add(obj);
                sqlDatabaseContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public TEntity entityGet(string id)
        {
            return sqlDatabaseContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return sqlDatabaseContext.Set<TEntity>().ToList();
        }

        public void Remove(TEntity obj)
        {
            try
            {
                sqlDatabaseContext.Set<TEntity>().Remove(obj);
                sqlDatabaseContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(TEntity obj)
        {
            try
            {
                sqlDatabaseContext.Entry(obj).State=(EntityState.Modified);
                sqlDatabaseContext.SaveChanges();
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}