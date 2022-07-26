using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementUI.Abstract
{
    public interface IStatusBarShortcut:IStatusBarDescription
    {
        string StatusBarShortcut { get; set; }
        string StatusBarShortcutDescription { get; set; }
    }
}
