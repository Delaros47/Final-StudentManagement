using Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities.Base
{
    #region Comment
    /*
     * BaseEntity will be used in our EditForms our other entities will be implemented from it cause here long Id we will create our own long id and send it to the database beside if any EditForm has ToggleSwitch then we will be implementing from BaseEntityState
     */
    #endregion
    public class BaseEntity:IBaseEntity
    {
        public long Id { get; set; }
        public string PrivateCode { get; set; }
    }
}
