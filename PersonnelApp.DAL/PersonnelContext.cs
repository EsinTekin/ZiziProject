using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PersonelApp.Domains;

namespace PersonnelApp.DAL
{
    public class PersonnelContext:DbContext
       
    {
        public PersonnelContext():base("PersonnelContext")
        {

        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Personel> personels { get; set; }

    }


 
}
