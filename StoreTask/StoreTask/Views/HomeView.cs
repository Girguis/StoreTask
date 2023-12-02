using StoreTask.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StoreTask.Views
{
    public partial class HomeView : Form, IHomeView
    {
        public HomeView()
        {
            InitializeComponent();
            btnSave.Click += delegate { AddProductEvent?.Invoke(this, EventArgs.Empty); };
            btnRefresh.Click += delegate { RefreshEvent?.Invoke(this, EventArgs.Empty); };
            btnPrintAll.Click += delegate { PrintAllProductsEvent?.Invoke(this, EventArgs.Empty); };
        }
        public void ShowHomeView()
        {
            this.Show();
        }
        public void FillFilterCategoryCombo(List<CategoryModel> categories)
        {
            comboFilterCategory.ValueMember = "ID"; ;
            comboFilterCategory.DisplayMember = "Name";
            categories.Insert(0, new CategoryModel
            {
                ID = 0,
                Name = "All"
            });
            comboFilterCategory.DataSource = categories;
        }
        public void FillAddCategoryCombo(List<CategoryModel> categories)
        {
            comboAddCategory.ValueMember = "ID";
            comboAddCategory.DisplayMember = "Name";
            comboAddCategory.DataSource = categories;
        }
        public string FilterName
        {
            get { return lblFilterName.Text; }
            set { lblFilterName.Text = value; }
        }
        public int FilterCategoryId
        {
            get
            {
                _ = int.TryParse(comboFilterCategory.SelectedValue?.ToString(), out int val);
                return val;
            }
            set { comboFilterCategory.SelectedValue = value; }
        }
        public int FilterStock
        {
            get { return (int)numericFilterStock.Value; }
            set { numericFilterStock.Value = value; }
        }
        public decimal FilterTotalCostOfStock
        {
            get { return numericFilterTotal.Value; }
            set { numericFilterTotal.Value = value; }
        }

        public string AddName
        {
            get { return lblAddName.Text; }
            set { lblAddName.Text = value; }
        }
        public int AddCategoryId
        {
            get
            {
                _ = int.TryParse(comboAddCategory.SelectedValue?.ToString(), out int val);
                return val;
            }
            set { comboAddCategory.SelectedValue = value; }
        }
        public int AddStock
        {
            get { return (int)numericAddStock.Value; }
            set { numericAddStock.Value = value; }
        }
        public decimal AddTotalCostOfStock
        {
            get { return numericAddTotal.Value; }
            set { numericAddTotal.Value = value; }
        }
        public string AddDescription
        {
            get { return lblAddDescription.Text; }
            set { lblAddDescription.Text = value; }
        }

        public event EventHandler AddProductEvent;
        public event EventHandler<int> PrintProductEvent;
        public event EventHandler PrintAllProductsEvent;
        public event EventHandler RefreshEvent;

        public void SetProductListBindingSource(List<ProductViewModel> products)
        {
            productList.AutoGenerateColumns = false;
            productList.Columns.Clear();

            productList.Columns.Add("ID", "ID");
            productList.Columns["ID"].DataPropertyName = "ID";

            productList.Columns.Add("Name", "Name");
            productList.Columns["Name"].DataPropertyName = "Name";

            productList.Columns.Add("Category", "Category");
            productList.Columns["Category"].DataPropertyName = "Category";

            productList.Columns.Add("Stock", "Stock");
            productList.Columns["Stock"].DataPropertyName = "Stock";

            productList.Columns.Add("TotalCostOfStock", "Total");
            productList.Columns["TotalCostOfStock"].DataPropertyName = "TotalCostOfStock";

            var printCol = new DataGridViewButtonColumn();
            printCol.Name = "Print";
            printCol.Text = "Print";
            printCol.UseColumnTextForButtonValue = true;
            productList.Columns.Add(printCol);

            productList.DataSource = products;
        }

        private void productList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == productList.Columns["Print"].Index)
            {
                _ = int.TryParse(productList.Rows[e.RowIndex].Cells[0].Value?.ToString(), out int id);
                PrintProductEvent.Invoke(sender, id);
            }
        }
    }
}