using BusinessLayer.Model.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Model.PrintingEdition
{
    public class PrintingEdirionModel : BaseModel
    {
        public ICollection<PrintingEdirionModel> Items = new List<PrintingEdirionModel>();
    }
}
