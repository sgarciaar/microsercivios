using log4net;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MS_API_PERSON.Dto;
using MS_API_PERSON.Service;
using MS_API_PERSON.Util;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace MS_API_PERSON.Controllers
{
    [Route(Constant.PathDALPerson)]
    [ApiController]
    [EnableCors(Constant.Policy)]
    public class PersonController: ControllerBase
    {

        private readonly IPersonService _iPersonService;

        private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);


        public PersonController(IPersonService iPersonService)
        {
            _iPersonService = iPersonService;
            
        }
       
        private IConfiguration Configuration { get; }

        [HttpGet(Constant.PathBase+ Constant.uriPerson)]
        public List<PersonDto> GetAll()
        {
            List<PersonDto> _personList = new List<PersonDto>();
            try
            {              
               _personList = _iPersonService.GetAll();            
                
            }            
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                
            }
            return _personList;
        }
    }
}
