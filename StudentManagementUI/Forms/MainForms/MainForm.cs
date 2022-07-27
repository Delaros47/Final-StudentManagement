using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using StudentManagementUI.Forms.SchoolForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementUI.Forms.MainForms
{
    public partial class MainForm : RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            EventsLoad();
        }

        #region Comment
        /*
         * Here we have successfully created our events we will not go each BarButtonItem and from events double click instead we created method inside it we will define all of our events since all button in RibbonControl is BarButtonItem we made condition with switch
         */
        #endregion

        private void EventsLoad()
        {
            foreach (var item in ribbonControl.Items)
            {
                switch (item)
                {
                    case BarButtonItem buttons:
                        buttons.ItemClick += Buttons_ItemClick;
                        break;
                    default:
                        break;
                }
            }
        }

        private void Buttons_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item==btnSchools)
            {
                SchoolListForm schoolListForm = new SchoolListForm();
                schoolListForm.MdiParent = ActiveForm;
                schoolListForm.Show();
            }
        }
    }
}