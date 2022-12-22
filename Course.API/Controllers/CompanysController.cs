using AutoMapper;
using Comp.API.Extensions;
using Comp.Database.Interfaces;
using Course.Common.DTOs;
using Course.Database.Contexts;
using Course.Database.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Comp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanysController : ControllerBase
    {
        private readonly IDbService _db;
        public CompanysController(IDbService db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IResult> Get() => await _db.HttpGetAsync<Company, CompanyDTO>();

        [HttpGet("{id}")]
        public async Task<IResult> Get(int id) => await _db.HttpGetAsync<Company, CompanyDTO>(id);

        [HttpPost]
        public async Task<IResult> Post([FromBody] CompanyDTO dto) => await _db.HttpPostAsync<Company, CompanyDTO>(dto);

        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] CompanyDTO dto) => await _db.HttpPutAsync<Company, CompanyDTO>(dto, id);

        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id) => await _db.HttpDeleteAsync<Company>(id);



        /*
        // GET: api/<CompanysController>
        [HttpGet]
        public async Task<IResult> Get()
        {
            var companys = await _db.GetAsync<Company, CompanyDTO>();
            return Results.Ok(companys);
        }
        */


        /*
        // GET api/<CompanysController>/5
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id)
        {
            var company = await _db.GetSingleAsync<Company, CompanyDTO>(c => c.Id == id);
            return Results.Ok(company);
        }
        */


        /*
        // POST api/<CompanysController>
        [HttpPost]
        public async Task<IResult> Post([FromBody] CompanyDTO dto)
        {
            try
            {
                if (dto is null) return Results.BadRequest();
                var entity = _db.AddAsync<Company, CompanyDTO>(dto);

                if (await _db.SaveChangesAsync()) 
                {
                    var node = typeof(Company).Name.ToLower();
                    return Results.Created($"/{node}s/{entity.Id}", entity);
                }

                return Results.BadRequest();
                
            }
            catch(Exception ex)
            {
                return Results.BadRequest($"Couldn't add the {typeof(Company).Name}entity.\n{ ex}.");

            }
            
        }
        */



        /*
        // PUT api/<CompanysController>/5
        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] CompanyDTO dto)
        {
            if (dto is null) return Results.BadRequest();
            //if (id != dto.Id) return Results.BadRequest();
            if(!await _db.AnyAsync<Company>(c => c.Id.Equals(id))) return Results.NotFound();

            try
            {
                _db.Update<Company, CompanyDTO>(id, dto);
                if (await _db.SaveChangesAsync())
                {
                    var node = typeof(Company).Name.ToLower();
                    return Results.NoContent();
                }

                return Results.BadRequest();
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex);
            }
            
        }
        */


        /*
        // DELETE api/<CompanysController>/5
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id)
        {
            if (!await _db.AnyAsync<Company>(c => c.Id.Equals(id))) return Results.NotFound();
            var success = await _db.DeleteAsync<Company>(id);

            if (await _db.SaveChangesAsync())
            {
                var node = typeof(Company).Name.ToLower();
                return Results.NoContent();
            }

            return Results.BadRequest();
        }
        */

        
    }
}
