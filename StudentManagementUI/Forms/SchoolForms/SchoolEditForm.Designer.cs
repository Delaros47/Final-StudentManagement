namespace StudentManagementUI.Forms.SchoolForms
{
    partial class SchoolEditForm
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl = new StudentManagementUI.UserControls.Controls.MyDataLayoutControl();
            this.btnDescription = new StudentManagementUI.UserControls.Controls.MyMemoEdit();
            this.btnDistrictName = new StudentManagementUI.UserControls.Controls.MyButtonEdit();
            this.btnCityName = new StudentManagementUI.UserControls.Controls.MyButtonEdit();
            this.txtSchoolName = new StudentManagementUI.UserControls.Controls.MyTextEdit();
            this.txtPrivateCode = new StudentManagementUI.UserControls.Controls.MyPrivateCodeTextEdit();
            this.tglState = new StudentManagementUI.UserControls.Controls.MyToggleSwitch();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDistrictName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCityName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSchoolName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrivateCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.AccessibleName = "Search Item";
            this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl.SearchEditItem.EditWidth = 150;
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.btnDescription);
            this.myDataLayoutControl.Controls.Add(this.btnDistrictName);
            this.myDataLayoutControl.Controls.Add(this.btnCityName);
            this.myDataLayoutControl.Controls.Add(this.txtSchoolName);
            this.myDataLayoutControl.Controls.Add(this.txtPrivateCode);
            this.myDataLayoutControl.Controls.Add(this.tglState);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 109);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.Root;
            this.myDataLayoutControl.Size = new System.Drawing.Size(373, 186);
            this.myDataLayoutControl.TabIndex = 2;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // btnDescription
            // 
            this.btnDescription.EnterMoveNextControl = true;
            this.btnDescription.Location = new System.Drawing.Point(85, 108);
            this.btnDescription.MenuManager = this.ribbonControl;
            this.btnDescription.Name = "btnDescription";
            this.btnDescription.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.btnDescription.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.btnDescription.Properties.MaxLength = 500;
            this.btnDescription.Size = new System.Drawing.Size(276, 66);
            this.btnDescription.StatusBarDescription = "Enter the Description.";
            this.btnDescription.StyleController = this.myDataLayoutControl;
            this.btnDescription.TabIndex = 9;
            // 
            // btnDistrictName
            // 
            this.btnDistrictName.EnterMoveNextControl = true;
            this.btnDistrictName.Id = null;
            this.btnDistrictName.Location = new System.Drawing.Point(85, 84);
            this.btnDistrictName.MenuManager = this.ribbonControl;
            this.btnDistrictName.Name = "btnDistrictName";
            this.btnDistrictName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.btnDistrictName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.btnDistrictName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnDistrictName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.btnDistrictName.Size = new System.Drawing.Size(133, 20);
            this.btnDistrictName.StatusBarDescription = null;
            this.btnDistrictName.StatusBarShortcut = "F4 :";
            this.btnDistrictName.StatusBarShortcutDescription = null;
            this.btnDistrictName.StyleController = this.myDataLayoutControl;
            this.btnDistrictName.TabIndex = 8;
            // 
            // btnCityName
            // 
            this.btnCityName.EnterMoveNextControl = true;
            this.btnCityName.Id = null;
            this.btnCityName.Location = new System.Drawing.Point(85, 60);
            this.btnCityName.MenuManager = this.ribbonControl;
            this.btnCityName.Name = "btnCityName";
            this.btnCityName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.btnCityName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.btnCityName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnCityName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.btnCityName.Size = new System.Drawing.Size(133, 20);
            this.btnCityName.StatusBarDescription = null;
            this.btnCityName.StatusBarShortcut = "F4 :";
            this.btnCityName.StatusBarShortcutDescription = null;
            this.btnCityName.StyleController = this.myDataLayoutControl;
            this.btnCityName.TabIndex = 7;
            // 
            // txtSchoolName
            // 
            this.txtSchoolName.EnterMoveNextControl = true;
            this.txtSchoolName.Location = new System.Drawing.Point(85, 36);
            this.txtSchoolName.MenuManager = this.ribbonControl;
            this.txtSchoolName.Name = "txtSchoolName";
            this.txtSchoolName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtSchoolName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtSchoolName.Properties.MaxLength = 50;
            this.txtSchoolName.Size = new System.Drawing.Size(276, 20);
            this.txtSchoolName.StatusBarDescription = null;
            this.txtSchoolName.StyleController = this.myDataLayoutControl;
            this.txtSchoolName.TabIndex = 6;
            // 
            // txtPrivateCode
            // 
            this.txtPrivateCode.EnterMoveNextControl = true;
            this.txtPrivateCode.Location = new System.Drawing.Point(85, 12);
            this.txtPrivateCode.MenuManager = this.ribbonControl;
            this.txtPrivateCode.Name = "txtPrivateCode";
            this.txtPrivateCode.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtPrivateCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtPrivateCode.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPrivateCode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPrivateCode.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtPrivateCode.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtPrivateCode.Properties.MaxLength = 35;
            this.txtPrivateCode.Size = new System.Drawing.Size(133, 20);
            this.txtPrivateCode.StatusBarDescription = "Enter the Private Code.";
            this.txtPrivateCode.StyleController = this.myDataLayoutControl;
            this.txtPrivateCode.TabIndex = 5;
            // 
            // tglState
            // 
            this.tglState.EditValue = true;
            this.tglState.EnterMoveNextControl = true;
            this.tglState.Location = new System.Drawing.Point(273, 12);
            this.tglState.MenuManager = this.ribbonControl;
            this.tglState.Name = "tglState";
            this.tglState.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.tglState.Properties.Appearance.Options.UseForeColor = true;
            this.tglState.Properties.AutoHeight = false;
            this.tglState.Properties.AutoWidth = true;
            this.tglState.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tglState.Properties.OffText = "Passive";
            this.tglState.Properties.OnText = "Active";
            this.tglState.Size = new System.Drawing.Size(89, 20);
            this.tglState.StatusBarDescription = "Choose the state of your form";
            this.tglState.StyleController = this.myDataLayoutControl;
            this.tglState.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition1.Width = 210D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 100D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition3.Width = 92D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 24D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition3.Height = 24D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition4.Height = 24D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition5.Height = 100D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5});
            this.Root.Size = new System.Drawing.Size(373, 186);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.tglState;
            this.layoutControlItem1.Location = new System.Drawing.Point(261, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem1.Size = new System.Drawing.Size(92, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtPrivateCode;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(210, 24);
            this.layoutControlItem2.Text = "Private Code";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(63, 13);
            this.layoutControlItem2.TextToControlDistance = 10;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtSchoolName;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem3.Size = new System.Drawing.Size(353, 24);
            this.layoutControlItem3.Text = "School Name";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(63, 13);
            this.layoutControlItem3.TextToControlDistance = 10;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.btnCityName;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem4.Size = new System.Drawing.Size(210, 24);
            this.layoutControlItem4.Text = "City Name";
            this.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(63, 13);
            this.layoutControlItem4.TextToControlDistance = 10;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.btnDistrictName;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem5.Size = new System.Drawing.Size(210, 24);
            this.layoutControlItem5.Text = "District Name";
            this.layoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(63, 13);
            this.layoutControlItem5.TextToControlDistance = 10;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.Control = this.btnDescription;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlItem6.Size = new System.Drawing.Size(353, 70);
            this.layoutControlItem6.Text = "Description";
            this.layoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(63, 13);
            this.layoutControlItem6.TextToControlDistance = 10;
            // 
            // SchoolEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 319);
            this.Controls.Add(this.myDataLayoutControl);
            this.IconOptions.ShowIcon = false;
            this.Name = "SchoolEditForm";
            this.Text = "School Edit";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDistrictName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCityName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSchoolName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrivateCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private UserControls.Controls.MyMemoEdit btnDescription;
        private UserControls.Controls.MyButtonEdit btnDistrictName;
        private UserControls.Controls.MyButtonEdit btnCityName;
        private UserControls.Controls.MyTextEdit txtSchoolName;
        private UserControls.Controls.MyPrivateCodeTextEdit txtPrivateCode;
        private UserControls.Controls.MyToggleSwitch tglState;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}