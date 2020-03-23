using MS_API_PERSON.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MS_API_PERSON.Service
{
    public interface IPersonService
    {
        List<PersonDto> GetAll();
        PersonDto FindById(long idPerson);
    }
}
