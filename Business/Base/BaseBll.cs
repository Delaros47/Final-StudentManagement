using Business.Base.Interfaces;
using Business.Functions;
using Common.Enums;
using Common.Functions;
using Common.Message;
using DataAccess.Interfaces;
using Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business.Base
{
    #region Comment
    /*
     * BaseBll has inherited from the IBaseBll and other entity will be inherited from BaseBll so T is our entity that's  why all Entities are implemented from BaseEntity cause in it we have properties called Id and PrivateCode
     * Here in order to reach our Repository class so we have to use IUnitOfWork cause there is a property we declared in order to reach it
     * And the reason we have made our contructors protected that we want to use only inherited classes from it
     */
    #endregion

    public class BaseBll<T, TContext> : IBaseBll
        where T : BaseEntity
        where TContext : DbContext
    {
        #region Comment
        /*
         * Here we have called IUnitOfWork in order to reach Repository class we make our methods as protected in order to prevent other non inhereted not to be reached
         */
        #endregion

        private readonly Control _ctrl;
        private IUnitOfWork<T> _uow;
        protected BaseBll()
        {

        }

        protected BaseBll(Control ctrl)
        {
            _ctrl = ctrl;
        }

        #region Comment
        /*
         * Here we have created BaseSingle it simple goes Repository class and call Find method in this way we haven't got instance from IUnitOfWork so we will create a function in Business layer so it will create an instance from IUnitOfWork cause if we run like that it will be giving us error
         */
        #endregion

        protected TResult BaseSingle<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            #region Comment
            /*
             * Here we have created instance from UnitOfWork the main reason since our project will have a lot of database and all the time with different connectionString we will be connected so each time it will create new UnitOfWork and Context and the latest connectionString
             */
            #endregion

            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);
            return _uow.Rep.Find(filter, selector);
        }

        #region Comment
        /*
         * Here we have created method will call Select (List) our entities but as query so we can put in the end ToList() or OrderBy and so on
         */
        #endregion

        protected IQueryable<TResult> BaseList<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {

            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);
            return _uow.Rep.Select(filter, selector);

        }

        #region Comment
        /*
         * Here whenever we use insert,update,delete we will mostly be using DataTranforObject DTO and we will not be doing directly with entities and we will be working with DTO so because If we send DTO to repository that it will give error so we have to convert our DTO to entity that's why we create some functions for it named Converts class
         * Here _uow.Rep.Insert(entity.EntityConvert<T>()); we have made converted and then save it on database
         */
        #endregion

        protected bool BaseInsert(BaseEntity entity, Expression<Func<T, bool>> filter)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);
            //Validation will be here later
            _uow.Rep.Insert(entity.EntityConvert<T>());
            return _uow.Save();
        }

        #region Comment
        /*
         * Here in BaseUpdate we will send to entities one is old other is current and surely we will not be updating all of them only changed fields we will compare to each other in GeneralFunctions class so we will be updating only changed fields
         * if in changed fields if we have no values then we return true 
         */
        #endregion

        protected bool BaseUpdate(BaseEntity oldEntity, BaseEntity currentEntity, Expression<Func<T, bool>> filter)
        {

            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);
            //Validation will be here later
            var changedFields = oldEntity.GetChangedFields(currentEntity);
            if (changedFields.Count == 0) return true;
            _uow.Rep.Update(currentEntity.EntityConvert<T>(), changedFields);
            return _uow.Save();
        }

        #region Comment
        /*
         * Here BaseDelete it will simple delete our entity and give message what has deleted as for message in common layer we have created FormType enums we will define all our Forms whenever we want to delete any of them automaticlly will be giving us message what we have deleted it
         * giveMessage means that sometimes we will not be giving our message maybe another approvement so as default we put true but when we don't want to use it that we will set it to false
         * If giveMessage is true then we get our FormType attribute description then it send to DeleteMessage and shows us dialog
         */
        #endregion

        protected bool BaseDelete(BaseEntity entity,FormType formType,bool giveMessage=true)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);
            if (giveMessage)
                if (Messages.DeleteMessage(formType.ToName()) != DialogResult.Yes) return false;
            _uow.Rep.Delete(entity.EntityConvert<T>());
           return _uow.Save();

        }

        #region Comment
        /*
         * Here will dispose our _ctrl and _uow will not dispose our Bll if we do that it will give error in runtime
         * Here _ctrl?.Dispose(); if _ctrl is not null then Dispose it
         */
        #endregion

        public void Dispose()
        {
            _ctrl?.Dispose();
            _uow?.Dispose();
        }
    }
}
