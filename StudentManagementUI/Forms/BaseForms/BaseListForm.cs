using DevExpress.XtraBars;
using DevExpress.XtraEditors;
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
    public partial class BaseListForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public BaseListForm()
        {
            InitializeComponent();
            EventsLoad();
        }

        #region Comment
        /*
         * Here we hava created a method called EventsLoad(); all our events will be here we will do our best to write all codes in base forms in order to write less codes in the projects 
         * Here our all buttons in RibbonControl are BarButtonItem but except the Send button it is BarSubItem so we have to look for inheritted for both of them and commen inheritted should have ItemClick item so when we go to their Go To Definition we find out that both of them are inheritted from BarItem that's why we have written it on case
         * 
         */
        #endregion

        private void EventsLoad()
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

        private void Buttons_ItemClick(object sender, ItemClickEventArgs e)
        {

            private void ShowEditForm()
            {
                
            }



            #region Comment
            /*
             * Here var link = e.Item.Links[0]; and link.Focus(); whenever we click on shortcut for example for Send is F12 it directly focuses on Send BarSubItem 
             * link.OpenMenu(); opens our Send BarSubItem menu since our Open menus are links so in the end 
             * link.Item.ItemLinks[0].Focus(); it goes to opened link and focus on the First one Excel Files BarSubItem
             * 
             */
            #endregion

            if (e.Item==btnSend)
            {
                var link = (BarSubItemLink)e.Item.Links[0];
                link.Focus();
                link.OpenMenu();
                link.Item.ItemLinks[0].Focus();
            }
            else if (e.Item==btnExcelFileStandard)
            {

            }
            else if (e.Item==btnExcelFileFormatted)
            {

            }
            else if (e.Item==btnExcelFileUnformatted)
            {

            }
            else if (e.Item==btnWordFile)
            {

            }
            else if (e.Item==btnPdfFile)
            {

            }
            else if (e.Item==btnTxtFile)
            {

            }
            else if (e.Item==btnNew)
            {
                #region Comment
                /*
                 * 
                 */
                #endregion
                ShowEditForm();
            }
        }

        
    }
}