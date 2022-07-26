using DataAccess.Base;
using DataAccess.Interfaces;
using Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;


namespace Business.Functions
{
    public static class GeneralFunctions
    {
        #region Comment
        /*
         * Here we will get oldEntity and currentEntity and we will be comparing them to each other if any fields are changed that then we will be getting them from here 
         * Here fields is IList<string> we will save changed fields inside it
         * then from foreach we will be getting Properties from currentEntity
         */
        #endregion

        public static IList<string> GetChangedFields<T>(this T oldEntity, T currentEntity)
        {
            IList<string> fields = new List<string>();
            foreach (var prop in currentEntity.GetType().GetProperties())
            {
                #region Comment
                /*
                 * Here later we will be using on our Entities ICollection<> generic interface in order to reach each other Entities so if our value is ICollection then it will continue cause it is not our Entity field that's why we put a condition like that here
                 * oldValue we get the value if it is null then we convert into string.Empty because since we cannot compare Null values with each other this ?? checks if our value is null then it assigns Empty value there
                 *  If our values are byte[] means that it is a image of picture so we have to check and assign its value if it is empty of null so we will put 0 in order not to be null then we will compare to each other if they are not equal that then it is a new image or picture has been added to our database then we will save it as its Name in our fields IList<string> 
                 */
                #endregion

                if (prop.PropertyType.Namespace == "System.Collections.Generic") continue;
                var oldValue = prop.GetValue(oldEntity) ?? string.Empty;
                var currentValue = prop.GetValue(currentEntity) ?? string.Empty;

                if (prop.PropertyType == typeof(byte[]))
                {
                    if (string.IsNullOrEmpty(oldValue.ToString()))
                    {
                        oldValue = new byte[] { 0 };
                    }
                    if (string.IsNullOrEmpty(currentValue.ToString()))
                    {
                        currentValue = new byte[] { 0 };
                    }

                    if (((byte[])oldValue).Length != ((byte[])currentValue).Length)
                    {
                        fields.Add(prop.Name);
                    }

                }
                else if (!currentValue.Equals(oldValue))
                {
                    #region Comment
                    /*
                     * Here if our oldEntity and currentEntity values are not equal then we have to save in our IList<string> as well
                     */
                    #endregion
                    fields.Add(prop.Name);
                }
            }
            return fields;

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
