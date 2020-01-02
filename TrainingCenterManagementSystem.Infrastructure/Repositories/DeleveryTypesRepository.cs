using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrainingCenterManagementSystem.Core.Dtos;
using TrainingCenterManagementSystem.Infrastructure.Interfaces;
using TrainingCenterManagementSystem.Infrastructure.Data;

namespace TrainingCenterManagementSystem.Infrastructure.Repositories
{
    public class DeleveryTypesRepository:IDeleveryTypesRepository
    {
        private readonly TMSDbContext _TMSDbContext;
        public DeleveryTypesRepository(TMSDbContext dbContext)
        {
            _TMSDbContext = dbContext;
        }
        public DeleveryTypesDTO Add(DeleveryTypesDTO entity)
        {
            DeleveryTypes deleveryTypes = new DeleveryTypes
            {
                Id = entity.Id,
                Name = entity.Name
            };
            _TMSDbContext.DeleveryTypes.Add(deleveryTypes);
            SaveChanges();
            return entity;
        }

      

        public void Delete(DeleveryTypesDTO entity)
        {
            var deleveryTypes = _TMSDbContext.DeleveryTypes.Find(entity.Id);
            _TMSDbContext.DeleveryTypes.Remove(deleveryTypes);
            SaveChanges();
        }

        public List<DeleveryTypesDTO> GetAll()
        {
            return _TMSDbContext.DeleveryTypes.Select(c => new DeleveryTypesDTO
            {
                Name = c.Name,
                Id = c.Id
            }).ToList();
        }

        public DeleveryTypesDTO GetById(long id)
        {
            var deleveryTypes = _TMSDbContext.DeleveryTypes.Find(id);
            DeleveryTypesDTO deleveryTypesDTO = new DeleveryTypesDTO
            {
                Id = deleveryTypes.Id,
                Name = deleveryTypes.Name
            };
            return deleveryTypesDTO;
        }

        public int SaveChanges()
        {
            return _TMSDbContext.SaveChanges();
        }

        public void Update(DeleveryTypesDTO entity)
        {
            var deleveryTypes = _TMSDbContext.DeleveryTypes.FirstOrDefault(c => c.Id == entity.Id);
            deleveryTypes = new DeleveryTypes
            {
                Id = entity.Id,
                Name = entity.Name

            };
            _TMSDbContext.Entry(deleveryTypes).State = EntityState.Modified;

        }
    }
}
