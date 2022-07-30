using Common.Enums;
using Common.Message;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using Model.Entities.Base;
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
            if (table.FocusedRowHandle > -1)
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

        public static T GetRow<T>(this GridView table, bool giveMessage = true)
        {
            if (table.FocusedRowHandle > -1)
            {
                return (T)table.GetRow(table.FocusedRowHandle);
            }
            if (giveMessage)
            {
                Messages.NotSelectedRowId();
            }
            return default(T);
        }

        #region Comment
        /*
         * Here our method GetDataChangedPlace it is enum method it will simply compare two entities if there are any changes then it will let us know according to this one we will enable or disable our buttons  so it returns us value as enums
         */
        #endregion
        private static DataChangedPlace GetDataChangedPlace<T>(T oldEntity, T currentEntity)
        {
            foreach (var prop in currentEntity.GetType().GetProperties())
            {
                #region Comment
                /*
                 * Here later we will be using on our Entities ICollection<> generic interface in order to reach each other Entities so if our value is ICollection then it will continue cause it is not our Entity field that's why we put a condition like that here
                 * oldValue we get the value if it is null then we convert into string.Empty because since we cannot compare Null values with each other this ?? checks if our value is null then it assigns Empty value there (?? it checks if it is null if it null first value it will be our assign) 
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
                    if (string.IsNullOrEmpty(currentEntity.ToString()))
                    {
                        currentValue = new byte[] { 0 };
                    }

                    if (((byte[])oldValue).Length != ((byte[])currentValue).Length)
                    {
                        return DataChangedPlace.EditForm;
                    }

                }
                else if (!currentValue.Equals(oldValue))
                {

                    return DataChangedPlace.EditForm;
                }
            }
            return DataChangedPlace.NoChangeData;
        }

        #region Comment
        /*
         * Here ButtonEnabledState method is that first it will send our GetDataChangedPlace enum will send to method oldEntity and currentEntity then it will make some compared to each other then it returns as enum value if it EditForm then it is true 0 when it returns EditForm then our btnSave.Enabled and btnUndo.Enabled will be true then btnNew and btnDelete will be false ! makes then reverse
         */
        #endregion
        public static void ButtonEnabledState<T>(BarButtonItem btnNew, BarButtonItem btnSave, BarButtonItem btnUndo, BarButtonItem btnDelete, T oldEntity, T currentEntity)
        {

            var dataChangedPlace = GetDataChangedPlace(oldEntity, currentEntity);
            var buttonEnabledState = dataChangedPlace == DataChangedPlace.EditForm;
            btnSave.Enabled = buttonEnabledState;
            btnUndo.Enabled = buttonEnabledState;
            btnNew.Enabled = !buttonEnabledState;
            btnDelete.Enabled = !buttonEnabledState;

        }

        #region Comment
        /*
         * Here we will create method called CreateId so basiclly it will generate id as long data type in order to set our Id in entities
         */
        #endregion
        public static long CreateId(this ProccessType proccessType,BaseEntity selectedEntity)
        {

            string AddZero(string value)
            {
                if (value.Length==1)
                {
                    return "0"+value;
                }
                else
                {
                    return value;
                }
            }

            string MakeThreeDigits(string value)
            {
                switch (value.Length)
                {
                    case 1:
                        return "00" + value;
                    case 2:
                        return "0" + value;
                }
                return value;
            }


            string Id()
            {
                var year = AddZero(DateTime.Now.Date.Year.ToString());
                var month = AddZero(DateTime.Now.Date.Month.ToString());
                var day = AddZero(DateTime.Now.Date.Day.ToString());
                var hour = AddZero(DateTime.Now.Hour.ToString());
                var minute = AddZero(DateTime.Now.Minute.ToString());
                var second = AddZero(DateTime.Now.Second.ToString());
                var millisecond = MakeThreeDigits(DateTime.Now.Millisecond.ToString());
                var random = AddZero(new Random().Next(0,99).ToString());
                 
                return year + month + day + hour + minute + second + millisecond + random;

            }
            return proccessType == ProccessType.EntityUpdate ? selectedEntity.Id : long.Parse(Id());



        }


    }
}
