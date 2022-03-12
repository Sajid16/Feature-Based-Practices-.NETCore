using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperAPI.Services.Abstractions
{
    public interface IUserServices
    {
        IEnumerable<UserModel> GetUsers();
        UserModel GetUser(int id);
        Task<bool> InsertUser(UserModel user);
        Task<bool> UpdateUser(UserModel user);
        Task<bool> DeleteUser(int id);
    }
}
