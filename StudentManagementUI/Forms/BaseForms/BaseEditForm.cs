﻿using Business.Base.Interfaces;
using Common.Enums;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Model.Entities.Base;
using StudentManagementUI.UserControls.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementUI.Forms.BaseForms
{
    public partial class BaseEditForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Comment
        /*
         * Here we have declared ProccessType enum in ShowEditForms when a user wants to insert entity or updated entity we will identify from here and in ShowEditForms if id =-1 then it will be set EntityInsert if id is different then -1 then it will be EntityUpdate will be set here 
         * Here we have Id value when we open our EditForms from ListForms it bring id and set it in EditForms in order to make updates
         * WillRefresh is going to tell us if we did some changes on EditForms and we want refresh in ListForms so we will simply put true or false here
         * MyDataLayoutControl DataLayoutControl; Here in order to use events on EditForms we have send dataLayoutControl to BaseEditForm since all controls are inside dataLayoutControl
         * IBaseBll Bll; here we will make update,delete and insert
         * Here we have BaseEntity OldEntity; and BaseEntity CurrentEntity; on our EditForms if we try to update an entity first on EditForm first it will get our OldEntity in our EditForms then if we try to click the save then it will save current entity into CurrentEntity then it will compare both of them if there are any changes then it will save and it returns id into ListForm and it will be focused on its Row 
         */
        #endregion
        protected internal ProccessType ProccessType;
        protected internal long Id;
        protected internal bool WillRefresh;
        protected internal MyDataLayoutControl DataLayoutControl;
        protected FormType FormType;
        protected IBaseBll Bll;
        protected BaseEntity OldEntity;
        protected BaseEntity CurrentEntity;

        public BaseEditForm()
        {
            InitializeComponent();
        }

        #region Comment
        /*
         * Here we have created EventsLoad method so it will invoke whenever we click any buttons in our EditForms
         */
        #endregion
        protected void EventsLoad()
        {
            foreach (var item in ribbonControl.Items)
            {
                switch (item)
                {
                    case BarItem buttons:
                        buttons.ItemClick += Buttons_ItemClick;
                        break;
                    default:
                        break;
                }
            }
        }
        #region Comment
        /*
         * Here our Buttons click events work 
         */
        #endregion
        private void Buttons_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (e.Item==btnNew)
            {
                ProccessType = ProccessType.EntityInsert;
                MyEditLoad();
            }
            else if (e.Item==btnSave)
            {
                EntitySave(false);
            }
            else if (e.Item==btnUndo)
            {
                EntityUndo();
            }
            else if (e.Item==btnDelete)
            {
                EntityDelete();
            }
            else if (e.Item==btnExit)
            {
                Close();
            }
            

            
        }

        private void EntityDelete()
        {
            
        }

        private void EntityUndo()
        {
            
        }

        private void EntitySave(bool v)
        {
            
        }
        #region Comment
        /*
         * Here is our virtual method simply will be override in other 
         */
        #endregion
        protected internal virtual void MyEditLoad()
        {

        }

        protected virtual void BindEntityToControls()
        {

        }
    }
}