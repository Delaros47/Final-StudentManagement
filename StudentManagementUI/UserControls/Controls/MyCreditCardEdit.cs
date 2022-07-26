using DevExpress.Utils;
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
    public class MyCreditCardEdit:MyTextEdit
    {
        public MyCreditCardEdit()
        {
            //This will make our Credit Card number in the middle of the text
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            //Here we choose the Regular cause if we need fax or phone number or Credit number we use it
            Properties.Mask.MaskType = MaskType.Regular;
            //Here we set our mask d means that it can be value and ? means that it can be null value as well
            Properties.Mask.EditMask = @"\d?\d?\d?\d?-\d?\d?\d?\d?-\d?\d?\d?\d?-\d?\d?\d?\d?";
            //Here we choose AutoCompleteType to none cause whenever we enter credit card number when some digits are missing that it will not automaticlly put 0 on it for rest of it
            Properties.Mask.AutoComplete = AutoCompleteType.None;
            StatusBarDescription = "Enter the Credit Car number.";
        }
    }
}
