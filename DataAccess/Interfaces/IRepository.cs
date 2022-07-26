using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    #region Comment
    /* IRepository it is our Repository Design Pattern and we have inherited from IDisposable interface so whenever our class done that it will dispose from the memory
     * T:class means that it will be only be referance type except it don't accept it and our entities will be used for that
     * 
     */
    #endregion
    public interface IRepository<T>:IDisposable where T:class
    {
        #region Comment
        /*
         * Insert will be adding one entity to our database
         */
        #endregion
        void Insert(T entity);
        #region Comment
        /*
         * Insert(IEnumerable<T> entities) will be adding multiable entities to our database
         */
        #endregion
        void Insert(IEnumerable<T> entities);
        #region Comment
        /*
         * Update will be updating our entity to our database
         */
        #endregion
        void Update(T entity);
        #region Comment
        /*
         * Update will be updating our changed fields entity to our database not all of them in this way it will be more performanced
         */
        #endregion
        void Update(T entity,IEnumerable<string> fields);
        #region Comment
        /*
         * Update will be updating multiply entities in our database
         */
        #endregion
        void Update(IEnumerable<T> entities);
        #region Comment
        /*
         * Delete will be deleting one entity in our database
         */
        #endregion
        void Delete(T entity);
        #region Comment
        /*
         * Delete will be deleting multiple entities in our database
         */
        #endregion
        void Delete(IEnumerable<T> entities);
        #region Comment
        /*
         * Here our Find method that simply will go to with expression find one entity data in our database and return with as TResult first expression return bool but second one returns TResult so it will function normally
         */
        #endregion
        TResult Find<TResult>(Expression<Func<T,bool>> filter,Expression<Func<T,TResult>> selector);
        #region Comment
        /*
         * Here IQueryable is SqlServer query type in the end of it we can add OrderBy,ToList(),or Counts or other queries
         * and it will bring multiple data from the database
         */
        #endregion
        IQueryable<TResult> Select<TResult>(Expression<Func<T,bool>> filter,Expression<Func<T,TResult>> selector);
    }
}
