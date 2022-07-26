using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities.Base
{
    #region Comment
    /*
     * Here when we have in our EditForm ToggleSwitch then we will be implementing from BaseEntityState since it implemented from BaseEntity it means that it contains Id,PrivateCode,State if it doesn't contain ToggleSwitch then only it will be implemented from BaseEntity
     */
    #endregion
    public class BaseEntityState:BaseEntity
    {
        public bool State { get; set; } = true;
    }
}
