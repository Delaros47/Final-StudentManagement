using Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Base.Interfaces
{
    #region Comment
    /*
     * Here we have declared an interface named IBaseGeneralBll and we will be using it in our BaseEditForm there will be use it for Insert,Update and for generating Private Code and in order to use these interfaces on BaseEditForms our SchoolBll should implemented from IBaseGeneralBll
     */
    #endregion
    public interface IBaseGeneralBll
    {
        bool Insert(BaseEntity entity);

        bool Update(BaseEntity oldEntity, BaseEntity currenyEntity);

        string GivePrivateCode();
    }
}
