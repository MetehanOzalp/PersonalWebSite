using Core.Utilities.Results;
using Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAboutMeService
    {
        IResult Add(IFormFile file, AboutMe aboutMe);
        IResult Update(AboutMe aboutMe);
        IResult Delete(AboutMe aboutMe);
        IDataResult<AboutMe> Get();
    }
}
