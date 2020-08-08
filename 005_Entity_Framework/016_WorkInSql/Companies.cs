using System.Collections.Generic;

namespace _016_WorkInSql
{
    public class Companies
    {
        public Companies()
        {
            Phones = new HashSet<Phones>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Phones> Phones { get; set; }
    }
}
