using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DatingApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValueController : ControllerBase
    {
        private readonly DataContext _dbContext;
        public ValueController(DataContext dbContext)
        {
            this._dbContext = dbContext;

        }
        [HttpGet]
        public async Task<IActionResult> GetValue()
        {
            var value = await (from val in _dbContext.Values
                               select val).ToListAsync();

            return Ok(value);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            var value = await (from val in _dbContext.Values
                         where val.id == id
                        select val).FirstOrDefaultAsync();

            return Ok(value);
        }
    }
}
