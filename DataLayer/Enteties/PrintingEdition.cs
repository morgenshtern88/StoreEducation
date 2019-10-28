using DataLayer.Enteties.Base;
using DataLayer.Enteties.Enums;
using System;
using System.Collections.Generic;

namespace DataLayer.Enteties
{
    public class PrintingEdition : BaseEntity
    {
        public string Title { get; set; }
        public string Desccription { get; set; }
        public decimal Price { get; set; }
        public IList<OrderItem> OrderItems { get; set; }
        public string Currency { get; set; } 
        public string Type { get; set; }
        public string Status { get; set; }
        public List<AuthorInPrintingEdition> AuthorInPrintingEditions { get; set; }
        
    }
}
