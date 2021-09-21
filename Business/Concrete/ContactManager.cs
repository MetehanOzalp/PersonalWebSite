using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public IResult Add(Contact contact)
        {
            contact.Status = false;
            contact.ContactDate = DateTime.Now;
            _contactDal.Add(contact);
            return new SuccessResult(Messages.MessageSent);
        }

        public IResult ChangeStatus(Contact contact)
        {
            if (!contact.Status)
            {
                contact.Status = true;
                _contactDal.Update(contact);
            }
            return new SuccessResult();
        }

        [SecuredOperation("admin")]
        public IResult Delete(Contact contact)
        {
            _contactDal.Delete(contact);
            return new SuccessResult(Messages.MessageDeleted);
        }

        [SecuredOperation("admin")]
        public IDataResult<List<Contact>> GetReadMessages()
        {
            var result = _contactDal.GetAll(m => m.Status == true);
            return new SuccessDataResult<List<Contact>>(result);
        }

        [SecuredOperation("admin")]
        public IDataResult<List<Contact>> GetUnreadMessages()
        {
            var result = _contactDal.GetAll(m => m.Status == false);
            return new SuccessDataResult<List<Contact>>(result);
        }
    }
}
