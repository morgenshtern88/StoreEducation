using BusinessLayer.Model.Base;
using System.Collections.Generic;

namespace BusinessLayer.Model.Author
{
    public class AuthorModel :BaseModel
    {
        public ICollection<AuthorModel> Items = new List<AuthorModel>();
    }
}
