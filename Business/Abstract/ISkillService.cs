using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISkillService
    {
        IResult Add(Skill skill);
        IResult Delete(Skill skill);
        IResult Update(Skill skill);
        IDataResult<List<Skill>> GetAll();
    }
}
