namespace _017_FluentAPI
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CodeContext : DbContext
    {
        public CodeContext()
            : base("name=CodeContext")
        {
        }

        public DbSet<Attendee> Attendees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AttendeeSplittedEntityConfig());
        }

    }
}