using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DXApplication.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        readonly StorageContext db = new StorageContext();
        Category focusedCategory;
        Product focusedProduct;
        Storage focusedStorage;
        public Form1()
        {

            InitializeComponent();

            gvCategory.RowUpdated += GvCategory_RowUpdated;
            gvProduct.RowUpdated += GvProduct_RowUpdated;
            gvStorage.RowUpdated += GvStorage_RowUpdated;
            gvStorage.EditFormPrepared += GvStorage_EditFormPrepared;
            gvCategory.FocusedRowChanged += GvCategory_FocusedRowChanged;
            LookUpProduct.EditValueChanged += LookUpProduct_EditValueChanged;
            LookUpCategory.EditValueChanged += LookUpCategory_EditValueChanged;
            gvStorage.ShownEditor += GvStorage_ShownEditor;

            LookUpCategory.DataSource = db.Categories.ToList();
            LookUpCategory.ValueMember = "Id";
            LookUpCategory.DisplayMember = "Name";

            LookUpProduct.DataSource = db.Products.ToList();
            LookUpProduct.ValueMember = "Id";
            LookUpProduct.DisplayMember = "Name";

            LookUpSellingPrice.DataSource = db.Products.ToList();
            LookUpSellingPrice.ValueMember = "Id";
            LookUpSellingPrice.DisplayMember = "SellingPrice";

            gcStorage.DataSource = db.Storages.ToList();
            gcCategory.DataSource = db.Categories.ToList();
            gvCategory.Focus();
            focusedCategory = (Category)gvCategory.GetFocusedRow();
            gcProduct.DataSource = db.Products.Where(c => c.CategoryId == focusedCategory.Id).ToList();
        }

        LookUpEdit categoryIdRealEditor, productIdRealEditor, sellingPriceRealEditor;

        private void GvStorage_EditFormPrepared(object sender, DevExpress.XtraGrid.Views.Grid.EditFormPreparedEventArgs e)
        {
            categoryIdRealEditor = e.BindableControls[gridColumnCategoryId.FieldName] as LookUpEdit;
            productIdRealEditor = e.BindableControls[gridColumnProductId.FieldName] as LookUpEdit;
            sellingPriceRealEditor = e.BindableControls[gridColumnProductIdSelling.FieldName] as LookUpEdit;
            SetupProductIdDataSource(categoryIdRealEditor.EditValue);
            if (categoryIdRealEditor != null)
            {
                categoryIdRealEditor.EditValueChanged -= CategoryIdRealEditor_EditValueChanged;
                categoryIdRealEditor.EditValueChanged += CategoryIdRealEditor_EditValueChanged;
            }
            if (productIdRealEditor != null)
            {
                productIdRealEditor.EditValueChanged -= ProductIdRealEditor_EditValueChanged;
                productIdRealEditor.EditValueChanged += ProductIdRealEditor_EditValueChanged;
            }
        }

        private void SetupProductIdDataSource(object categoryEditValue)
        {
            Category _category = new Category
            {
                Id = (Guid)categoryEditValue
            };
            List<Product> AllProductsOfSelectedCategory = db.Products.Where(c => c.CategoryId == _category.Id).ToList();
            productIdRealEditor.Properties.DataSource = AllProductsOfSelectedCategory;
        }

        private void ProductIdRealEditor_EditValueChanged(object sender, EventArgs e)
        {
            var lookup = sender as LookUpEdit;
            lookup.DataBindings["EditValue"]?.WriteValue();

            Product _product = (Product)lookup.GetSelectedDataRow();
            sellingPriceRealEditor.EditValue = _product.SellingPrice;
        }

        private void CategoryIdRealEditor_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit edit = sender as LookUpEdit;
            if ((Guid)edit.EditValue == Guid.Empty) return;
            edit.DataBindings["EditValue"]?.WriteValue(); 
            Category _category = new Category
            {
                Id = (Guid)edit.EditValue
            };
            List<Product> AllProductsOfSelectedCategory = db.Products.Where(c => c.CategoryId == _category.Id).ToList();
            productIdRealEditor.Properties.DataSource = AllProductsOfSelectedCategory;
            productIdRealEditor.ItemIndex = 0; 
        }

        private void LookUpCategory_EditValueChanged(object sender, EventArgs e)
        {
            //gvStorage.PostEditor();
            //gvStorage.SetFocusedRowCellValue("ProductId", null);
        }

        private void LookUpProduct_EditValueChanged(object sender, EventArgs e)
        {
            //gvStorage.PostEditor();
        }

        private List<Product> GetProductsByCategory(Guid categoryId)
        {
            return db.Products.Where(c => c.CategoryId == categoryId).ToList();
        }

        private void GvStorage_ShownEditor(object sender, EventArgs e)
        {
            //ColumnView view = (ColumnView)sender;
            //if (view.FocusedColumn.FieldName == "ProductId")
            //{
            //    LookUpEdit editor = (LookUpEdit)view.ActiveEditor;
            //    Guid categoryId = (Guid)view.GetFocusedRowCellValue("CategoryId");
            //    editor.Properties.DataSource = GetProductsByCategory(categoryId);
            //}
        }

        private void GvCategory_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            focusedCategory = (Category)gvCategory.GetFocusedRow();
            List<Product> listOfProductsOfSelectedCategory = db.Products.Where(c => c.CategoryId == focusedCategory.Id).ToList();
            gcProduct.DataSource = listOfProductsOfSelectedCategory;
        }

        private void GvStorage_RowUpdated(object sender, RowObjectEventArgs e)
        {
            focusedStorage = (Storage)gvStorage.GetFocusedRow();
            db.Storages.AddOrUpdate(focusedStorage);
            db.SaveChanges();
        }

        private void GvProduct_RowUpdated(object sender, RowObjectEventArgs e)
        {
            focusedProduct = (Product)gvProduct.GetFocusedRow();
            db.Products.AddOrUpdate(focusedProduct);
            db.SaveChanges();
        }

        private void GvCategory_RowUpdated(object sender, RowObjectEventArgs e)
        {
            focusedCategory = (Category)gvCategory.GetFocusedRow();
            db.Categories.AddOrUpdate(focusedCategory);
            db.SaveChanges();
        }

        private void sbAddNew_Click(object sender, EventArgs e)
        {
            db.Storages.Add(new Storage
            {
                Id = Guid.NewGuid(),
                EntryBy = txtEntryBy.Text,
                In = DateTime.Now,
                Out = DateTime.Now.AddDays(10),
                CategoryId = db.Categories.First().Id,
                ProductId = db.Products.First().Id

            });
            db.SaveChanges();
            List<Storage> listOfAllCStoredItems = db.Storages.ToList();
            gcStorage.DataSource = listOfAllCStoredItems;
        }

        private void sbAddProduct_Click(object sender, EventArgs e)
        {
            focusedCategory = (Category)gvCategory.GetFocusedRow();
            db.Products.Add(new Product
            {
                Id = Guid.NewGuid(),
                CategoryId = focusedCategory.Id,
                Name = "New Product",
                StoreQuantity = 1,
                BasePrice = Convert.ToDecimal(txtBasePrice.Text),
                SellingPrice = Convert.ToDecimal(txtSellingPrice.Text),
            });
            db.SaveChanges();
            List<Product> listOfProductsOfSelectedCategory = db.Products.Where(c => c.CategoryId == focusedCategory.Id).ToList();
            gcProduct.DataSource = listOfProductsOfSelectedCategory;
        }

        private void sbAddCategory_Click(object sender, EventArgs e)
        {
            db.Categories.Add(new Category
            {
                Id = Guid.NewGuid(),
                Name = "New Category"
            });
            db.SaveChanges();
            List<Category> listOfAllCategories = db.Categories.ToList();
            gcCategory.DataSource = listOfAllCategories;
        }
    }
}
