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
    public class AboutMeManager : IAboutMeService
    {
        IAboutMeDal _aboutMeDal;

        public AboutMeManager(IAboutMeDal aboutMeDal)
        {
            _aboutMeDal = aboutMeDal;
        }

        [SecuredOperation("admin")]
        public IResult Add(AboutMe aboutMe)
        {
            _aboutMeDal.Add(aboutMe);
            return new SuccessResult(Messages.AboutMeAdded);
        }

        [SecuredOperation("admin")]
        public IResult Delete(AboutMe aboutMe)
        {
            _aboutMeDal.Delete(aboutMe);
            return new SuccessResult(Messages.AboutMeDeleted);
        }

        public IDataResult<AboutMe> Get()
        {
            return new SuccessDataResult<AboutMe>(_aboutMeDal.GetAll()[0]);
        }

        [SecuredOperation("admin")]
        public IResult Update(AboutMe aboutMe)
        {
            _aboutMeDal.Update(aboutMe);
            return new SuccessResult(Messages.AboutMeUpdated);
        }
    }
}
