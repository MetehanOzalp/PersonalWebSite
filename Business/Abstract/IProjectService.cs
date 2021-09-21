using Core.Utilities.Results;
using Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProjectService
    {
        IResult Add(IFormFile file, Project project);
        IResult Delete(Project project);
        IResult Update(Project project);
        IDataResult<List<Project>> GetAll();
    }
}
