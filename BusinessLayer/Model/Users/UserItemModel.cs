using BusinessLayer.Model.Base;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.Model.Users
{
    public class UserItemModel : BaseModel
    {
        public long UserId { get; set; }
        public string UserEmail { get; set; }
        public List<IdentityRole<long>> AllRoles { get; set; }
        public IList<string> UserRoles { get; set; }
        public UserItemModel()
        {
            AllRoles = new List<IdentityRole<long>>();
            UserRoles = new List<string>();
        }
    }
}
