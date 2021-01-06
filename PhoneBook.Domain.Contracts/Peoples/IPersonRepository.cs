﻿
using PhoneBook.Domain.Contracts.Common;
using PhoneBook.Domain.Core.Peoples;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.Domain.Contracts.Peoples
{
     public interface IPersonRepository:IBaseRepository<Person>
    {
        Person Update(Person person);
 //       List<Person> GetActivePerson();
        Person GetPeronWithPhoneNumber(int id);

    }
}
