using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Enums
{
    #region Comment
    /*
     * Here we created enum that whenever we are on our EditForm or NonChild Table(GridView) if we change any updates then our data will be compared to each other OldEntity and CurrentEntity if we have any changes that it will let us know but main thing here where we are trying to make any updates we use this enum as method in GeneralFunctions in UI class
     */
    #endregion
    public enum DataChangedPlace
    {
        EditForm,
        Table,
        NoChangeData
    }
}
