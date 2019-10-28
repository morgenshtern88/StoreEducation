using BusinessLayer.Model.Base;
using System.Collections.Generic;

namespace BusinessLayer.Model.Payments
{
    public class PaymentsModel :BaseModel
    {
        public ICollection<PaymentsModel> Items = new List<PaymentsModel>();
    }
}
