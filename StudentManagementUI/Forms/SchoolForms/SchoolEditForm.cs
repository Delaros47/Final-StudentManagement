using Business.Base.Interfaces;
using Business.General;
using DevExpress.XtraEditors;
using Model.Entities;
using StudentManagementUI.Forms.BaseForms;
using Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.DTO;
using StudentManagementUI.Functions;

namespace StudentManagementUI.Forms.SchoolForms
{
    public partial class SchoolEditForm : BaseEditForm
    {
        #region Comment
        /*
         * Here if want to use events on EditForms because all controls are inside DataLatoutControl so we have to send it to BaseEditForm
         * Bll = new SchoolBll(myDataLayoutControl); Here we sent our myDataLayoutControl to SchoolBll the reason that we have sent that if we don't write Private Code on SchoolEditForm and when we try to click Save button then first it will give us error then it will be focused on Private Code textbox in order to make focus that we have to send myDataLayoutControl to SchoolBll
         * 
         */
        #endregion
        public SchoolEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new SchoolBll(myDataLayoutControl);
            FormType = FormType.School;
            EventsLoad();
        }
        #region Comment
        /*
         * Here we overrode our MyEditLoad from BaseEditForm here if our ProccessType is EntityInsert then it will set our OldEntity new DTO new SchoolS(); since we will do all our insert,update,delete on DTO that's why it means that we definity know that we will insert a new entity if ProccessType is not EntityInsert if it is EntityUpdate then it will go to Bll find our Entity in our Database then it will set on Database then we could compare OldEntity and CurrentEntity
         * FilterFunctions.Filter<School>(Id) Here is our Function
         * if (ProccessType != ProccessType.EntityInsert) return; If our ProccessType is EntityUpdate then returns because we don't need to create PrivateCode if it is EntityInsert then we create PrivateCode and focus on txtSchool textbox
         */
        #endregion
        protected internal override void MyEditLoad()
        {
            OldEntity = ProccessType == ProccessType.EntityInsert ? new SchoolS() : ((SchoolBll)Bll).Single(FilterFunctions.Filter<School>(Id));
            BindEntityToControls();
            if (ProccessType != ProccessType.EntityInsert) return;
            txtPrivateCode.Text = ((SchoolBll)Bll).GivePrivateCode();
            txtSchoolName.Focus();
        }
        #region Comment
        /*
         * Here when we open our EditForms it sets OldEntity then since it is single entity we cast it into SchoolS cause we need id,privatecode,SchoolName ToogleSwitch,State and so on we have to use our SchoolS not School because School entity doesn't have CityName and DistrictName
         */
        #endregion
        protected override void BindEntityToControls()
        {
            var entity = (SchoolS)OldEntity;
            txtPrivateCode.Text = entity.PrivateCode;
            txtSchoolName.Text = entity.SchoolName;
            btnCityName.Id = entity.CityId;
            btnCityName.Text = entity.CityName;
            btnDistrictName.Id = entity.DistrictId;
            btnDistrictName.Text = entity.DistrictName;
            txtDescription.Text = entity.Description;
            tglState.IsOn = entity.State;
        }

        #region Comment
        /*
         * Here when we open our EditForms it sets OldEntity then since it is single entity we cast it into SchoolS cause we need id,privatecode,SchoolName ToogleSwitch,State and so on we have to use our SchoolS not School because School entity doesn't have CityName and DistrictName
         */
        #endregion
        protected override void CreateUpdatedEntity()
        {
            CurrentEntity = new School
            {
                Id = Id,
                PrivateCode = txtPrivateCode.Text,
                SchoolName = txtSchoolName.Text,
                CityId = Convert.ToInt64(btnCityName.Id),
                DistrictId = Convert.ToInt64(btnDistrictName.Id),
                State = tglState.IsOn,
                Description = txtDescription.Text
            };

            ButtonsEnableState();

        }

    }
}