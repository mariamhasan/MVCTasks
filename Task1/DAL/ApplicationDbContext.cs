namespace Task1.DAL
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ApplicationDbContext : DbContext
    {
        
        public ApplicationDbContext()
            : base("name=ApplicationDbContext")
        {
        }

      public virtual DbSet <Employee> Employees { get; set; }
    }

   
}