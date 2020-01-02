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
    public class VendorsRepositroy:IVendorsRepositroy
    {

        private readonly TMSDbContext _TMSDbContext;
        public VendorsRepositroy(TMSDbContext dbContext)
        {
            _TMSDbContext = dbContext;
        }
        public VendorsDTO Add(VendorsDTO entity)
        {
            Vendors vendors = new Vendors
            {
                Id = entity.Id,
                Name = entity.Name
            };
            _TMSDbContext.Vendors.Add(vendors);
            SaveChanges();
            return entity;
        }

        public void Delete(VendorsDTO entity)
        {
            var vendors = _TMSDbContext.Vendors.Find(entity.Id);
            _TMSDbContext.Vendors.Remove(vendors);
            SaveChanges();
        }

        public List<VendorsDTO> GetAll()
        {
            return _TMSDbContext.Vendors.Select(c => new VendorsDTO
            {
                Name = c.Name,
                Id = c.Id
            }).ToList();
        }

        public VendorsDTO GetById(long id)
        {
            var vendors = _TMSDbContext.Vendors.Find(id);
            VendorsDTO vendorsDTO = new VendorsDTO
            {
                Id = vendors.Id,
                Name = vendors.Name
            };
            return vendorsDTO;
        }


        public int SaveChanges()
        {
            return _TMSDbContext.SaveChanges();
        }

        public void Update(VendorsDTO entity)
        {
            var vendors = _TMSDbContext.Vendors.FirstOrDefault(c => c.Id == entity.Id);
            vendors = new Vendors
            {
                Id = entity.Id,
                Name = entity.Name

            };
            _TMSDbContext.Entry(vendors).State = EntityState.Modified;

        }
    }
}
