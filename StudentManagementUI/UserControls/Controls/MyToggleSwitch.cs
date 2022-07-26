using DevExpress.Utils;
using DevExpress.XtraEditors;
using StudentManagementUI.Abstract;
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
    public class MyToggleSwitch : ToggleSwitch, IStatusBarDescription
    {

        public MyToggleSwitch()
        {
            Name = "tglState";
            //Here whenever we click our ToggleSwitch that when it is on it will be shown Active if off then it will Passive
            Properties.OffText = "Passive";
            Properties.OnText = "Active";
            //Here whenever we move our ToggleSwitch on DataLayoutControl it will auto disable Height and and will enable auto Width
            Properties.AutoHeight = false;
            Properties.AutoWidth = true;
            //Here HorzAlignment Far means that Passive and Active text will be left side of the ToggleSwitch
            Properties.GlyphAlignment = HorzAlignment.Far;
            Properties.Appearance.ForeColor = Color.Maroon;
            //This is whenever we open our form that ToggleSwitch will always be on
            IsOn = true;
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarDescription { get; set; } = "Choose the state of your form";
    }
}
