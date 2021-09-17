using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constant;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using DataAccess.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        [SecuredOperation("admin")]
        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.Id == id));
        }

        public IDataResult<User> GetByMail(string mail)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.Email == mail));
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            return new SuccessDataResult<List<OperationClaim>>(_userDal.GetClaims(user));
        }

        public IResult Update(UserForUpdateDto userForUpdateDto)
        {
            var result = _userDal.Get(u => u.Id == userForUpdateDto.Id);
            if (result == null)
            {
                return new ErrorResult(Messages.UserNotFound);
            }
            byte[] passwordHash, passwodSalt;
            HashingHelper.CreatePasswordHash(userForUpdateDto.Password, out passwordHash, out passwodSalt);
            var user = new User
            {
                Id = result.Id,
                FirstName = userForUpdateDto.FirstName,
                LastName = userForUpdateDto.LastName,
                Email = userForUpdateDto.Email,
                PasswordHash = passwordHash,
                PasswordSalt = passwodSalt,
                Status = result.Status
            };
            _userDal.Add(user);
            return new SuccessResult(Messages.UserUpdated);
        }
    }
}
