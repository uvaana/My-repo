using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyAPI.Models;
using System.IO;
using System;
using System.Security.Policy;
using System.Threading.Tasks;


namespace MyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly DataDBContext _dbContext;
        public DataController(DataDBContext dBContext)
        {
             _dbContext = dBContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var Data = await _dbContext.TblData.ToListAsync();
            return Ok(Data);
        }
    }
}
