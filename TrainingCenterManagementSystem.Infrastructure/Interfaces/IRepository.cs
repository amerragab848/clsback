using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrainingCenterManagementSystem.Core.Dtos;

namespace TrainingCenterManagementSystem.Infrastructure.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T GetById(long id);
        List<T> GetAll();
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        int SaveChanges();
    }
}
