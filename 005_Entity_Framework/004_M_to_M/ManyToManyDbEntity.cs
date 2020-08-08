namespace _004_M_to_M
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ManyToManyDbEntity : DbContext
    {
        public ManyToManyDbEntity()
            : base("name=ManyToManyDbEntity")
        {
        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }
}