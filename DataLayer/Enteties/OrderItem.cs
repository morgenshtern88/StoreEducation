using DataLayer.Enteties.Base;

namespace DataLayer.Enteties
{
    public class OrderItem :BaseEntity
    {
        public int Amount { get; set; }
        public string Currency { get; set; }
        public int PrintingEditionId { get; set; }
        public int OrderId { get; set; }
        public int Count { get; set; }
        public PrintingEdition PrintingEdition { get; set; }
        public Orders Orders { get; set; }
    }
}
