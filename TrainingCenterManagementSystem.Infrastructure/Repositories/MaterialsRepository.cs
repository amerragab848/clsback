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
   public class MaterialsRepository:IMaterialsRepository
    {

        private readonly TMSDbContext _TMSDbContext;
        public MaterialsRepository(TMSDbContext dbContext)
        {
            _TMSDbContext = dbContext;
        }
        public MaterialsDTO Add(MaterialsDTO entity)
        {
            Materials materials = new Materials
            {
                Id = entity.Id,
                Name = entity.Name
            };
            _TMSDbContext.Materials.Add(materials);
            SaveChanges();
            return entity;
        }

        public void Delete(MaterialsDTO entity)
        {
            var materials = _TMSDbContext.Materials.Find(entity.Id);
            _TMSDbContext.Materials.Remove(materials);
            SaveChanges();
        }

        public List<MaterialsDTO> GetAll()
        {
            return _TMSDbContext.Materials.Select(c => new MaterialsDTO
            {
                Name = c.Name,
                Id = c.Id
            }).ToList();
        }

        public MaterialsDTO GetById(long id)
        {
            var materials = _TMSDbContext.Materials.Find(id);
            MaterialsDTO materialsDTO = new MaterialsDTO
            {
                Id = materials.Id,
                Name = materials.Name
            };
            return materialsDTO;
        }



        public int SaveChanges()
        {
            return _TMSDbContext.SaveChanges();
        }

        public void Update(MaterialsDTO entity)
        {
            var materials = _TMSDbContext.Materials.FirstOrDefault(c => c.Id == entity.Id);
            materials = new Materials
            {
                Id = entity.Id,
                Name = entity.Name

            };
            _TMSDbContext.Entry(materials).State = EntityState.Modified;

        }
    }
}
