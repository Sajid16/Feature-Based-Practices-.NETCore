using DapperAPI.Services.Abstractions;
using DataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperAPI.Controllers
{
    [Route("api/user-services")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserServices _userServices;

        public UsersController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        [HttpGet]
        [Route("get-users")]
        public IActionResult GetUsers()
        {
            try
            {
                var result = _userServices.GetUsers();
                if (result != null) return Ok(result);
                return Problem();
            }
            catch (Exception ex)
            {
                return Conflict(ex);
            }
        }

        [HttpGet]
        [Route("get-user/{id}")]
        public IActionResult GetUser(int id)
        {
            try
            {
                var result = _userServices.GetUser(id);
                if (result != null) return Ok(result);
                return Problem();
            }
            catch (Exception ex)
            {
                return Conflict(ex);
            }
        }

        [HttpDelete]
        [Route("delete-user/{id}")]
        public IActionResult DeleteUser(int id)
        {
            try
            {
                var result = _userServices.DeleteUser(id).Result;
                if (result) return Ok(result);
                return Problem();
            }
            catch (Exception ex)
            {
                return Conflict(ex);
            }
        }

        [HttpPost]
        [Route("save-user")]
        public IActionResult InsertUser(UserModel user)
        {
            try
            {
                var result = _userServices.InsertUser(user).Result;
                if (result) return Ok(result);
                return Problem();
            }
            catch (Exception ex)
            {
                return Conflict(ex);
            }
        }

        [HttpPut]
        [Route("update-user")]
        public IActionResult UpdateUser(UserModel user)
        {
            try
            {
                var result = _userServices.UpdateUser(user).Result;
                if (result) return Ok(result);
                return Problem();
            }
            catch (Exception ex)
            {
                return Conflict(ex);
            }
        }
    }
}
