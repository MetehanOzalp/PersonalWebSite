using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class EducationManager : IEducationService
    {
        IEducationDal _educationDal;

        public EducationManager(IEducationDal educationDal)
        {
            _educationDal = educationDal;
        }

        [SecuredOperation("admin")]
        public IResult Add(Education education)
        {
            _educationDal.Add(education);
            return new SuccessResult(Messages.EducationAdded);
        }

        [SecuredOperation("admin")]
        public IResult Delete(Education education)
        {
            _educationDal.Delete(education);
            return new SuccessResult(Messages.EducationDeleted);
        }

        public IDataResult<List<Education>> GetAll()
        {
            return new SuccessDataResult<List<Education>>(_educationDal.GetAll());
        }

        [SecuredOperation("admin")]
        public IResult Update(Education education)
        {
            _educationDal.Update(education);
            return new SuccessResult(Messages.EducationUpdated);
        }
    }
}
