using StoreTask.Models;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace StoreTask.Views
{
    public partial class ReportView : Form, IReportView
    {
        public ReportView()
        {
            InitializeComponent();
        }
        public void SetReportDS(List<ProductViewModel> products)
        {
            this.ProductReportView.SetDataSource(products);
        }

        public void ShowReportView()
        {
            this.Show();
        }
    }
}
