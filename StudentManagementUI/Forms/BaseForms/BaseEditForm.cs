using Business.Base.Interfaces;
using Common.Enums;
using Common.Message;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Model.Entities.Base;
using StudentManagementUI.Functions;
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
         * IsLoaded is that whenever we open our EditForms that if we open and loads the Form is true if not then it is false
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
        protected bool IsLoaded;
        protected bool CloseFormAfterInsert = true;

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

            //Forms Events
            Load += BaseEditForm_Load;
        }

        private void BaseEditForm_Load(object sender, EventArgs e)
        {
            IsLoaded = true;
            CreateUpdatedEntity();
            Id = ProccessType.CreateId(OldEntity);
        }
        #region Comment
        /*
         * Here our Buttons click events work 
         */
        #endregion
        private void Buttons_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (e.Item == btnNew)
            {
                ProccessType = ProccessType.EntityInsert;
                MyEditLoad();
            }
            else if (e.Item == btnSave)
            {
                EntitySave(false);
            }
            else if (e.Item == btnUndo)
            {
                EntityUndo();
            }
            else if (e.Item == btnDelete)
            {
                EntityDelete();
            }
            else if (e.Item == btnExit)
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
        #region Comment
        /*
         * Here we have created EntitySave method and it takes boolen parameter if it is true then EditFormCloseMessage will be shown to us if not then SaveMessage will be shown to us
         */
        #endregion
        private bool EntitySave(bool editFormClosed)
        {
            bool SaveProccess()
            {
                Cursor.Current = Cursors.WaitCursor;
                switch (ProccessType)
                {
                    case ProccessType.EntityInsert:
                        if (EntityInsert())
                            return AfterInsertProccess();
                        break;
                    case ProccessType.EntityUpdate:
                        if (EntityUpdate())
                            AfterInsertProccess();
                        break;
                }

                bool AfterInsertProccess()
                {
                    OldEntity = CurrentEntity;
                    WillRefresh = true;
                    ButtonsEnableState();
                    if (CloseFormAfterInsert)
                    {
                        Close();
                    }
                    else
                    {
                        ProccessType = ProccessType == ProccessType.EntityInsert ? ProccessType.EntityUpdate : ProccessType;

                    }
                    return true;
                }


                return false;

            }
            var result = editFormClosed ? Messages.EditFormClosedMessage() : Messages.SaveMessage();

            switch (result)
            {
                case DialogResult.Yes:
                    return SaveProccess();

                case DialogResult.No:
                    if (editFormClosed)
                        btnSave.Enabled = false;
                    return true;

                case DialogResult.Cancel:
                    return true;
            }
            return false;
        }

        protected virtual bool EntityUpdate()
        {
            return ((IBaseGeneralBll)Bll).Update(OldEntity,CurrentEntity);

        }
        #region Comment
        /*
         * Since our SchoolBll impelemented from Bll and SchoolBll impelemented from IBaseGeneralBll so we could cast IBaseGeneralBll
         */
        #endregion
        protected virtual bool EntityInsert()
        {
           return ((IBaseGeneralBll)Bll).Insert(CurrentEntity);
        }


        #region Comment
        /*
         * Here is our virtual method simply will be override in other 
         */
        #endregion
        protected internal virtual void MyEditLoad()
        {

        }
        #region Comment
        /*
         * Here we have created method call BindEntityToControl so it will empty here we will override in BaseEditForms so it will go get our OldEntity according to its Id then we will fill our textbox,ButtonEdit and ToggleSwitch there
         */
        #endregion
        protected virtual void BindEntityToControls() { }

        #region Comment
        /*
         * Here we have created CreateUpdatedEntity and inside it we will put our CurrentEntity in EditForms
         */
        #endregion
        protected virtual void CreateUpdatedEntity() { }

        #region Comment
        /*
         * Here we have created ButtonsEnableState method so it simply will enables or disables our buttons in our EditForms when we make changes on our EditForms
         * Here if it is not IsLoaded means that if still we didn't open our EditForms or loaded then return nothing if it is IsLoaded then we create some functions that it will enable or disables our Buttons in EditForms
         */
        #endregion
        protected internal virtual void ButtonsEnableState()
        {
            if (!IsLoaded)
            {
                return;
            }
            else
            {
                GeneralFunctions.ButtonEnabledState<BaseEntity>(btnNew, btnSave, btnUndo, btnDelete, OldEntity, CurrentEntity);
            }


        }


    }
}