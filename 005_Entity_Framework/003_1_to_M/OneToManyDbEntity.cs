namespace _003_1_to_M
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class OneToManyDbEntity : DbContext
    {
        public OneToManyDbEntity()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }

   
}