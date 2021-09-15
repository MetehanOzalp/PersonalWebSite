using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAboutMeService
    {
        IResult Add(AboutMe aboutMe);
        IResult Update(AboutMe aboutMe);
        IResult Delete(AboutMe aboutMe);
        IDataResult<AboutMe> Get();
    }
}
