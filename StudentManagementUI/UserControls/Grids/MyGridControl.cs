using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using StudentManagementUI.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementUI.UserControls.Grids
{
    #region Comment
    //When we look at our GridControl that main thing is GridControl and inside it there is GridView and inside it GridColumn so that's why we created three classes for that
    #endregion
    [ToolboxItem(true)]
    public class MyGridControl : GridControl
    {
        #region Comment
        //Inside our GridControl as we mentioned before that we have to call it and we override CreateDefaultView then we call our MyGridView since CreateView return BaseView so we converted into GridView cause we need all GridView options
        #endregion
        protected override BaseView CreateDefaultView()
        {
            var view = (GridView)CreateView("MyGridView");
            //We changed Our View Title or Caption color to Maroon colour
            view.Appearance.ViewCaption.ForeColor = Color.Maroon;
            //We changed our Column Title or Caption color to Maroon colour
            view.Appearance.HeaderPanel.ForeColor = Color.Maroon;
            //We have changed our Column align to center
            view.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center;
            //We have changed our GridView FooterPanel Color and FontSytle FooterPanel is down part of GridView
            view.Appearance.FooterPanel.ForeColor = Color.Maroon;
            view.Appearance.FooterPanel.Font = new Font(new FontFamily("Tahoma"), 8.25f, FontStyle.Bold);
            //We disabled three menus in our GridView cause when we click right on it that it will show us default Menus
            view.OptionsMenu.EnableColumnMenu = false;
            view.OptionsMenu.EnableFooterMenu = false;
            view.OptionsMenu.EnableGroupPanelMenu = false;
            //On our GridView that whenever we choose a row and enter it move to next row
            view.OptionsNavigation.EnterMoveNextColumn = true;
            //Whenever we print that we dont want it auto makes width we will do our own custom width
            view.OptionsPrint.AutoWidth = false;
            //We don't want Print Footer or Group Footer
            view.OptionsPrint.PrintFooter = false;
            view.OptionsPrint.PrintGroupFooter = false;
            //It will enable to show us the main Title or Caption of GridView
            view.OptionsView.ShowViewCaption = true;
            //It will show all columns name under it filter so we can search anything we want and it will get for us
            view.OptionsView.ShowAutoFilterRow = true;
            //It will not show us the toppest of our GridControl Panel
            view.OptionsView.ShowGroupPanel = false;
            //It will disable Auto Column width means columns will not be resize when we make it bigger it will be fixed width value 75 and we will be changing manually
            view.OptionsView.ColumnAutoWidth = false;
            //It will make our height if 2 or 3 rows or line thicness automatically it will change the height of our row
            view.OptionsView.RowAutoHeight = true;
            //Here in our Column name on the right side whenever we click that it will show kind of round button
            view.OptionsView.HeaderFilterButtonShowMode = FilterButtonShowMode.Button;
            //Now in our every GridView that we will be adding auto Id and Code Columns because we will be using both of them in almost every GridViw and Id will not be visible only Code column will be visible
            var idColumn = new MyGridColumn();
            idColumn.Caption = "Id";
            idColumn.FieldName = "Id";
            idColumn.OptionsColumn.AllowEdit = false;
            //Here whenever we have a lot of Columns that there is CustomizationForm small form we can move unused one there or from there to move to our GridView but since we don't want Id will be visiable in our column so we don't want it be appear inside CustomizationForm as well
            idColumn.OptionsColumn.ShowInCustomizationForm = false;
            view.Columns.Add(idColumn);
            var codeColumn = new MyGridColumn();
            codeColumn.Caption = "Private Code";
            codeColumn.FieldName = "PrivateCode";
            codeColumn.Visible = true;
            codeColumn.OptionsColumn.AllowEdit = false;
            //Here we align our Cell to center and in order to make it active so we have to use UseTextOption true
            codeColumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            codeColumn.AppearanceCell.Options.UseTextOptions = true;
            view.Columns.Add(codeColumn);

            return view;



        }
        #region Comment
        //Now what we do that simply whenever we move our GridControl to our Form that we will be make it sure that it will be using our own GridView so we have to register it and we override RegisterAvailableViewsCore and we create our own MyGridInfoRegistrator then on our MyGridInfoRegistrator we changed our Default GridView Name to MyGridView and we give our MyGridView name
        #endregion
        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyGridInfoRegistrator());
        }

        private class MyGridInfoRegistrator : GridInfoRegistrator
        {
            public override string ViewName => "MyGridView";
            public override BaseView CreateView(GridControl grid)
            {
                return new MyGridView(grid);
            }
        }
    }

    public class MyGridView : GridView, IStatusBarShortcut
    {
        public MyGridView()
        {

        }

        public MyGridView(GridControl ownerGrid) : base(ownerGrid)
        {

        }

        #region Comment
        //We would like to align to center our ColumnEdit in GridControl and in our GridControl DateEdit is called RepositoryItemDateEdit these thing are different cause it was created for just GridContol and we first override our OnColumnChangedCore cause we wanted some Custom options for ourself here we centered our ColumnEdit DateEdit one then we changed Masktype to DateTimeAdvancingCaret means that whenever we choose the day auto it goes to month and when we choose the month that it goes to year
        #endregion
        protected override void OnColumnChangedCore(GridColumn column)
        {
            base.OnColumnChangedCore(column);
            if (column.ColumnEdit == null) return;
            if (column.ColumnEdit.GetType() == typeof(RepositoryItemDateEdit))
            {
                column.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
                ((RepositoryItemDateEdit)column.ColumnEdit).Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            }

        }

        #region Comment
        //Here we can change property of our GridView so we override our CreateColumnCollection cause will change AllowEdit option to false means we shouldnt be edit any GridView cell when we click it afer CreateColumnCollection we created our own nested Class MyGridColumnCollection
        #endregion
        protected override GridColumnCollection CreateColumnCollection()
        {
            return new MyGridColumnCollection(this);
        }

        private class MyGridColumnCollection : GridColumnCollection
        {
            public MyGridColumnCollection(ColumnView view) : base(view)
            {

            }
            #region Comment
            //Since we would like to change AllowEdit to false so first we have to override another method called CreateColumn cause when column created that it invokes and here it asks an column we give our First Column class named MyGridColumn then we finally changed AllowEdit option to false and return it
            #endregion
            protected override GridColumn CreateColumn()
            {
                var column = new MyGridColumn();
                column.OptionsColumn.AllowEdit = false;
                return column;
            }
        }


        public string StatusBarShortcut { get; set; }
        public string StatusBarShortcutDescription { get; set; }
        public string StatusBarDescription { get; set; }
    }

    public class MyGridColumn : GridColumn, IStatusBarShortcut
    {




        public string StatusBarShortcut { get; set; }
        public string StatusBarShortcutDescription { get; set; }
        public string StatusBarDescription { get; set; }
    }
}
