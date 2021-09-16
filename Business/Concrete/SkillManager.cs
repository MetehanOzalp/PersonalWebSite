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
    public class SkillManager : ISkillService
    {
        ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public IResult Add(Skill skill)
        {
            _skillDal.Add(skill);
            return new SuccessResult(Messages.SkillAdded);
        }

        public IResult Delete(Skill skill)
        {
            _skillDal.Delete(skill);
            return new SuccessResult(Messages.SkillDeleted);
        }

        public IDataResult<List<Skill>> GetAll()
        {
            return new SuccessDataResult<List<Skill>>(_skillDal.GetAll());
        }

        public IResult Update(Skill skill)
        {
            _skillDal.Update(skill);
            return new SuccessResult(Messages.SkillUpdated);
        }
    }
}
