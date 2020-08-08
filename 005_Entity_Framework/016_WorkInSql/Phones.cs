namespace _016_WorkInSql
{
    public class Phones
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public int CompanyId { get; set; }

        public virtual Companies Companies { get; set; }
    }
}
