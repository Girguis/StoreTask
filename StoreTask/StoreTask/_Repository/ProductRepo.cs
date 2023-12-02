using Dapper;
using StoreTask.Models;
using System.Collections.Generic;
using System.Linq;

namespace StoreTask._Repository
{
    public class ProductRepo : BaseRepo, IProductRepo
    {
        public ProductRepo(string connectionString) : base(connectionString)
        {
        }

        public bool Add(AddProductModel model)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("Name", model.Name);
                parameters.Add("Stock", model.Stock);
                parameters.Add("CategoryID", model.CategoryID);
                parameters.Add("TotalCostOfStock", model.TotalCostOfStock);
                parameters.Add("Description", model.Description);

                var connection = GetConnectionInstance();
                return connection.Execute("AddProduct",
                    param: parameters,
                    commandType: System.Data.CommandType.StoredProcedure) > 0;
            }
            catch
            {
                return false;
            }
        }

        public List<ProductViewModel> Get(ProductSearchModel model = null)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("Name", model.Name);
                parameters.Add("Stock", model.Stock);
                parameters.Add("CategoryID", model.CategoryID);
                parameters.Add("TotalCostOfStock", model.TotalCostOfStock);

                var connection = GetConnectionInstance();
                return connection.Query<ProductViewModel>("GetProducts",
                    param: parameters,
                    commandType: System.Data.CommandType.StoredProcedure)
                    ?.ToList();
            }
            catch
            {
                return new List<ProductViewModel>();
            }
        }
        public ProductViewModel GetByID(int id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("ID", id);

                var connection = GetConnectionInstance();
                return connection.QueryFirstOrDefault<ProductViewModel>("GetProduct",
                    param: parameters,
                    commandType: System.Data.CommandType.StoredProcedure);
            }
            catch
            {
                return new ProductViewModel();
            }
        }
    }
}
