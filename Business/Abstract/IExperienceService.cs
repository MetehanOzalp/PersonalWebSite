using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IExperienceService
    {
        IResult Add(Experience experience);
        IResult Delete(Experience experience);
        IResult Update(Experience experience);
        IDataResult<List<Experience>> GetAll();
    }
}
