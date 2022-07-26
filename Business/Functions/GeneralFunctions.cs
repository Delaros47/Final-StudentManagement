using DataAccess.Base;
using DataAccess.Interfaces;
using Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Functions
{
    public static class GeneralFunctions
    {

        public static IList<string> GetChangedFields<T>(this T oldEntity,T currentEntity)
        {
            IList<string> fields = new List<string>();


        }


        #region Comment
        /*
         * Here we declared a function that it will go to App.Config file and look for StudentManagementContext and bring its ConnectionString 
         */
        #endregion

        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["StudentManagementContext"].ConnectionString;
        }

        #region Comment
        /*
         * Here we create an instance for our Context so then whenever we call our instance that it will bring with itself our ConnectionString as well
         */
        #endregion

        private static TContext CreateContext<TContext>() where TContext : DbContext
        {
            return (TContext)Activator.CreateInstance(typeof(TContext), GetConnectionString());
        }

        #region Comment
        /*
         * Here we create an instance for our UnitOfWork and in the parameters we have put ref cause we want to know the latest situation of it cause we will dispose it each time,
         * Here uow?.Dispose(); if our uow is not null then dispose it from the memory cause we want to create a new instance
         * Here uow = new UnitOfWork<T>(CreateContext<TContext>()); will be creating a new instance of UnitOfWork and with created Context and connectionstring we send to it
         */
        #endregion

        public static void CreateUnitOfWork<T, TContext>(ref IUnitOfWork<T> uow)
            where T : class, IBaseEntity
            where TContext : DbContext
        {
            uow?.Dispose();
            uow = new UnitOfWork<T>(CreateContext<TContext>());
        }
    }
}
