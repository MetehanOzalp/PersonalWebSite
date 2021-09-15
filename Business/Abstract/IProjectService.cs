using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProjectService
    {
        IResult Add(Project project);
        IResult Delete(Project project);
        IResult Update(Project project);
        IDataResult<List<Project>> GetAll();
    }
}
