using Data.StudentManagementMigration;
using Model.Entities;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace Data.Contexts
{
    #region Comment
    /* Here also StudentManagamentContext is simply one of our database
     * Here we have added ADO.NET Entity Data Model to Data/Contexts folder so it automaticlly created like below and now since we will be using two context Normal Student Management Context another for Administration Context so since we will do some changes from both of them we will create generic BaseDbContext then StudetManagement will be implemented from it.if we didn't create our own Context then we should write the same codes in StudentManagementContext and AdministrationContext as well since BaseDbContext is generic first value asks for Context so we gave our Context second ask for TConfiguration and it is all about our migration and its options now we will create another class for it
     */
    #endregion
    public class StudentManagementContext : BaseDbContext<StudentManagementContext,Configuration>
    {
        #region Comment
        /*
         * Here we have added two contructors since base one has two also because even in baseclass still we have to connection string from our base to main base
         * LazyLoadingEnabled = false; means for example in our School table we have City and District are connected when we make Dto that we only need CityName not Description on State or Private code of it so LazyLoadingEnabled=false; will not bring everything only what we want that it will bring in this way we have more performance
         */
        #endregion
        public StudentManagementContext()
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public StudentManagementContext(string connectionString) : base(connectionString)
        {
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region Comment
            /*
             * Conventions.Remove<PluralizingTableNameConvention>(); for example when our School entity when it start creating database that it will not make it plural table name in Database for example in our database our table name will be School as well not Schools 
             * Conventions.Remove<OneToManyCascadeDeleteConvention>(); means for example City and District are connected  whenever we delete any City name so it will not delete Districts who are
             * Conventions.Remove<ManyToManyCascadeDeleteConvention>(); it is the same but Many to Many relationship
             */
            #endregion
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }

        public DbSet<School> School { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<District> District { get; set; }


    }


}