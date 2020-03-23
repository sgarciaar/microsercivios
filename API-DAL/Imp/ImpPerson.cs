using log4net;
using MS_DAL_PERSON.DataContext;
using MS_DAL_PERSON.Dto;
using MS_DAL_PERSON.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MS_DAL_PERSON.Imp
{
    public class ImpPerson : IPersonService
    {
        private readonly GenericContext _genericContext;
        private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public ImpPerson(GenericContext genericContext)
        {
            _genericContext = genericContext;
        }

        public List<PersonDto> GetAll()
        {
            List<PersonDto> personList = new List<PersonDto>();
            PersonDto personDto;
            try
            {
                var analysisList = _genericContext.Person.ToList();
                foreach (var pers in analysisList)
                {
                    personDto = new PersonDto()
                    {
                        IdPersona = pers.IdPersona,
                        Nombre = pers.Nombre,
                        Apellido = pers.Apellido,
                        Edad = pers.Edad,
                        Direccion = pers.Direccion,
                        Ciudad = pers.Ciudad

                    };
                    personList.Add(personDto);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }
            return personList;
        }


        public PersonDto FindById(long id)
        {
            PersonDto person = null;
            try
            {
                var analysisList = _genericContext.Person.Where(w => w.IdPersona == id).FirstOrDefault();
                               
                person = new PersonDto() 
                {
                    IdPersona = analysisList.IdPersona,
                    Nombre = analysisList.Nombre,
                    Apellido = analysisList.Apellido,
                    Edad = analysisList.Edad,
                    Direccion = analysisList.Direccion,
                    Ciudad = analysisList.Ciudad
                };

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }

            return person;
        }




    }
}
