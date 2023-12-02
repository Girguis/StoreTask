using Dapper;
using StoreTask.Models;
using System.Collections.Generic;
using System.Linq;

namespace StoreTask._Repository
{
    class CategoryRepo : BaseRepo, ICategoryRepo
    {
        public CategoryRepo(string connectionString) : base(connectionString)
        {
        }

        public List<CategoryModel> Get()
        {
            var connection = GetConnectionInstance();
            return connection
                .Query<CategoryModel>("GetCategories",
                        commandType: System.Data.CommandType.StoredProcedure)
                ?.ToList();
        }
    }
}
