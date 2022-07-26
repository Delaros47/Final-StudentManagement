using Business.Base;
using Data.Contexts;
using Model.Entities;
using Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business.General
{
    public class SchoolBll : BaseBll<School, StudentManagementContext>
    {
        protected SchoolBll()
        {

        }

        protected SchoolBll(Control ctrl) : base(ctrl)
        {

        }

        public BaseEntity Single(Expression<Func<School,bool>> filter)
        {
            return BaseSingle(filter,);
        }
    }
}
