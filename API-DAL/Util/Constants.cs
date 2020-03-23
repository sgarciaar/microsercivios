using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MS_DAL_PERSON.Util
{
    public static class Constants
    {
        /*
         * Constante policy para cors y nombre conexion de base de datos
         */
        public const string Policy = "MyPolicy";
        public const string NameConnection = "SqlCon_db";
        public const string ServiceStartup = "Se inicio el servicio";

        public const string PathPerson = "api/qin/v1/web/dal/person";


        public const string personList = "No hay personas registradas";

        public const string personById = "Id Incorrecto";

        public const int StatusCodeOk = 200;

        public const int StatusCodeNotFound = 400;



    }
}
