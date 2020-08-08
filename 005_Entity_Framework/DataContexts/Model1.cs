namespace DataContexts
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model1 : DbContext
    {
        static Model1()
        {
            Database.SetInitializer(new MyContextInitializer());
        }
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }
    }

    
}