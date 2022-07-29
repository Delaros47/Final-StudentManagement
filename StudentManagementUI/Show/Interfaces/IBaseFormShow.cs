using Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementUI.Show.Interfaces
{
    #region Comment
    /*
     * Here we declared an interface thanks to this interface we will send all our EditForms into it then it will open it since Interface keeps referances of other 
     */
    #endregion
    public interface IBaseFormShow
    {
        long ShowDialogEditForm(FormType formType, long id);
    }
}
