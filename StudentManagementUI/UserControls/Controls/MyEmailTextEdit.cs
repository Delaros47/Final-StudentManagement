using DevExpress.XtraEditors.Mask;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementUI.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyEmailTextEdit:MyTextEdit
    {
        public MyEmailTextEdit()
        {
            Properties.Mask.MaskType = MaskType.RegEx;
            Properties.Mask.EditMask = "((([0-9a-zA-Z_%-])+[.])+|([0-9a-zA-Z_%-])+)+@((([0-9a-zA-Z_-])+[.])+|([0-9a-zA-Z_-])+)+";
            //Here AutoCompleteType is strong means that whenever we type letter it will automaticlly add @ and with direction arrow we can write email, it is easier to enter the email address
            Properties.Mask.AutoComplete = AutoCompleteType.Strong;
            StatusBarDescription = "Enter the Email address.";
        }
    }
}
