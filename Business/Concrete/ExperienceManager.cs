using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal _experienceDal;

        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public IResult Add(Experience experience)
        {
            _experienceDal.Add(experience);
            return new SuccessResult(Messages.ExperienceAdded);
        }

        public IResult Delete(Experience experience)
        {
            _experienceDal.Delete(experience);
            return new SuccessResult(Messages.ExperienceDeleted);
        }

        public IDataResult<List<Experience>> GetAll(Experience experience)
        {
            return new SuccessDataResult<List<Experience>>(_experienceDal.GetAll());
        }

        public IResult Update(Experience experience)
        {
            _experienceDal.Update(experience);
            return new SuccessResult(Messages.ExperienceUpdated);
        }
    }
}
