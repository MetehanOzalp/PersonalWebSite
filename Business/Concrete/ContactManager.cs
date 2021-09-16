using Business.Abstract;
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

        public IResult Delete(Contact contact)
        {
            _contactDal.Delete(contact);
            return new SuccessResult(Messages.MessageDeleted);
        }

        public IDataResult<List<Contact>> GetByReadMessage()
        {
            var result = _contactDal.GetAll(m => m.Status == true);
            return new SuccessDataResult<List<Contact>>(result);
        }

        public IDataResult<List<Contact>> GetByUnreadMessage()
        {
            var result = _contactDal.GetAll(m => m.Status == false);
            return new SuccessDataResult<List<Contact>>(result);
        }
    }
}
