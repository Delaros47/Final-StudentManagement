using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
    public class MyPictureEdit : PictureEdit, IStatusBarShortcut
    {
        public MyPictureEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            //Here our Text color on PictureEdit will be Maroon color
            Properties.Appearance.ForeColor = Color.Maroon;
            //Whenver we don't have any image or picture then on the middle of it will say that No Image
            Properties.NullText = "No Image";
            //It will disable the Menu
            Properties.ShowMenu = false;
            //Here it will be stretched any chosen image or picture on our control
            Properties.SizeMode = PictureSizeMode.Stretch;
        }

        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarShortcut { get; set; } = "F4 :";
        public string StatusBarShortcutDescription { get; set; }
        public string StatusBarDescription { get; set; }
    }
}
