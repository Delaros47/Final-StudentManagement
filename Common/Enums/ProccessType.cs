using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Enums
{
    #region Comment
    /*
     * Here we have created ProccessType enum this enum when in our ShowEditForms when we click New or (double click - Edit button)
     * If we we set EntityInsert then user click New button if it set EntityUpdate then user has clicked either double click or Edit button
     */
    #endregion
    public enum ProccessType
    {
        EntityInsert,
        EntityUpdate
    }
}
