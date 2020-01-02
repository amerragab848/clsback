using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterManagementSystem.Services.Interfaces;
using AutoMapper;
using System.Linq;
using TrainingCenterManagementSystem.Core.Dtos;
using TrainingCenterManagementSystem.Infrastructure.Interfaces;

namespace TrainingCenterManagementSystem.Services.Implementation
{
    public class Service<DTO> : IService<DTO>
        where DTO : BaseDto
    {
        private IRepository<DTO> _repo;
        private IMapper _mapper;

        public Service(IRepository<DTO> repo)
        {
            _repo = repo;
            //_mapper = mapper;
        }

        public virtual int Add(DTO entity)
        {
            _repo.Add(entity);
            return _repo.SaveChanges();
        }

        public virtual void Delete(long id)
        {
            _repo.Delete(_repo.GetById(id));
            _repo.SaveChanges();
        }

        public void Delete(DTO entity)
        {
            throw new NotImplementedException();
        }

        public virtual int Edit(DTO entity)
        {
            _repo.Update(_mapper.Map<DTO>(entity));
            return _repo.SaveChanges();
        }

        public virtual IEnumerable<DTO> GetAll()
        {
            return _mapper.Map<List<DTO>>(_repo.GetAll().OrderByDescending(e => e.Id));
        }

        public virtual DTO GetById(long id)
        {
            return _mapper.Map<DTO>(_repo.GetById(id));
        }

        public IQueryable<DTO> List()
        {
            throw new NotImplementedException();
        }

        public void Update(DTO entity)
        {
            throw new NotImplementedException();
        }

        DTO IService<DTO>.Add(DTO entity)
        {
            throw new NotImplementedException();
        }

        List<DTO> IService<DTO>.List()
        {
            throw new NotImplementedException();
        }
    }
}
