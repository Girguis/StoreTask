using System.Collections.Generic;

namespace StoreTask.Models
{
    public interface ICategoryRepo
    {
        List<CategoryModel> Get();
    }
}
