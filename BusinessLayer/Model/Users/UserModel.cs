using BusinessLayer.Model.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Model.Users
{
    public class UserModel :BaseModel
    {
        public ICollection<UserItemModel> Items = new List<UserItemModel>();
    }
}
