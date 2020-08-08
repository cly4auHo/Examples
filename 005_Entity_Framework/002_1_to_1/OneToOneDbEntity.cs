namespace _002_1_to_1
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class OneToOneDbEntity : DbContext
    {
        public OneToOneDbEntity()
            : base("name=Model1")
        {
        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }
}