using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    #region Comment
    /*
     * IUnitOfWork will do update,select,delete,insert at once to our database,simple if we want to add a city in our database IUnitOfWork will insert to our database
     */
    #endregion
    public interface IUnitOfWork<T>:IDisposable where T:class
    {
        #region Comment
        /*
         *Here with Rep we can access to all Repository<T> functions
         */
        #endregion
        IRepository<T> Rep { get; }
        #region Comment
        /*
         * Save function will return when data is saved or nor or any changes happen or not we will know exactly any changes happened or not
         */
        #endregion
        bool Save();
    }
}
