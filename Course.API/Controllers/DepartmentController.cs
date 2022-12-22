using AutoMapper;
using Comp.API.Extensions;
using Comp.Database.Interfaces;
using Course.Common.DTOs;
using Course.Database.Contexts;
using Course.Database.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Comp.Common.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Comp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDbService _db;
        public DepartmentController(IDbService db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IResult> Get() => await _db.HttpGetAsync<Department, DepartmentDTO>();

        [HttpGet("{id}")]
        public async Task<IResult> Get(int id) => await _db.HttpGetAsync<Department, DepartmentDTO>(id);

        [HttpPost]
        public async Task<IResult> Post([FromBody] DepartmentDTO dto) => await _db.HttpPostAsync<Department, DepartmentDTO>(dto);

        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] DepartmentDTO dto) => await _db.HttpPutAsync<Department, DepartmentDTO>(dto, id);

        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id) => await _db.HttpDeleteAsync<Department>(id);
    }
}
