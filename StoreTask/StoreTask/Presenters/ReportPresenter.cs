using StoreTask.Models;
using StoreTask.Views;
using System.Collections.Generic;

namespace StoreTask.Presenters
{
    public class ReportPresenter
    {
        private readonly IReportView reportView;

        public ReportPresenter(IReportView reportView)
        {
            this.reportView = reportView;
        }
        public void Show()
        {
            this.reportView.ShowReportView();
        }
        public void SetReportDataSource(List<ProductViewModel> products)
        {
            reportView.SetReportDS(products);
        }
    }
}
