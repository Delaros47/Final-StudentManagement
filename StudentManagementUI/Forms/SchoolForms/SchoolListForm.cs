using Business.General;
using DevExpress.XtraEditors;
using StudentManagementUI.Forms.BaseForms;
using System;
using Common.Enums;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementUI.Show;
using StudentManagementUI.Functions;
using Model.Entities;

namespace StudentManagementUI.Forms.SchoolForms
{
    public partial class SchoolListForm : BaseListForm
    {
        #region Comment
        /*
         * Here Bll = new SchoolBll(); we sent our SchoolBll to BaseListForm there we can access delete,update,insert and list methods there since Bll is IBaseBll interface and also BaseBll inheritted from it and SchoolBll inheritted from BaseBll so Bll simply keeps all referances from Business classes
         */
        #endregion
        public SchoolListForm()
        {
            InitializeComponent();
            Bll = new SchoolBll();
        }

        #region Comment
        /*
         * Here FillTheVariables method was virtual and empty in BaseListForm so we override here and we set our Table (GridView) and FormType and FormShow we sent our SchoolEditForm so there we can open whenever it click New,Edit buttons or double click on Table (GridView) and lastly we have sent long Navigator
         */
        #endregion
        protected override void FillTheVariables()
        {
            Table = table;
            FormType = FormType.School;
            FormShow = new ShowEditForms<SchoolEditForm>();
            Navigator = longNavigator.Navigator;
        }

        #region Comment
        /*
         * Here we have overrode our EntityRefresh method and we set our Table(GridView) in GridControl and DataSource so since SchoolBll is Bll so we have to cast it in order to reach its methods there and inside the List we will not write like that (x=>x.State==true) each time instead we will create class for our filters
         * FilterFunctions.Filter<School>(ShowActiveList) Here we have created FilterFunctions class inside it we have returns whenever our State is true and false we don't need to write each time like this (x=>x.State==true) or false that's why we have created Generic method inside the class
         * ShowActiveList comes from BaseListForm there as default value we assgined true but if it is false then it will list Passive List if we don't change then it will list Active List
         */
        #endregion
        protected override void EntityRefresh()
        {
            Table.GridControl.DataSource = ((SchoolBll)Bll).List(FilterFunctions.Filter<School>(ShowActiveList));
        }

    }
}