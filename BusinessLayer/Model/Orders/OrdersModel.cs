using BusinessLayer.Model.Base;
using System.Collections.Generic;

namespace BusinessLayer.Model.Orders
{
    public class OrdersModel :BaseModel
    {
        public ICollection<OrdersModel> Items = new List<OrdersModel>();
    }
}
