using DataLayer.Enteties.Base;

namespace DataLayer.Enteties
{
    public class Payment :BaseEntity
    {
        public long TransactionId { get; set; }
        public Orders Orders { get; set; }
    }
}
