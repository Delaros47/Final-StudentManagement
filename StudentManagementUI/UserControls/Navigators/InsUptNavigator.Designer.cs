namespace StudentManagementUI.UserControls.Navigators
{
    partial class InsUptNavigator
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsUptNavigator));
            this.Navigator = new DevExpress.XtraEditors.ControlNavigator();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // Navigator
            // 
            this.Navigator.Buttons.Append.ImageIndex = 4;
            this.Navigator.Buttons.CancelEdit.Visible = false;
            this.Navigator.Buttons.Edit.Visible = false;
            this.Navigator.Buttons.EndEdit.Visible = false;
            this.Navigator.Buttons.First.ImageIndex = 0;
            this.Navigator.Buttons.ImageList = this.imageCollection;
            this.Navigator.Buttons.Last.ImageIndex = 3;
            this.Navigator.Buttons.Next.ImageIndex = 2;
            this.Navigator.Buttons.NextPage.Visible = false;
            this.Navigator.Buttons.Prev.ImageIndex = 1;
            this.Navigator.Buttons.PrevPage.Visible = false;
            this.Navigator.Buttons.Remove.ImageIndex = 5;
            this.Navigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Navigator.Location = new System.Drawing.Point(0, 0);
            this.Navigator.Name = "Navigator";
            this.Navigator.Size = new System.Drawing.Size(800, 24);
            this.Navigator.TabIndex = 0;
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertImage(global::StudentManagementUI.Properties.Resources.first_16x16, "first_16x16", typeof(global::StudentManagementUI.Properties.Resources), 0);
            this.imageCollection.Images.SetKeyName(0, "first_16x16");
            this.imageCollection.InsertImage(global::StudentManagementUI.Properties.Resources.prev_16x16, "prev_16x16", typeof(global::StudentManagementUI.Properties.Resources), 1);
            this.imageCollection.Images.SetKeyName(1, "prev_16x16");
            this.imageCollection.InsertImage(global::StudentManagementUI.Properties.Resources.next_16x16, "next_16x16", typeof(global::StudentManagementUI.Properties.Resources), 2);
            this.imageCollection.Images.SetKeyName(2, "next_16x16");
            this.imageCollection.InsertImage(global::StudentManagementUI.Properties.Resources.last_16x16, "last_16x16", typeof(global::StudentManagementUI.Properties.Resources), 3);
            this.imageCollection.Images.SetKeyName(3, "last_16x16");
            this.imageCollection.InsertImage(global::StudentManagementUI.Properties.Resources.addfile_16x16, "addfile_16x16", typeof(global::StudentManagementUI.Properties.Resources), 4);
            this.imageCollection.Images.SetKeyName(4, "addfile_16x16");
            this.imageCollection.InsertImage(global::StudentManagementUI.Properties.Resources.deletelist_16x16, "deletelist_16x16", typeof(global::StudentManagementUI.Properties.Resources), 5);
            this.imageCollection.Images.SetKeyName(5, "deletelist_16x16");
            // 
            // InsUptNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Navigator);
            this.Name = "InsUptNavigator";
            this.Size = new System.Drawing.Size(800, 24);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ControlNavigator Navigator;
        private DevExpress.Utils.ImageCollection imageCollection;
    }
}
