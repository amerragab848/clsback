using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrainingCenterManagementSystem.Core.Dtos;
using TrainingCenterManagementSystem.Infrastructure.Interfaces;
using TrainingCenterManagementSystem.Services.Interfaces;

namespace TrainingCenterManagementSystem.Services.Implementation
{
    public class ExamService :IExamService
    {
        IExamRepository _repository;
        public ExamService(IExamRepository repository)
        {
            _repository = repository;
        }
        public ExamsDTO AddExam(ExamsDTO entity)
        {
            if(entity!=null)
            _repository.Add(entity);
            return entity;
        }

        public void DeleteExam(ExamsDTO entity)
        {
            if (entity != null)
                _repository.Delete(entity);
        }

        public ExamsDTO GetExamById(long id)
        {
            var exm=new ExamsDTO() ;
            if (id > 0)
            {
                 exm = _repository.GetById(id);

            }
            return exm;
        }

        public List<ExamsDTO> GetAllExams()
        {
          var exams=  _repository.GetAll().ToList();
            return exams;
        }

       

        public void UpdateExam(ExamsDTO entity)
        {
            if(entity!=null)
            _repository.Update(entity);
        }
    }
}
