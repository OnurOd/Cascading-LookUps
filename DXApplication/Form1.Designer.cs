namespace DXApplication
{
    partial class Form1
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
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition6 = new DevExpress.XtraLayout.RowDefinition();
            this.gcStorage = new DevExpress.XtraGrid.GridControl();
            this.gvStorage = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCategoryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpCategory = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpProduct = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnProductIdSelling = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpSellingPrice = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcProduct = new DevExpress.XtraGrid.GridControl();
            this.gvProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcCategory = new DevExpress.XtraGrid.GridControl();
            this.gvCategory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtSellingPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtBasePrice = new DevExpress.XtraEditors.TextEdit();
            this.txtEntryBy = new DevExpress.XtraEditors.TextEdit();
            this.sbAddCategory = new DevExpress.XtraEditors.SimpleButton();
            this.sbAddProduct = new DevExpress.XtraEditors.SimpleButton();
            this.sbAddNew = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpSellingPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSellingPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBasePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntryBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            this.SuspendLayout();
            // 
            // gcStorage
            // 
            this.gcStorage.Location = new System.Drawing.Point(12, 258);
            this.gcStorage.MainView = this.gvStorage;
            this.gcStorage.Name = "gcStorage";
            this.gcStorage.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpCategory,
            this.LookUpProduct,
            this.LookUpSellingPrice});
            this.gcStorage.Size = new System.Drawing.Size(884, 375);
            this.gcStorage.TabIndex = 0;
            this.gcStorage.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStorage});
            // 
            // gvStorage
            // 
            this.gvStorage.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumnCategoryId,
            this.gridColumnProductId,
            this.gridColumnProductIdSelling});
            this.gvStorage.GridControl = this.gcStorage;
            this.gvStorage.Name = "gvStorage";
            this.gvStorage.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Entry By";
            this.gridColumn4.FieldName = "EntryBy";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // gridColumnCategoryId
            // 
            this.gridColumnCategoryId.Caption = "Category";
            this.gridColumnCategoryId.ColumnEdit = this.LookUpCategory;
            this.gridColumnCategoryId.FieldName = "CategoryId";
            this.gridColumnCategoryId.Name = "gridColumnCategoryId";
            this.gridColumnCategoryId.Visible = true;
            this.gridColumnCategoryId.VisibleIndex = 1;
            // 
            // LookUpCategory
            // 
            this.LookUpCategory.AutoHeight = false;
            this.LookUpCategory.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpCategory.Name = "LookUpCategory";
            // 
            // gridColumnProductId
            // 
            this.gridColumnProductId.Caption = "Product Name";
            this.gridColumnProductId.ColumnEdit = this.LookUpProduct;
            this.gridColumnProductId.FieldName = "ProductId";
            this.gridColumnProductId.Name = "gridColumnProductId";
            this.gridColumnProductId.Visible = true;
            this.gridColumnProductId.VisibleIndex = 2;
            // 
            // LookUpProduct
            // 
            this.LookUpProduct.AutoHeight = false;
            this.LookUpProduct.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpProduct.Name = "LookUpProduct";
            // 
            // gridColumnProductIdSelling
            // 
            this.gridColumnProductIdSelling.Caption = "Unit Selling Price";
            this.gridColumnProductIdSelling.ColumnEdit = this.LookUpSellingPrice;
            this.gridColumnProductIdSelling.FieldName = "ProductId";
            this.gridColumnProductIdSelling.Name = "gridColumnProductIdSelling";
            this.gridColumnProductIdSelling.Visible = true;
            this.gridColumnProductIdSelling.VisibleIndex = 3;
            // 
            // LookUpSellingPrice
            // 
            this.LookUpSellingPrice.AutoHeight = false;
            this.LookUpSellingPrice.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpSellingPrice.Name = "LookUpSellingPrice";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcProduct);
            this.layoutControl1.Controls.Add(this.gcCategory);
            this.layoutControl1.Controls.Add(this.txtSellingPrice);
            this.layoutControl1.Controls.Add(this.txtBasePrice);
            this.layoutControl1.Controls.Add(this.txtEntryBy);
            this.layoutControl1.Controls.Add(this.sbAddCategory);
            this.layoutControl1.Controls.Add(this.sbAddProduct);
            this.layoutControl1.Controls.Add(this.sbAddNew);
            this.layoutControl1.Controls.Add(this.gcStorage);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(908, 645);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcProduct
            // 
            this.gcProduct.Location = new System.Drawing.Point(456, 108);
            this.gcProduct.MainView = this.gvProduct;
            this.gcProduct.Name = "gcProduct";
            this.gcProduct.Size = new System.Drawing.Size(440, 146);
            this.gcProduct.TabIndex = 6;
            this.gcProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProduct});
            // 
            // gvProduct
            // 
            this.gvProduct.GridControl = this.gcProduct;
            this.gvProduct.Name = "gvProduct";
            this.gvProduct.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            // 
            // gcCategory
            // 
            this.gcCategory.Location = new System.Drawing.Point(12, 108);
            this.gcCategory.MainView = this.gvCategory;
            this.gcCategory.Name = "gcCategory";
            this.gcCategory.Size = new System.Drawing.Size(440, 146);
            this.gcCategory.TabIndex = 6;
            this.gcCategory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCategory});
            // 
            // gvCategory
            // 
            this.gvCategory.GridControl = this.gcCategory;
            this.gvCategory.Name = "gvCategory";
            this.gvCategory.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Location = new System.Drawing.Point(80, 60);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Size = new System.Drawing.Size(372, 20);
            this.txtSellingPrice.StyleController = this.layoutControl1;
            this.txtSellingPrice.TabIndex = 5;
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(80, 36);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(372, 20);
            this.txtBasePrice.StyleController = this.layoutControl1;
            this.txtBasePrice.TabIndex = 5;
            // 
            // txtEntryBy
            // 
            this.txtEntryBy.Location = new System.Drawing.Point(80, 12);
            this.txtEntryBy.Name = "txtEntryBy";
            this.txtEntryBy.Size = new System.Drawing.Size(372, 20);
            this.txtEntryBy.StyleController = this.layoutControl1;
            this.txtEntryBy.TabIndex = 5;
            // 
            // sbAddCategory
            // 
            this.sbAddCategory.Location = new System.Drawing.Point(456, 60);
            this.sbAddCategory.Name = "sbAddCategory";
            this.sbAddCategory.Size = new System.Drawing.Size(440, 20);
            this.sbAddCategory.StyleController = this.layoutControl1;
            this.sbAddCategory.TabIndex = 4;
            this.sbAddCategory.Text = "Add Category";
            this.sbAddCategory.Click += new System.EventHandler(this.sbAddCategory_Click);
            // 
            // sbAddProduct
            // 
            this.sbAddProduct.Location = new System.Drawing.Point(456, 36);
            this.sbAddProduct.Name = "sbAddProduct";
            this.sbAddProduct.Size = new System.Drawing.Size(440, 20);
            this.sbAddProduct.StyleController = this.layoutControl1;
            this.sbAddProduct.TabIndex = 4;
            this.sbAddProduct.Text = "Add Product";
            this.sbAddProduct.Click += new System.EventHandler(this.sbAddProduct_Click);
            // 
            // sbAddNew
            // 
            this.sbAddNew.Location = new System.Drawing.Point(456, 12);
            this.sbAddNew.Name = "sbAddNew";
            this.sbAddNew.Size = new System.Drawing.Size(440, 20);
            this.sbAddNew.StyleController = this.layoutControl1;
            this.sbAddNew.TabIndex = 4;
            this.sbAddNew.Text = "Add Storage Item";
            this.sbAddNew.Click += new System.EventHandler(this.sbAddNew_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 100D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 100D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 24D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition3.Height = 24D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition4.Height = 24D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition5.Height = 150D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition6.Height = 100D;
            rowDefinition6.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5,
            rowDefinition6});
            this.Root.Size = new System.Drawing.Size(908, 645);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcStorage;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 246);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnSpan = 2;
            this.layoutControlItem1.OptionsTableLayoutItem.RowIndex = 5;
            this.layoutControlItem1.Size = new System.Drawing.Size(888, 379);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.sbAddNew;
            this.layoutControlItem2.Location = new System.Drawing.Point(444, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(444, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtEntryBy;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(444, 24);
            this.layoutControlItem3.Text = "Entry By";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(56, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.sbAddProduct;
            this.layoutControlItem5.Location = new System.Drawing.Point(444, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem5.Size = new System.Drawing.Size(444, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gcCategory;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlItem4.Size = new System.Drawing.Size(444, 150);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.gcProduct;
            this.layoutControlItem6.Location = new System.Drawing.Point(444, 96);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlItem6.Size = new System.Drawing.Size(444, 150);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.sbAddCategory;
            this.layoutControlItem7.Location = new System.Drawing.Point(444, 48);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem7.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem7.Size = new System.Drawing.Size(444, 24);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtBasePrice;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem8.Size = new System.Drawing.Size(444, 24);
            this.layoutControlItem8.Text = "Base Price";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(56, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtSellingPrice;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem9.Size = new System.Drawing.Size(444, 24);
            this.layoutControlItem9.Text = "Selling Price";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(56, 13);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 645);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gcStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpSellingPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSellingPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBasePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntryBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcStorage;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStorage;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton sbAddNew;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit txtEntryBy;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.GridControl gcCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCategory;
        private DevExpress.XtraEditors.SimpleButton sbAddProduct;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.GridControl gcProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProduct;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton sbAddCategory;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.TextEdit txtSellingPrice;
        private DevExpress.XtraEditors.TextEdit txtBasePrice;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCategoryId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnProductId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnProductIdSelling;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpCategory;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpProduct;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpSellingPrice;
    }
}

