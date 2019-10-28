using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Model.Base
{
    public class BaseModel
    {
        public ICollection<string> Errors = new List<string>();
    }
}
