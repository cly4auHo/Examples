namespace _002_Operations
{
    using System.Data.Entity;
    
    public class ProductDB : DbContext
    {
        public ProductDB()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Product> Products { get; set; }
    }
}