using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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

        [SecuredOperation("admin")]
        public IResult Add(Experience experience)
        {
            _experienceDal.Add(experience);
            return new SuccessResult(Messages.ExperienceAdded);
        }

        [SecuredOperation("admin")]
        public IResult Delete(Experience experience)
        {
            _experienceDal.Delete(experience);
            return new SuccessResult(Messages.ExperienceDeleted);
        }

        public IDataResult<List<Experience>> GetAll()
        {
            var experiences = _experienceDal.GetAll();
            var orderByDescendingResult = (from e in experiences
                                           orderby e.StartDate descending
                                           select e).ToList();
            return new SuccessDataResult<List<Experience>>(experiences);
        }

        [SecuredOperation("admin")]
        public IResult Update(Experience experience)
        {
            _experienceDal.Update(experience);
            return new SuccessResult(Messages.ExperienceUpdated);
        }
    }
}
