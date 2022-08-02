using Business.Base;
using Business.Base.Interfaces;
using Common.Enums;
using Data.Contexts;
using Model.DTO;
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

    #region Comment
    /*
     * Here each our entity we will be creating class and we have implemented from BaseBll and we have passed the entity as School and Context is StudentManagementContext and other two contructors from BaseBll later we will be reaching them
     */
    #endregion

    public class SchoolBll : BaseBll<School, StudentManagementContext>,IBaseGeneralBll
    {
        public SchoolBll()
        {

        }

        public SchoolBll(Control ctrl) : base(ctrl)
        {

        }

        #region Comment
        /*
         * Here we have our Single function base one it takes T and returns TResult since they are connected so T is our BaseEntity and we have retured it instead of TResult
         * and selector will be on the body of method so 
         * In Model layer we have created SchoolDto class inside it we have two classes first SchoolS it is just for single entity such as when we update or show in our EditForms and SchoolL is for listing our Schools
         */
        #endregion

        public BaseEntity Single(Expression<Func<School,bool>> filter)
        {
            return BaseSingle(filter,x=> new SchoolS
            {
                Id= x.Id,
                PrivateCode = x.PrivateCode,
                SchoolName = x.SchoolName,
                CityId = x.CityId,
                CityName = x.City.CityName,
                DistrictId = x.DistrictId,
                DistrictName = x.District.DistrictName,
                State = x.State,
                Description = x.Description
                
            });
        }

        #region Comment
        /*
         * Here we have our List function so it get all School list and we will be viewed in GridControl
         * also we have made it by order according to Private Code and lastly we put ToList(); so then we can send it to GridControl now. 
         */
        #endregion

        public IEnumerable<BaseEntity> List(Expression<Func<School, bool>> filter)
        {
            return BaseList(filter,x=> new SchoolL
            {
                Id =x.Id,
                PrivateCode = x.PrivateCode,
                SchoolName = x.SchoolName,
                CityName = x.City.CityName,
                DistrictName = x.District.DistrictName,
                Description= x.Description
            }).OrderBy(x=>x.PrivateCode).ToList();
        }

        #region Comment
        /*
         * Here we have our Insert it will simple make single insert in our entity here x=>x.PrivateCode==entity.PrivateCode we will be using for Validations
         */
        #endregion

        public bool Insert(BaseEntity entity)
        {
            return BaseInsert(entity,x=>x.PrivateCode==entity.PrivateCode);
        }

        public bool Update(BaseEntity oldEntity,BaseEntity currenyEntity)
        {
            return BaseUpdate(oldEntity, currenyEntity,x=>x.PrivateCode==currenyEntity.PrivateCode);
        }

        public bool Delete(BaseEntity entity)
        {
            return BaseDelete(entity, FormType.School);
        }

        public string GivePrivateCode()
        {
            throw new NotImplementedException();
        }
    }
}
