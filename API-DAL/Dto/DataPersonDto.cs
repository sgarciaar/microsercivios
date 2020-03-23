using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MS_DAL_PERSON.Dto
{
    [Serializable]
    public class DataPersonDto
    {
        private long _idFicha;
        private string _cargo;
        private int _antiguedad;
        private string _area;

       
        public long IdFicha { get => _idFicha; set => _idFicha = value; }       
        public string Cargo { get => _cargo; set => _cargo = value; }       
        public int Antiguedad { get => _antiguedad; set => _antiguedad = value; }       
        public string Area { get => _area; set => _area = value; }
    }
}
