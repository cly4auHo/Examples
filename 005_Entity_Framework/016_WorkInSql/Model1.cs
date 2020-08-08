namespace _016_WorkInSql
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DataModel : DbContext
    {
        
        public DataModel()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Companies> Companies { get; set; }
        public virtual DbSet<Phones> Phones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Companies>()
                .HasMany(e => e.Phones)
                .WithRequired(e => e.Companies)
                .HasForeignKey(e => e.CompanyId);
        }
    }
}