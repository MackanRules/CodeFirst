using AutoMapper;
using Comp.Database.Interfaces;
using Course.Common.DTOs;
using Course.Database.Entities;

namespace Comp.API.Extensions
{
    public static class HttpExtensions
    {
       
        public static async Task<IResult> HttpGetAsync<TEntity, TDto>(this IDbService db)
            where TEntity : class, IEntity
            where TDto : class
        {
            var entities = await db.GetAsync<TEntity, TDto>();
            return Results.Ok(entities);
        }

        public static async Task<IResult> HttpGetAsync<TEntity, TDto>(this IDbService db, int id)
            where TEntity : class, IEntity
            where TDto : class
        {
            var entity = await db.GetSingleAsync<TEntity, TDto>(c => c.Id == id);
            if (entity is null) return Results.BadRequest();
            return Results.Ok(entity);
        }

        public static async Task<IResult> HttpPostAsync<TEntity, TDto>(this IDbService db, TDto dto)
            where TEntity : class, IEntity
            where TDto : class
        {
            if (dto is null) return Results.BadRequest();
            var entity = await db.AddAsync<TEntity, TDto>(dto);

            if (await db.SaveChangesAsync())
            {
                return Results.Created(db.GetURI<TEntity>(entity), entity);
                
            }

            return Results.BadRequest();
        }

        public static async Task<IResult> HttpPutAsync<TEntity, TDto>(this IDbService db, TDto dto, int id)
            where TEntity : class, IEntity
            where TDto : class
        {
            if (dto is null) return Results.BadRequest();

            if (!await db.AnyAsync<TEntity>(c => c.Id.Equals(id))) return Results.NotFound();

            
            db.Update<TEntity, TDto>(id, dto);

            if (await db.SaveChangesAsync())
            {
                return Results.NoContent();
            }

            return Results.BadRequest();
        }

        public static async Task<IResult> HttpDeleteAsync<TEntity>(this IDbService db, int id)
            where TEntity : class, IEntity
        {
            try
            {
                var success = await db.DeleteAsync<TEntity>(id);

                if (await db.SaveChangesAsync())
                {
                    return Results.NoContent();
                }
            }
            catch 
            {
               
            }

            return Results.BadRequest();
        }


        public static async Task<IResult> HttpDeleteAsync<TReferenceEntity, TDto>(this IDbService db, TDto dto)
            where TReferenceEntity : class, IReferenceEntity
            where TDto : class
        {
            try
            {
                if (!db.Delete<TReferenceEntity, TDto>(dto)) return Results.NotFound();
                if (await db.SaveChangesAsync()) return Results.NoContent();
            }
            catch (Exception ex)
            {
                return Results.BadRequest();
            }
            return Results.BadRequest();
        }

        //test
        public static async Task<IResult> HttpAddAsync<TEntity, TDto>(this IDbService db, TDto dto)
            where TEntity : class, IReferenceEntity
            where TDto : class
        {
            if (dto is null) return Results.BadRequest();
            var entity = await db.AddAsyncRef<TEntity, TDto>(dto);

            if (await db.SaveChangesAsync())
            {
                return Results.NoContent();

            }

            return Results.BadRequest();
        }

    }
}
