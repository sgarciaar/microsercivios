using log4net;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MS_DAL_PERSON.Dto;
using MS_DAL_PERSON.Service;
using MS_DAL_PERSON.Util;
using System;
using System.Collections.Generic;
using System.Reflection;

/*
 * Juan Garcia
 * juan.garcia@zentagroup.com
 */

namespace MS_DAL_PERSON.Controllers
{
    [Route(Constants.PathPerson)]
    [ApiController]
    [EnableCors(Constants.Policy)]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public PersonController(IPersonService iPersonService)
        {
            _personService = iPersonService;
        }

        [HttpGet]
        public ActionResult<List<PersonDto>> GetAll()
        {
            List<PersonDto> personList = new List<PersonDto>();
            try
            {
                personList = _personService.GetAll();
                if (personList == null)
                {
                    return NotFound(Constants.personList);
                }

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return personList;
        }

        [HttpGet("{id}")]
        public ActionResult<PersonDto> GetById(long id)
        {
            PersonDto person = new PersonDto();
            try
            {
                person = _personService.FindById(id);
                if (person == null)
                {
                    return NotFound(Constants.personById);
                }

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return person;
        }

    }
}
