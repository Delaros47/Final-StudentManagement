using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Contexts
{
    #region Comment
    /*
     * Here TContext will be our Context and TConfiguration is that regarding our Migration options will be here 
     * we have created a constructor and we have to send connectionString to it base constructor since it asks name or ConnectionString in order to send to base it should be static so we created a static field and we have set a default value typeof(TContext).Name it is reflection it just take TContext name whatever it is, it can be StudentManagementContext so in order to not be null we have sent just TContext name
     */
    #endregion
    public class BaseDbContext<TContext,TConfiguration>:DbContext
        where TContext:DbContext
        where TConfiguration:DbMigrationsConfiguration<TContext>,new()
    {
        private static string _nameOrConnectionString=typeof(TContext).Name;
        #region Comment
        /*
         * We will be using this Constructor only in Administration Module when we create a database and delete database and we will not be using beside that purpose if we want to general usage then we will create another constructor so we will be using it
         *  
         */
        #endregion
        public BaseDbContext():base(_nameOrConnectionString)
        {

        }
        #region Comment
        /*
         * This constructor will be used for others cause since the project will contain many databases and always will be changed so we will write a new constructor now
         *  
         */
        #endregion
        public BaseDbContext(string connectionString):base(connectionString)
        {
            #region Comment
            /*
             * We have set _nameOrConnectionString = connectionString; cause first time above will work but other times this constructor will work and we will set it
             *  Database.SetInitializer will simply will always go for checking our entities and if there are any updates that it will make changes on our database if not it will not update anything
             */
            #endregion
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TContext,TConfiguration>());
            _nameOrConnectionString = connectionString;
        }


    }
}
