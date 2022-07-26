using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Common.Message
{
    #region Comment
    /*
     * Here is our general Messages classes in our project
     */
    #endregion

    public class Messages
    {
        #region Comment
        /*
         * Here Whenever we have error message we give this one
         */
        #endregion

        public static void ErrorMessage(string errorMessage)
        {
            XtraMessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #region Comment
        /*
         * Here we have YesSelectedYesNo we will be using this from method whenever it opens that it will be focused on Yes because in the end we have written this code MessageBoxDefaultButton.Button1 if we choose like that then in messagbox dialog will be focused on No button
         */
        #endregion

        public static DialogResult YesSelectedYesNo(string message, string title)
        {
            return XtraMessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }

        #region Comment
        /*
         * Here we have YesSelectedYesNo we will be using this from method whenever it opens that it will be focused on No because in the end we have written this code MessageBoxDefaultButton.Button2 
         */
        #endregion

        public static DialogResult NoSelectedYesNo(string message, string title)
        {
            return XtraMessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }

        public static DialogResult DeleteMessage(string formName)
        {
           return  YesSelectedYesNo($"Selected {formName} will be deleted. Do you confirm?", "Delete confirmation");
        }

    }
}
