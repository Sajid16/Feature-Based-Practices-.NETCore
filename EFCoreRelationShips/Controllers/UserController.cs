using EFCoreRelationShips.Data;
using EFCoreRelationShips.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreRelationShips.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public UserController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        [Route("getAll")]
        public async Task<ActionResult<List<User>>> GetAll()
        {
            try
            {
                var users = await _dataContext.Users.AsQueryable()
                            .Include(x=> x.Characters) // this line helps me to get the neted json data as array/object form
                            .ToListAsync();
                //foreach (var user in users)
                //{
                //    List<Character> userCharacters = new List<Character>();
                //    var characters = await _dataContext.Characters.Where(x => x.UserId == user.Id)
                //                    .ToListAsync();
                //    userCharacters.Add(characters);
                //}
                return Ok(users);
            }
            catch (System.Exception ex)
            {
                return Conflict(ex.Message);
            }
        }
    }
}
