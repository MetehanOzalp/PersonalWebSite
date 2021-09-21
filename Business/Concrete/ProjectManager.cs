using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constant;
using Core.Utilities.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProjectManager : IProjectService
    {
        IProjectDal _projectDal;

        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        [SecuredOperation("admin")]
        public IResult Add(IFormFile file, Project project)
        {
            project.ProjectThumbnail = FileHelper.Add(file);
            _projectDal.Add(project);
            return new SuccessResult(Messages.ProjectAdded);
        }

        [SecuredOperation("admin")]
        public IResult Delete(Project project)
        {
            _projectDal.Delete(project);
            return new SuccessResult(Messages.ProjectDeleted);
        }

        public IDataResult<List<Project>> GetAll()
        {
            return new SuccessDataResult<List<Project>>(_projectDal.GetAll());
        }

        [SecuredOperation("admin")]
        public IResult Update(Project project)
        {
            _projectDal.Update(project);
            return new SuccessResult(Messages.ProjectUpdated);
        }
    }
}
