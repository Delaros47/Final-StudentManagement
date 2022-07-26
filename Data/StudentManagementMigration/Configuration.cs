using Data.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.StudentManagementMigration
{
    #region Comment
    /*
     * Here we have create a class Configuration just to write our code option regarding Migrations so since it is just for StudentManagementContext so we set it on Generic then we created a constructor we will write our codes here now
     */
    #endregion
    public class Configuration:DbMigrationsConfiguration<StudentManagementContext>
    {

        public Configuration()
        {
            #region Comment
            /*
             * AutomaticMigrationsEnabled means that always auto update our migration when class is called 
             * AutomaticMigrationDataLossAllowed whenever we update our database if there are some changes for example from long to int when it updates we allow the data loss
             */
            #endregion
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

    }
}
