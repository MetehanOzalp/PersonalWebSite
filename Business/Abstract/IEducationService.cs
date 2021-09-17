using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IEducationService
    {
        IResult Add(Education education);
        IResult Delete(Education education);
        IResult Update(Education education);
        IDataResult<List<Education>> GetAll();
    }
}
