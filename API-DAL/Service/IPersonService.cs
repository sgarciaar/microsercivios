using MS_DAL_PERSON.Dto;
using System.Collections.Generic;

namespace MS_DAL_PERSON.Service
{
    public interface IPersonService
    {
    
        List<PersonDto> GetAll();
        PersonDto FindById(long idPerson);
    }
}
