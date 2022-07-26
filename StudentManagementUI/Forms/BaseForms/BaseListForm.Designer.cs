namespace StudentManagementUI.Forms.BaseForms
{
    partial class BaseListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnSelect = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnFilter = new DevExpress.XtraBars.BarButtonItem();
            this.btnColumns = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnSend = new DevExpress.XtraBars.BarSubItem();
            this.barNew = new DevExpress.XtraBars.BarStaticItem();
            this.barNewDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barRemove = new DevExpress.XtraBars.BarStaticItem();
            this.barRemoveDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barSelect = new DevExpress.XtraBars.BarStaticItem();
            this.barSelectDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barEdit = new DevExpress.XtraBars.BarStaticItem();
            this.barEditDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barRefresh = new DevExpress.XtraBars.BarStaticItem();
            this.barRefreshDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barFilter = new DevExpress.XtraBars.BarStaticItem();
            this.barFilterDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barColumns = new DevExpress.XtraBars.BarStaticItem();
            this.barColumnsDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barPrint = new DevExpress.XtraBars.BarStaticItem();
            this.barPrintDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barSend = new DevExpress.XtraBars.BarStaticItem();
            this.barSendDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barExit = new DevExpress.XtraBars.BarStaticItem();
            this.barExitDescription = new DevExpress.XtraBars.BarStaticItem();
            this.btnActivePassiveList = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.DrawGroupsBorderMode = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.btnNew,
            this.btnDelete,
            this.btnSelect,
            this.btnEdit,
            this.btnRefresh,
            this.btnFilter,
            this.btnColumns,
            this.btnPrint,
            this.btnExit,
            this.btnSend,
            this.barNew,
            this.barNewDescription,
            this.barRemove,
            this.barRemoveDescription,
            this.barSelect,
            this.barSelectDescription,
            this.barEdit,
            this.barEditDescription,
            this.barRefresh,
            this.barRefreshDescription,
            this.barFilter,
            this.barFilterDescription,
            this.barColumns,
            this.barColumnsDescription,
            this.barPrint,
            this.barPrintDescription,
            this.barSend,
            this.barSendDescription,
            this.barExit,
            this.barExitDescription,
            this.btnActivePassiveList});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 32;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage});
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl.ShowQatLocationSelector = false;
            this.ribbonControl.ShowToolbarCustomizeItem = false;
            this.ribbonControl.Size = new System.Drawing.Size(1248, 109);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnNew
            // 
            this.btnNew.Caption = "New";
            this.btnNew.Id = 1;
            this.btnNew.ImageOptions.Image = global::StudentManagementUI.Properties.Resources.addfile_16x16;
            this.btnNew.ImageOptions.LargeImage = global::StudentManagementUI.Properties.Resources.addfile_32x32;
            this.btnNew.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Insert);
            this.btnNew.Name = "btnNew";
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Delete";
            this.btnDelete.Id = 2;
            this.btnDelete.ImageOptions.Image = global::StudentManagementUI.Properties.Resources.deletelist_16x16;
            this.btnDelete.ImageOptions.LargeImage = global::StudentManagementUI.Properties.Resources.deletelist_32x32;
            this.btnDelete.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.btnDelete.Name = "btnDelete";
            // 
            // btnSelect
            // 
            this.btnSelect.Caption = "Select";
            this.btnSelect.Id = 3;
            this.btnSelect.ImageOptions.Image = global::StudentManagementUI.Properties.Resources.apply_16x16;
            this.btnSelect.ImageOptions.LargeImage = global::StudentManagementUI.Properties.Resources.apply_32x32;
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.ShortcutKeyDisplayString = "Enter";
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Edit";
            this.btnEdit.Id = 4;
            this.btnEdit.ImageOptions.Image = global::StudentManagementUI.Properties.Resources.edit_16x16;
            this.btnEdit.ImageOptions.LargeImage = global::StudentManagementUI.Properties.Resources.edit_32x32;
            this.btnEdit.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3);
            this.btnEdit.Name = "btnEdit";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 5;
            this.btnRefresh.ImageOptions.Image = global::StudentManagementUI.Properties.Resources.convert_16x16;
            this.btnRefresh.ImageOptions.LargeImage = global::StudentManagementUI.Properties.Resources.convert_32x32;
            this.btnRefresh.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.btnRefresh.Name = "btnRefresh";
            // 
            // btnFilter
            // 
            this.btnFilter.Caption = "Filter";
            this.btnFilter.Id = 6;
            this.btnFilter.ImageOptions.Image = global::StudentManagementUI.Properties.Resources.crossdatasourcefiltering__16x16;
            this.btnFilter.ImageOptions.LargeImage = global::StudentManagementUI.Properties.Resources.crossdatasourcefiltering_32x32;
            this.btnFilter.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F8);
            this.btnFilter.Name = "btnFilter";
            // 
            // btnColumns
            // 
            this.btnColumns.Caption = "Columns";
            this.btnColumns.Id = 7;
            this.btnColumns.ImageOptions.Image = global::StudentManagementUI.Properties.Resources.weekend_16x16;
            this.btnColumns.ImageOptions.LargeImage = global::StudentManagementUI.Properties.Resources.weekend_32x32;
            this.btnColumns.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
            this.btnColumns.Name = "btnColumns";
            // 
            // btnPrint
            // 
            this.btnPrint.Caption = "Print";
            this.btnPrint.Id = 8;
            this.btnPrint.ImageOptions.Image = global::StudentManagementUI.Properties.Resources.print_16x16;
            this.btnPrint.ImageOptions.LargeImage = global::StudentManagementUI.Properties.Resources.print_32x32;
            this.btnPrint.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.btnPrint.Name = "btnPrint";
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Exit";
            this.btnExit.Id = 9;
            this.btnExit.ImageOptions.Image = global::StudentManagementUI.Properties.Resources.close_16x16;
            this.btnExit.ImageOptions.LargeImage = global::StudentManagementUI.Properties.Resources.close_32x32;
            this.btnExit.Name = "btnExit";
            this.btnExit.ShortcutKeyDisplayString = "Esc";
            // 
            // btnSend
            // 
            this.btnSend.Caption = "Send";
            this.btnSend.Id = 10;
            this.btnSend.ImageOptions.Image = global::StudentManagementUI.Properties.Resources.export_16x16;
            this.btnSend.ImageOptions.LargeImage = global::StudentManagementUI.Properties.Resources.export_32x32;
            this.btnSend.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12);
            this.btnSend.Name = "btnSend";
            // 
            // barNew
            // 
            this.barNew.Caption = "Insert :";
            this.barNew.Id = 11;
            this.barNew.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barNew.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barNew.ItemAppearance.Normal.Options.UseFont = true;
            this.barNew.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barNew.Name = "barNew";
            // 
            // barNewDescription
            // 
            this.barNewDescription.Caption = "New";
            this.barNewDescription.Id = 12;
            this.barNewDescription.Name = "barNewDescription";
            // 
            // barRemove
            // 
            this.barRemove.Caption = "Delete :";
            this.barRemove.Id = 13;
            this.barRemove.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barRemove.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barRemove.ItemAppearance.Normal.Options.UseFont = true;
            this.barRemove.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barRemove.Name = "barRemove";
            // 
            // barRemoveDescription
            // 
            this.barRemoveDescription.Caption = "Remove";
            this.barRemoveDescription.Id = 14;
            this.barRemoveDescription.Name = "barRemoveDescription";
            // 
            // barSelect
            // 
            this.barSelect.Caption = "Enter :";
            this.barSelect.Id = 15;
            this.barSelect.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barSelect.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barSelect.ItemAppearance.Normal.Options.UseFont = true;
            this.barSelect.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barSelect.Name = "barSelect";
            // 
            // barSelectDescription
            // 
            this.barSelectDescription.Caption = "Select";
            this.barSelectDescription.Id = 16;
            this.barSelectDescription.Name = "barSelectDescription";
            // 
            // barEdit
            // 
            this.barEdit.Caption = "F3 :";
            this.barEdit.Id = 17;
            this.barEdit.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barEdit.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barEdit.ItemAppearance.Normal.Options.UseFont = true;
            this.barEdit.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barEdit.Name = "barEdit";
            // 
            // barEditDescription
            // 
            this.barEditDescription.Caption = "Edit";
            this.barEditDescription.Id = 18;
            this.barEditDescription.Name = "barEditDescription";
            // 
            // barRefresh
            // 
            this.barRefresh.Caption = "F5 :";
            this.barRefresh.Id = 19;
            this.barRefresh.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barRefresh.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barRefresh.ItemAppearance.Normal.Options.UseFont = true;
            this.barRefresh.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barRefresh.Name = "barRefresh";
            // 
            // barRefreshDescription
            // 
            this.barRefreshDescription.Caption = "Refresh";
            this.barRefreshDescription.Id = 20;
            this.barRefreshDescription.Name = "barRefreshDescription";
            // 
            // barFilter
            // 
            this.barFilter.Caption = "F8 :";
            this.barFilter.Id = 21;
            this.barFilter.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barFilter.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barFilter.ItemAppearance.Normal.Options.UseFont = true;
            this.barFilter.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barFilter.Name = "barFilter";
            // 
            // barFilterDescription
            // 
            this.barFilterDescription.Caption = "Filter";
            this.barFilterDescription.Id = 22;
            this.barFilterDescription.Name = "barFilterDescription";
            // 
            // barColumns
            // 
            this.barColumns.Caption = "Ctrl+O :";
            this.barColumns.Id = 23;
            this.barColumns.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barColumns.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barColumns.ItemAppearance.Normal.Options.UseFont = true;
            this.barColumns.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barColumns.Name = "barColumns";
            // 
            // barColumnsDescription
            // 
            this.barColumnsDescription.Caption = "Columns";
            this.barColumnsDescription.Id = 24;
            this.barColumnsDescription.Name = "barColumnsDescription";
            // 
            // barPrint
            // 
            this.barPrint.Caption = "Ctrl+P :";
            this.barPrint.Id = 25;
            this.barPrint.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barPrint.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barPrint.ItemAppearance.Normal.Options.UseFont = true;
            this.barPrint.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barPrint.Name = "barPrint";
            // 
            // barPrintDescription
            // 
            this.barPrintDescription.Caption = "Print";
            this.barPrintDescription.Id = 26;
            this.barPrintDescription.Name = "barPrintDescription";
            // 
            // barSend
            // 
            this.barSend.Caption = "F12 :";
            this.barSend.Id = 27;
            this.barSend.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barSend.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barSend.ItemAppearance.Normal.Options.UseFont = true;
            this.barSend.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barSend.Name = "barSend";
            // 
            // barSendDescription
            // 
            this.barSendDescription.Caption = "Send";
            this.barSendDescription.Id = 28;
            this.barSendDescription.Name = "barSendDescription";
            // 
            // barExit
            // 
            this.barExit.Caption = "Esc :";
            this.barExit.Id = 29;
            this.barExit.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barExit.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barExit.ItemAppearance.Normal.Options.UseFont = true;
            this.barExit.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barExit.Name = "barExit";
            // 
            // barExitDescription
            // 
            this.barExitDescription.Caption = "Exit";
            this.barExitDescription.Id = 30;
            this.barExitDescription.Name = "barExitDescription";
            // 
            // btnActivePassiveList
            // 
            this.btnActivePassiveList.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnActivePassiveList.Caption = "Passive List";
            this.btnActivePassiveList.Id = 31;
            this.btnActivePassiveList.ImageOptions.Image = global::StudentManagementUI.Properties.Resources.article_16x16;
            this.btnActivePassiveList.ImageOptions.LargeImage = global::StudentManagementUI.Properties.Resources.article_32x32;
            this.btnActivePassiveList.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnActivePassiveList.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnActivePassiveList.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnActivePassiveList.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btnActivePassiveList.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnActivePassiveList.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Maroon;
            this.btnActivePassiveList.ItemAppearance.Normal.Options.UseFont = true;
            this.btnActivePassiveList.ItemAppearance.Normal.Options.UseForeColor = true;
            this.btnActivePassiveList.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnActivePassiveList.ItemAppearance.Pressed.ForeColor = System.Drawing.Color.Maroon;
            this.btnActivePassiveList.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnActivePassiveList.ItemAppearance.Pressed.Options.UseForeColor = true;
            this.btnActivePassiveList.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L));
            this.btnActivePassiveList.Name = "btnActivePassiveList";
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup});
            this.ribbonPage.Name = "ribbonPage";
            this.ribbonPage.Text = "ribbonPage1";
            // 
            // ribbonPageGroup
            // 
            this.ribbonPageGroup.ItemLinks.Add(this.btnNew);
            this.ribbonPageGroup.ItemLinks.Add(this.btnDelete);
            this.ribbonPageGroup.ItemLinks.Add(this.btnSelect);
            this.ribbonPageGroup.ItemLinks.Add(this.btnEdit);
            this.ribbonPageGroup.ItemLinks.Add(this.btnRefresh);
            this.ribbonPageGroup.ItemLinks.Add(this.btnFilter);
            this.ribbonPageGroup.ItemLinks.Add(this.btnColumns);
            this.ribbonPageGroup.ItemLinks.Add(this.btnPrint);
            this.ribbonPageGroup.ItemLinks.Add(this.btnSend);
            this.ribbonPageGroup.ItemLinks.Add(this.btnExit);
            this.ribbonPageGroup.Name = "ribbonPageGroup";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barNew);
            this.ribbonStatusBar.ItemLinks.Add(this.barNewDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barRemove, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barRemoveDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barSelect, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barSelectDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barEdit, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barEditDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barRefresh, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barRefreshDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barFilter, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barFilterDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barColumns, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barColumnsDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barPrint, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barPrintDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barSend, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barSendDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barExit, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barExitDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.btnActivePassiveList);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 375);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1248, 24);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // BaseListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 399);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.IconOptions.ShowIcon = false;
            this.MinimizeBox = false;
            this.Name = "BaseListForm";
            this.Ribbon = this.ribbonControl;
            this.ShowInTaskbar = false;
            this.StatusBar = this.ribbonStatusBar;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        protected DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnSelect;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnFilter;
        private DevExpress.XtraBars.BarButtonItem btnColumns;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.BarSubItem btnSend;
        private DevExpress.XtraBars.BarStaticItem barNew;
        private DevExpress.XtraBars.BarStaticItem barNewDescription;
        private DevExpress.XtraBars.BarStaticItem barRemove;
        private DevExpress.XtraBars.BarStaticItem barRemoveDescription;
        private DevExpress.XtraBars.BarStaticItem barSelect;
        private DevExpress.XtraBars.BarStaticItem barSelectDescription;
        private DevExpress.XtraBars.BarStaticItem barEdit;
        private DevExpress.XtraBars.BarStaticItem barEditDescription;
        private DevExpress.XtraBars.BarStaticItem barRefresh;
        private DevExpress.XtraBars.BarStaticItem barRefreshDescription;
        private DevExpress.XtraBars.BarStaticItem barFilter;
        private DevExpress.XtraBars.BarStaticItem barFilterDescription;
        private DevExpress.XtraBars.BarStaticItem barColumns;
        private DevExpress.XtraBars.BarStaticItem barColumnsDescription;
        private DevExpress.XtraBars.BarStaticItem barPrint;
        private DevExpress.XtraBars.BarStaticItem barPrintDescription;
        private DevExpress.XtraBars.BarStaticItem barSend;
        private DevExpress.XtraBars.BarStaticItem barSendDescription;
        private DevExpress.XtraBars.BarStaticItem barExit;
        private DevExpress.XtraBars.BarStaticItem barExitDescription;
        private DevExpress.XtraBars.BarButtonItem btnActivePassiveList;
    }
}