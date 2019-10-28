using System;

namespace DataLayer.Enteties.Base
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public bool IsRemoved { get; set; }
        public DateTime Date { get; set; }
    }
}
