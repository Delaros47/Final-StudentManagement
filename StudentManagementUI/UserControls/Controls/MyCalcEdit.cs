using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using StudentManagementUI.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementUI.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyCalcEdit:CalcEdit,IStatusBarShortcut
    {
        public MyCalcEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            //Here our value shouldn't be null either negative digit or possitive or 0
            Properties.AllowNullInput = DefaultBoolean.False;
            //Here we mask our CalcEdit n means numeric like that 132,548 but when we put 2 means that last digits will calculate pennies as well like that 132,548.25
            Properties.Mask.MaskType = MaskType.Numeric;
            Properties.EditMask = "n2";
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarShortcut { get; set; } = "F4 :";
        public string StatusBarShortcutDescription { get; set; } = "Calculator";
        public string StatusBarDescription { get; set; }
    }
}
