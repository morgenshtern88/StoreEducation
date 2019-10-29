using BusinessLayer.Model.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Model.Author
{
    public class AuthorItemModel :BaseModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
       
    }
}
