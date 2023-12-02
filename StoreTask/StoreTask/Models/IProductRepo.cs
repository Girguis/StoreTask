using System.Collections.Generic;

namespace StoreTask.Models
{
    public interface IProductRepo
    {
        bool Add(AddProductModel model);
        List<ProductViewModel> Get(ProductSearchModel model = null);
        ProductViewModel GetByID(int id);
    }
}
