using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using _08_3.EFExample.AutoLotDAL.Models;
using _08_3.EFExample.AutoLotDAL.Models.Base;

namespace _08_3.EFExample.AutoLotDAL.Repos
{
    public class BaseRepo<T> : IDisposable, IRepo<T> where T : EntityBase, new()
    {
        private readonly DbSet<T> _table;
        private readonly AutoLotEntities _db;
        public BaseRepo()
        {
            _db = new AutoLotEntities();
            _table = _db.Set<T>();
        }
        protected AutoLotEntities Context => _db;
        public int Add(T entity)
        {
            _table.Add(entity);
            return SaveChanges();
        }

        public int AddRange(IList<T> entities)
        {
            _table.AddRange(entities);
            return SaveChanges();
        }

        public int Delete(int id, byte[] timeStamp)
        {
            _db.Entry(new T() { Id = id, Timestamp = timeStamp }).State = EntityState.Deleted;
            return SaveChanges();
        }

        public int Delete(T entity)
        {
            _db.Entry(entity).State = EntityState.Deleted;
            return SaveChanges();
        }

        public void Dispose()
        {
            _db?.Dispose();
        }

        public List<T> ExecuteQuery(string sql)
        {
            return _table.SqlQuery(sql).ToList();
        }

        public List<T> ExecuteQuery(string sql, object[] sqlParametersObjects)
        {
            return _table.SqlQuery(sql, sqlParametersObjects).ToList();
        }

        public List<T> GetAll()
        {
            return _table.ToList();
        }

        public T GetOne(int? id)
        {
            return _table.Find(id);
        }

        public int Save(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            return SaveChanges();
        }





        internal int SaveChanges()
        {
            try
            {
                return _db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                //Thrown when there is a concurrency error
                throw;
            }
            catch (DbUpdateException ex)
            {
                //Thrown when database update fails
                //Examine the inner exception(s) for additional
                //details and affected objects
                throw;
            }
            catch(CommitFailedException ex)
            {
                //handle transaction failures here
                throw;
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
