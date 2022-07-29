using Common.Message;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementUI.Functions
{
    #region Comment
    /*
     * Here we have created GeneralFunctions class since we will be using extension methods class and methods should be static
     */
    #endregion
    public static class GeneralFunctions
    {
        #region Comment
        /*
         * Here we have created GetRowId extension method when we click Edit button or double click on GridView it will get us our Focused Row Id if we clicked elsewhere then it will give us error
         * 
         */
        #endregion
        public static long GetRowId(this GridView table)
        {
            if (table.FocusedRowHandle>-1)
            {
                return (long)table.GetFocusedRowCellValue("Id");
            }
            else
            {
                Messages.NotSelectedRowId();
            }
            return -1;
        }

        #region Comment
        /*
         * Here we have created GetRow<T> extension method when we click Edit button or double click on GridView it will get us our Focused Row if we clicked elsewhere then it will give us error so when it gives us Row of GridView then on BaseListForm we will convert into BaseEntity because later we will be needing Value of it on our ButtonEdit control amd beside we need its Id number in order to save on our Database
         * 
         */
        #endregion

        public static T GetRow<T>(this GridView table,bool giveMessage=true)
        {
            if (table.FocusedRowHandle>-1)
            {
                return (T)table.GetRow(table.FocusedRowHandle);
            }
            if (giveMessage)
            {
                Messages.NotSelectedRowId();
            }
            return default(T);
        }


    }
}
