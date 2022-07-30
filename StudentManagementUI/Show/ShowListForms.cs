using Common.Enums;
using StudentManagementUI.Forms.BaseForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementUI.Show
{
    #region Comment
    /*
     * Here we have created a class called ShowListForms as generic and it will take our ListForms and open on Mdi and we have created method named ShowListForm so it basiclly will open our all ListForms from MainForms and FormType formType here we will use authorization later 
     * frm.MdiParent = Form.ActiveForm; Here since all these forms are ListForms so it will open inside MDI forms
     * MyListLoad(); is our all events and fillvariables there it will run it because we have to run it we set everything there GridView,Navigators,FormType and such as FormShow = new ShowEditForms<SchoolEditForm>(); here it will open our EditForms here for example it will open the SchoolEditForms

     * 
     */
    #endregion
    public class ShowListForms<TForm> where TForm:BaseListForm
    {
        public static void ShowListForm(FormType formType)
        {

            var frm = (TForm)Activator.CreateInstance(typeof(TForm));
            frm.MdiParent = Form.ActiveForm;
            frm.MyListLoad();
            frm.Show();
        }

    }
}
