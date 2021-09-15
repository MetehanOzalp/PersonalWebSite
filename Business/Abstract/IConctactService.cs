﻿using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IConctactService
    {
        IResult Add(Contact contact);
        IResult Delete(Contact contact);
        IResult ChangeStatus(Contact contact);
        IDataResult<List<Contact>> GetByUnreadMessage();
        IDataResult<List<Contact>> GetByReadMessage();
    }
}