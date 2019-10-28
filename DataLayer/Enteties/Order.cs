using DataLayer.Enteties.Base;
using System.Collections.Generic;

namespace DataLayer.Enteties
{
    public class Orders :BaseEntity
    {
        public string Description { get; set; }
        public long UserId { get; set; }
        public long PaymentId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}
