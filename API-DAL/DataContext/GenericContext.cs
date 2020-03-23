using Microsoft.EntityFrameworkCore;
using MS_DAL_PERSON.Models;
/*
 * Juan Garcia
 * juan.garcia@zentagroup.com
 */

namespace MS_DAL_PERSON.DataContext
{
    public class GenericContext : DbContext
    {
        public GenericContext(DbContextOptions<GenericContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }





        public DbSet<Person> Person { get; set; }
        public DbSet<DataPerson> DataPerson { get; set; }



    }
}
