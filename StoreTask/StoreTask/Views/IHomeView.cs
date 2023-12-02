using StoreTask.Models;
using System;
using System.Collections.Generic;

namespace StoreTask.Views
{
    public interface IHomeView
    {
        string FilterName { get; set; }
        int FilterCategoryId { get; set; }
        int FilterStock { get; set; }
        decimal FilterTotalCostOfStock { get; set; }

        string AddName { get; set; }
        int AddCategoryId { get; set; }
        int AddStock { get; set; }
        decimal AddTotalCostOfStock { get; set; }
        string AddDescription { get; set; }

        event EventHandler AddProductEvent;
        event EventHandler<int> PrintProductEvent;
        event EventHandler PrintAllProductsEvent;
        event EventHandler RefreshEvent;

        void SetProductListBindingSource(List<ProductViewModel> products);
        void FillAddCategoryCombo(List<CategoryModel> categories);
        void FillFilterCategoryCombo(List<CategoryModel> categories);
        void ShowHomeView();
    }
}
