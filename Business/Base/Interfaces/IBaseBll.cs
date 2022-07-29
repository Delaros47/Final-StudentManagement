using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Base.Interfaces
{
    #region Comment
    /*
     * Here we have created IBaseBll so in our UI Form we will send all Business class to IBaseBll interface in order to use in BaseForms and also it inherited from IDisposable interface
     */
    #endregion
    public interface IBaseBll:IDisposable
    {
        
    }
}
