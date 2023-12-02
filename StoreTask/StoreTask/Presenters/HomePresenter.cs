using StoreTask.Models;
using StoreTask.Views;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace StoreTask.Presenters
{
    public class HomePresenter
    {
        private readonly IProductRepo productRepo;
        private readonly IHomeView homeView;
        public HomePresenter(ICategoryRepo categoryRepo,
                            IProductRepo productRepo,
                            IHomeView homeView)
        {
            this.productRepo = productRepo;
            this.homeView = homeView;
            this.homeView.AddProductEvent += AddProductEvent;
            this.homeView.RefreshEvent += RefreshEvent;
            this.homeView.PrintProductEvent += PrintProductEvent;
            this.homeView.PrintAllProductsEvent += PrintAllProductsEvent;
            this.homeView.FillFilterCategoryCombo(categoryRepo.Get());
            this.homeView.FillAddCategoryCombo(categoryRepo.Get());
        }

        private void PrintAllProductsEvent(object sender, EventArgs e)
        {
            var products = GetProducts();
            ShowReportView(products);
        }

        private void PrintProductEvent(object sender, int id)
        {
            var product = productRepo.GetByID(id);
            ShowReportView(new List<ProductViewModel>() { product });
        }
        private void ShowReportView(List<ProductViewModel> products)
        {
            IReportView reportView = new ReportView();
            ReportPresenter reportPresenter = new ReportPresenter(reportView);
            reportPresenter.SetReportDataSource(products);
            reportPresenter.Show();
        }

        public void Show()
        {
            this.homeView.ShowHomeView();
        }
        private void RefreshEvent(object sender, EventArgs e)
        {
            var products = GetProducts();
            homeView.SetProductListBindingSource(products);
        }
        private List<ProductViewModel> GetProducts()
        {
            return productRepo.Get(new ProductSearchModel
            {
                CategoryID = homeView.FilterCategoryId == 0 ? default(int?) : homeView.FilterCategoryId,
                Name = homeView.FilterName,
                Stock = homeView.FilterStock == 0 ? default(int?) : homeView.FilterStock,
                TotalCostOfStock = homeView.FilterTotalCostOfStock == 0 ? default(decimal?) : homeView.FilterTotalCostOfStock
            });
        }

        private void AddProductEvent(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(homeView.AddName))
            {
                MessageBox.Show("Product name is required");
                return;
            }
            if (!Regex.IsMatch(homeView.AddName, @"^[A-Za-z\s]+$"))
            {
                MessageBox.Show("Product name must contain letters only");
                return;
            }
            if (homeView.AddStock < 1)
            {
                MessageBox.Show("Product stock must be greater than 0");
                return;
            }
            if (homeView.AddTotalCostOfStock < 1)
            {
                MessageBox.Show("Product total cost of stock must be greater than 0");
                return;
            }
            if (homeView.AddCategoryId < 1)
            {
                MessageBox.Show("Please select category");
                return;
            }
            var added = productRepo.Add(new AddProductModel
            {
                CategoryID = homeView.AddCategoryId,
                Description = homeView.AddDescription,
                Name = homeView.AddName,
                Stock = homeView.AddStock,
                TotalCostOfStock = homeView.AddTotalCostOfStock
            });
            if (added)
                MessageBox.Show("Product added sucessfully");
            else
                MessageBox.Show("Error occured while adding product");
        }
    }
}
