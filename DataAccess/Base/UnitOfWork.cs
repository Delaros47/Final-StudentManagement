using Common.Message;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Base
{
    #region Comment
    /*
     * Here we said that all our savings will be in UnitOfWork we will send all our queries to Repository class but saving and controlling them will be here only
     */
    #endregion

    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private readonly DbContext _context;
        public UnitOfWork(DbContext context)
        {
            if (context == null) return;
            _context = context;
        }

        #region Comment
        /*
         * Here with Rep property we will be able to access Repository class and use method there that's why we created an instance from it
         */
        #endregion

        public IRepository<T> Rep
        {
            get { return new Repository<T>(_context); }
        }

        #region Comment
        /*
         * Here Save method simply will save entities to database but here we will be catching all errors and warning some of exception we will be catching rest of them general exception class will catch
         */
        #endregion

        public bool Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException exception)
            {
                #region Comment
                /*
                 *Here we have used DbUpdateException since we want to catch exception regarding SqlException so that's why we have used it here exception.InnerException?.InnerException; if it has null then do nothing if not null then return InnerException and also we have converted DbUpdateException into SqlException the reason that if it returns null value then it is another error so it will converted into SqlException then we will be seeing our error in order to completely prevent null value
                 */
                #endregion

                var sqlException = (SqlException)exception.InnerException?.InnerException;
                if (sqlException == null)
                {
                    Messages.ErrorMessage(sqlException.Message);
                    return false;
                }

                #region Comment
                /*
                 *Here we have also used switch some certain known exception as well so we know their number but in default rest of DbUpdateExeption will be there after all _context.SaveChanges(); makes changes on the database
                 */
                #endregion

                switch (sqlException.Number)
                {
                    case 208:
                        Messages.ErrorMessage("The table wasn't found in the database");
                        break;
                    case 547:
                        Messages.ErrorMessage("The table cannot be deleted due to has foreign key with another table");
                        break;
                    case 2601:
                    case 2627:
                        Messages.ErrorMessage("The Id which you entered that has already used please try another Id value");
                        break;
                    case 4060:
                        Messages.ErrorMessage("The database cannot be found in the server");
                        break;
                    case 18456:
                        Messages.ErrorMessage("Invalid Username and password due to connecting to server");
                        break;
                    default:
                        Messages.ErrorMessage(sqlException.Message);
                        break;
                }
                return false;

            }
            catch (Exception exception)
            {
                #region Comment
                /*
                 *Here we have used Exception is all other entire exceptions will be here if it doesn't enter the both of catch then it returns true then save,insert,update,delete successfully functioned there
                 */
                #endregion

                Messages.ErrorMessage(exception.Message);
                return false;
            }
            return true;

        }

        private bool _disposedValue;
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                _disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
