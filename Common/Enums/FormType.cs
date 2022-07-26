using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Enums
{
    #region Comment
    /*
     * Here we have created FormType so all forms name will be here and we will make attributes for them in order to give messages what we have deleted or updated or added 
     * byte since we will not have more than 100 forms that's why we have used byte
     * Here [Description("School Record")] we will create another another EnumFunction class so we will be getting Description from it
     */
    #endregion

    public enum FormType:byte
    {
        [Description("School Record")]
        School=1,
        [Description("City Record")]
        City =2,
        [Description("District Record")]
        District =3
    }
}
