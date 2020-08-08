using System.Collections.Generic;

namespace _003_1_to_M
{
    public class Order
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public int Quantity { get; set; }
        public ICollection<Product> Product { get; set; }

        public Order()
        {
            Product = new List<Product>();
        }
    }
}
