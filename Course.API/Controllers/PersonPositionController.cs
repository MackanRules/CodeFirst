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
    public class PersonPositionController : ControllerBase
    {
        private readonly IDbService _db;
        public PersonPositionController(IDbService db)
        {
            _db = db;
        }

        /*
        [HttpGet]
        public async Task<IResult> Get() => await _db.HttpGetAsync<PersonPosition, PersonPositionDTO>();

        [HttpGet("{id}")]
        public async Task<IResult> Get(int id) => await _db.HttpGetAsync<PersonPosition, PersonPositionDTO>(id);

        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] PersonPositionDTO dto) => await _db.HttpPutAsync<PersonPosition, PersonPositionDTO>(dto, id);
        */

        [HttpPost]
        public async Task<IResult> Post([FromBody] PersonPositionDTO dto) => await _db.HttpAddAsync<PersonPosition, PersonPositionDTO>(dto);

        [HttpDelete("{id}")]
        public async Task<IResult> Delete(PersonPositionDTO dto) => await _db.HttpDeleteAsync<PersonPosition, PersonPositionDTO>(dto);

        
    }

}
