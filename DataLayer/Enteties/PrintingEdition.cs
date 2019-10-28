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
        public CurrencyEnum Currency { get; set; } 
        public Enums.TypeEnum Type { get; set; }
        public StatusEnum Status { get; set; }
        public List<AuthorInPrintingEdition> AuthorInPrintingEditions { get; set; }
        
    }
}
