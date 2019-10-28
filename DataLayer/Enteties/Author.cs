using DataLayer.Enteties.Base;
using System.Collections.Generic;

namespace DataLayer.Enteties
{
    public class Author : BaseEntity
    {
        public string Name { get; set; }
        public List<AuthorInPrintingEdition> AuthorPrintingEditions { get; set; }
    }
}
