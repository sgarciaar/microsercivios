using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
/*
 * Juan Garcia
 * juan.garcia@zentagroup.com
 */
namespace MS_DAL_PERSON.Models
{
    [Table("Personas")]
    public class Person
    {
        private long _idPersona;
        private string _nombre;
        private string _apellido;
        private int _edad;
        private string _ciudad;
        private string _direccion;

        [Key]
        [Column("id_Persona")]
        [Required]
        public long IdPersona { get => _idPersona; set => _idPersona = value; }

        [Column("Nombre")]
        [Required]
        public string Nombre { get => _nombre; set => _nombre = value; }

        [Column("Apellido")]
        [Required]
        public string Apellido { get => _apellido; set => _apellido = value; }

        [Column("Edad")]
        [Required]
        public int Edad { get => _edad; set => _edad = value; }

        [Column("Ciudad")]
        [Required]
        public string Ciudad { get => _ciudad; set => _ciudad = value; }

        [Column("Direccion")]
        [Required]
        public string Direccion { get => _direccion; set => _direccion = value; }

    }
}
