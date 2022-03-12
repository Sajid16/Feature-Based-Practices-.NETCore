using DapperAPI.Services.Abstractions;
using DataAccess.Data;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace DapperAPI.Services.Implementations
{
    public class UserServices : IUserServices
    {
        private readonly IUserData _userData;

        public UserServices(IUserData userData)
        {
            _userData = userData;
        }

        public async Task<bool> DeleteUser(int id)
        {
            try
            {
                await _userData.DeleteUser(id);
                return true;
            }
            catch (Exception exception)
            {
                return false;
            }
        }

        public UserModel GetUser(int id)
        {
            try
            {
                UserModel user = _userData.GetUser(id).Result;
                return user;
            }
            catch (Exception exception)
            {
                return null;
            }
        }

        public IEnumerable<UserModel> GetUsers()
        {
            try
            {
                IEnumerable<UserModel> userList = _userData.GetUsers().Result;
                return userList;
            }
            catch (Exception exception)
            {
                return null;
            }
        }

        public async Task<bool> InsertUser(UserModel user)
        {
            try
            {
                await _userData.InsertUser(user);
                return true;
            }
            catch (Exception exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdateUser(UserModel user)
        {
            try
            {
                await _userData.UpdateUser(user);
                return true;
            }
            catch (Exception exception)
            {
                return false;
            }
        }
    }
}
