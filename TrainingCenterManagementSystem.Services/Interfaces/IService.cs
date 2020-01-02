using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrainingCenterManagementSystem.Core.Dtos;

namespace TrainingCenterManagementSystem.Services.Interfaces
{
    public interface IService<T>
        where T : class
    {
        T GetById(long id);
        List<T> List();
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
