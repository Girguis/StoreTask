using Dapper;
using StoreTask.Models;
using System.Data;

namespace StoreTask._Repository
{
    public class UserRepo : BaseRepo, IUserRepo
    {
        public UserRepo(string connectionString) : base(connectionString)
        {

        }
        public bool Login(LoginModel model)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@UserName", model.UserName);
                parameters.Add("@Password", model.Password);

                var connection = GetConnectionInstance();
                return connection.QueryFirstOrDefault<UserModel>("UserLogin",
                    param: parameters,
                    commandType: CommandType.StoredProcedure) != null;
            }
            catch
            {
                return false;
            }
        }
    }
}
