using Microsoft.Extensions.Configuration;
using MS_API_PERSON.Dto;
using MS_API_PERSON.Service;
using MS_API_PERSON.Util;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;

namespace MS_API_PERSON.Imp
{
    public class ImpPerson : IPersonService
    {
        public ImpPerson(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; }

        public List<PersonDto> GetAll()
        {
            List<PersonDto> _personList = new List<PersonDto>();
            try
            {
                string url = Configuration.GetConnectionString(Constant.PathDALPerson);
                var client = new RestClient(url + Constant.OibasePerson);
                client.AddDefaultHeader(Constant.ContentType, Constant.ApplicationJson);

                var request = new RestRequest(Constant.uriPerson) { RequestFormat = DataFormat.Json };
               

                var response = client.Execute<List<PersonDto>>(request);
                if (response.IsSuccessful)
                {
                    _personList = JsonConvert.DeserializeObject<List<PersonDto>>(response.Content);
                }

            }
            catch (Exception)
            {
                throw;
            }




            return _personList;

        }

        public PersonDto FindById(long id)
        {
            PersonDto _person = null;
            try
            {

            }
            catch (Exception)
            {

                throw;
            }



            return _person;
        }
    }
}
