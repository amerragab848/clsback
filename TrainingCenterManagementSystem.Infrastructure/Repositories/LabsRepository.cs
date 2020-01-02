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
    public class LabsRepository:ILabsRepository
    {

        private readonly TMSDbContext _TMSDbContext;
        public LabsRepository(TMSDbContext dbContext)
        {
            _TMSDbContext = dbContext;
        }
        public LabsDTO Add(LabsDTO entity)
        {
            Labs labs = new Labs
            {
                Id = entity.Id,
                Name = entity.Name
            };
            _TMSDbContext.Labs.Add(labs);
            SaveChanges();
            return entity;
        }

        public void Delete(LabsDTO entity)
        {
            var labs = _TMSDbContext.Labs.Find(entity.Id);
            _TMSDbContext.Labs.Remove(labs);
            SaveChanges();
        }

        public List<LabsDTO> GetAll()
        {
            return _TMSDbContext.Labs.Select(c => new LabsDTO
            {
                Name = c.Name,
                Id = c.Id
            }).ToList();
        }

        public LabsDTO GetById(long id)
        {
            var labs = _TMSDbContext.Labs.Find(id);
            LabsDTO labsDTO = new LabsDTO
            {
                Id = labs.Id,
                Name = labs.Name
            };
            return labsDTO;
        }


        public int SaveChanges()
        {
            return _TMSDbContext.SaveChanges();
        }

        public void Update(LabsDTO entity)
        {
            var labs= _TMSDbContext.Labs.FirstOrDefault(c => c.Id == entity.Id);
            labs = new Labs
            {
                Id = entity.Id,
                Name = entity.Name

            };
            _TMSDbContext.Entry(labs).State = EntityState.Modified;

        }
    }
}
