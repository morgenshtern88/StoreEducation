using DataLayer.Enteties.Base;

namespace DataLayer.Enteties
{
    public class AuthorInPrintingEdition :BaseEntity
    {
        public long AuthorId { get; set; }
        public Author Authors { get; set; }
        public long PrintingEditionId { get; set; }
        public PrintingEdition PrintingEditions { get; set; } 
        
    }
}
