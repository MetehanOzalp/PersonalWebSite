using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IContactService
    {
        IResult Add(Contact contact);
        IResult Delete(Contact contact);
        IResult ChangeStatus(Contact contact);
        IDataResult<List<Contact>> GetAll();
        IDataResult<List<Contact>> GetUnreadMessages();
        IDataResult<List<Contact>> GetReadMessages();
    }
}
