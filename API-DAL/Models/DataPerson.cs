using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
/*
 * Juan Garcia
 * juan.garcia@zentagroup.com
 */
namespace MS_DAL_PERSON.Models
{
    [Table("Fichas")]
    public class DataPerson
    {
        private long _idFicha;
        private string _cargo;
        private int _antiguedad;
        private string _area;

        [Key]
        [Column("id_Ficha")]
        [Required]
        public long IdFicha { get => _idFicha; set => _idFicha = value; }
        
        [Column("Cargo")]
        [Required]
        public string Cargo { get => _cargo; set => _cargo = value; }
       
        [Column("Antiguedad")]
        [Required]
        public int Antiguedad { get => _antiguedad; set => _antiguedad = value; }

        [Column("Area")]
        [Required]
        public string Area { get => _area; set => _area = value; }


    }
}
