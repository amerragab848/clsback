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
    public class PriceTypesRepository:IPriceTypesRepository
    {
        private readonly TMSDbContext _TMSDbContext;
        public PriceTypesRepository(TMSDbContext dbContext)
        {
            _TMSDbContext = dbContext;
        }
        public PriceTypesDTO Add(PriceTypesDTO entity)
        {
            PriceTypes priceTypes = new PriceTypes
            {
                Id = entity.Id,
                Name = entity.Name
            };
            _TMSDbContext.PriceTypes.Add(priceTypes);
            SaveChanges();
            return entity;
        }

        public void Delete(PriceTypesDTO entity)
        {
            var priceTypes = _TMSDbContext.PriceTypes.Find(entity.Id);
            _TMSDbContext.PriceTypes.Remove(priceTypes);
            SaveChanges();
        }

        public List<PriceTypesDTO> GetAll()
        {
            return _TMSDbContext.PriceTypes.Select(c => new PriceTypesDTO
            {
                Name = c.Name,
                Id = c.Id
            }).ToList();
        }

        public PriceTypesDTO GetById(long id)
        {
            var priceTypes = _TMSDbContext.PriceTypes.Find(id);
            PriceTypesDTO priceTypesDTO = new PriceTypesDTO
            {
                Id = priceTypes.Id,
                Name = priceTypes.Name
            };
            return priceTypesDTO;
        }     

        public int SaveChanges()
        {
            return _TMSDbContext.SaveChanges();
        }

        public void Update(PriceTypesDTO entity)
        {
            var priceTypes = _TMSDbContext.PriceTypes.FirstOrDefault(c => c.Id == entity.Id);
            priceTypes = new PriceTypes
            {
                Id = entity.Id,
                Name = entity.Name

            };
            _TMSDbContext.Entry(priceTypes).State = EntityState.Modified;

        }
    }
}
