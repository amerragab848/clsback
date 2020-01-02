using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrainingCenterManagementSystem.Core.Dtos;
using TrainingCenterManagementSystem.Infrastructure.Data;
using TrainingCenterManagementSystem.Infrastructure.Interfaces;

namespace TrainingCenterManagementSystem.Infrastructure.Repositories
{
    //public class EfRepository<T> : IRepository<T> where T : BaseDto
    //{
    //    private readonly TMSDbContext _dbContext;

    //    public EfRepository(TMSDbContext dbContext)
    //    {
    //        _dbContext = dbContext;
    //    }

    //    public T GetById(long id)
    //    {
    //        return _dbContext.Set<T>().SingleOrDefault(e => e.Id == id);
    //    }

    //    public IQueryable<T> List()
    //    {
    //        return _dbContext.Set<T>().AsNoTracking();
    //    }

    //    public T AddNew(T entity)
    //    {
    //        _dbContext.Set<T>().Add(entity);
    //        return entity;
    //    }

    //    public void Delete(T entity)
    //    {
    //        _dbContext.Set<T>().Remove(entity);
    //    }

    //    public void Update(T entity)
    //    {
    //        _dbContext.Entry(entity).State = EntityState.Modified;
    //    }

    //    public int SaveChanges()
    //    {
    //        return _dbContext.SaveChanges();
    //    }

    //    public T Add(T entity)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
