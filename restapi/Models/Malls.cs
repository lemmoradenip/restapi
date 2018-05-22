using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*using System.Data.Entity;*/
using System.Data;
namespace restapi.Models
{
    public class Malls
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descriptions { get; set; }
        public string Address { get; set; }
        public string About { get; set; }
        public string TelPhone { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
    }

    /*###REFERENCE ONLY###
       public class EmpDBContext : DbContext{
      public EmpDBContext()
      { }
      public DbSet<Employee> Employees { get; set; }
   }
     */

    //public class MallListDBContext : DbContext {
    //    public MallListDBContext() { }//constructor
    //    public DbSet<Malls> MallsList { get; set; }
    //}
}
