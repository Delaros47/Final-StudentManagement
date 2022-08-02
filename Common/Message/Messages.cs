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
            return XtraMessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        public static DialogResult YesSelectedYesNoCancel(string message, string title)
        {
            return XtraMessageBox.Show(message, title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }
        #region Comment
        /*
         * Here we have created EditFormClosedMessage(); if we do some changes on our EditForm and without clicking save button and try to close so then it will give us this message
         */
        #endregion
        public static DialogResult EditFormClosedMessage()
        {
            return YesSelectedYesNoCancel("Do you want to save the changes?", "Exit confirmation");
        }

        public static DialogResult SaveMessage()
        {
            return YesSelectedYesNo("Do you want to save the changes?","Save confirmation");
        }

        public static DialogResult DeleteMessage(string formName)
        {
            return YesSelectedYesNo($"Selected {formName} will be deleted. Do you confirm?", "Delete confirmation");
        }

        public static void WarningMessage(string message)
        {
            XtraMessageBox.Show(message, "Warning.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void NotSelectedRowId()
        {
            WarningMessage("Please select the proper Row on GridView");
        }

    }
}
