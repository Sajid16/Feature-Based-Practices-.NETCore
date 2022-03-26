using EFCoreRelationShips.Data;
using EFCoreRelationShips.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreRelationShips.Controllers
{
    [Route("api/character")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public CharacterController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        [Route("getAll/{userId}")]
        public async Task<ActionResult<List<Character>>> Get(int userId)
        {
            try
            {
                var characters = await _dataContext.Characters.Where(x => x.UserId == userId)
                                .ToListAsync();
                return Ok(characters);
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }

        [HttpGet]
        [Route("getAllWithWeapon/{userId}")]
        public async Task<ActionResult<List<Character>>> GetWithWeapon(int userId)
        {
            try
            {
                var characters = await _dataContext.Characters.Where(x => x.UserId == userId)
                                //.Include(x=> x.User)
                                .Include(x=> x.Weapon)
                                .ToListAsync();
                return Ok(characters);
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }

        [HttpGet]
        [Route("getAllWithWeaponAndSkills/{userId}")]
        public async Task<ActionResult<List<Character>>> GetWithWeaponAndSkills(int userId)
        {
            try
            {
                var characters = await _dataContext.Characters.Where(x => x.UserId == userId)
                                //.Include(x => x.User)
                                .Include(x => x.Weapon)
                                .Include(x => x.Skills)
                                .ToListAsync();
                return Ok(characters);
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }

        [HttpPost]
        [Route("create")]
        public async Task<ActionResult<bool>> Create([FromBody] Character character)
        {
            try
            {
                var characterInsert = _dataContext.Characters.Add(character);
                await _dataContext.SaveChangesAsync();
                return Ok(true);
            }
            catch (Exception ex)
            {
                return Conflict(false);
            }
        }

    }
}
