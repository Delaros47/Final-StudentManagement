using Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementUI.Functions
{
    public class FilterFunctions
    {
        #region Comment
        /*
         * Here we have created Filter function it returns expressin and our T type is our Entities such as School,City,District it sets the State of our expression and returns back
         */
        #endregion
        public static Expression<Func<T,bool>> Filter<T>(bool showActiveList) where T: BaseEntityState
        {
            return x => x.State == showActiveList;
        }
        #region Comment
        /*
         * Here we have created Filter function it returns expressin and our T type is our Entities such as School,City,District it sets our Id value
         */
        #endregion
        public static Expression<Func<T,bool>> Filter<T>(long id) where T:BaseEntityState
        {
            return x => x.Id == id;
        }

    }
}
