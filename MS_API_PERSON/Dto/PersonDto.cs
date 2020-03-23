using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MS_API_PERSON.Dto
{
    [Serializable]
    public class PersonDto
    {

        private string _nombre;
        private string _apellido;
        private int _edad;
        private string _ciudad;
        private string _direccion;

        
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int Edad { get => _edad; set => _edad = value; }
        public string Ciudad { get => _ciudad; set => _ciudad = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
    }
}
