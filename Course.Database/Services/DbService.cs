using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Comp.Database.Interfaces;
using Course.Database.Contexts;
using Course.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Comp.Database.Services
{
    public class DbService : IDbService
    {
        private readonly PersonContext _db;
        private readonly IMapper _mapper;
        public DbService(PersonContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<List<TDto>> GetAsync<TEntity, TDto>() 
            where TEntity : class, IEntity 
            where TDto : class
        {
            var entities = await _db.Set<TEntity>().ToListAsync();
            return _mapper.Map<List<TDto>>(entities);

        }

        private async Task<TEntity?> GetSingleAsync<TEntity>(
            Expression<Func<TEntity, bool>> expression)
            where TEntity : class, IEntity =>
            await _db.Set<TEntity>().SingleOrDefaultAsync(expression);

        public async Task<TDto> GetSingleAsync<TEntity, TDto>(Expression<Func<TEntity, bool>> expression)
            where TEntity : class, IEntity
            where TDto : class
        {
            var entity = await GetSingleAsync(expression);
            return _mapper.Map<TDto>(entity);
        }

        public async Task<TEntity> AddAsync<TEntity, TDto>(TDto dto)
            where TEntity : class, IEntity
            where TDto : class
        {
            var entity = _mapper.Map<TEntity>(dto);
            await _db.Set<TEntity>().AddAsync(entity);
            return entity;

        }

        public async Task<bool> SaveChangesAsync() => await _db.SaveChangesAsync() >= 0;


        public void Update<TEntity, TDto>(int id, TDto dto)
            where TEntity : class, IEntity
            where TDto : class
        {
            var entity = _mapper.Map<TEntity>(dto);
            entity.Id = id;
            _db.Set<TEntity>().Update(entity);
        }

        public async Task<bool> AnyAsync<TEntity>(Expression<Func<TEntity, bool>> expression)
            where TEntity : class, IEntity =>
            await _db.Set<TEntity>().AnyAsync(expression);

        public async Task<bool> DeleteAsync<TEntity>(int id)
            where TEntity : class, IEntity
        {
            try
            {
                var entity = await GetSingleAsync<TEntity>(c => c.Id.Equals(id));
                if (entity is null) return false;
                _db.Remove(entity);
            }
            catch { throw; }

            return true;
        }

        public bool Delete<TReferenceEntity, TDto>(TDto dto)
        where TReferenceEntity : class, IReferenceEntity
        where TDto : class
        {
            try
            {
                var entity = _mapper.Map<TReferenceEntity>(dto);
                if (entity is null) return false;
                _db.Remove(entity);
            }
            catch { throw; }

            return true;
        }

        public string GetURI<TEntity>(TEntity entity) 
            where TEntity : class, IEntity
        {
            return $"/{typeof(TEntity).Name.ToLower()}s/{entity.Id}";

        }

        //test
        public async Task<TEntity> AddAsyncRef<TEntity, TDto>(TDto dto)
            where TEntity : class, IReferenceEntity
            where TDto : class
        {
            var entity = _mapper.Map<TEntity>(dto);
            await _db.Set<TEntity>().AddAsync(entity);
            return entity;

        }
    }

    
}
