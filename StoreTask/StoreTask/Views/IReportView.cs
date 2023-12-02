using StoreTask.Models;
using System.Collections.Generic;

namespace StoreTask.Views
{
    public interface IReportView
    {
        void SetReportDS(List<ProductViewModel> products);
        void ShowReportView();
    }
}
