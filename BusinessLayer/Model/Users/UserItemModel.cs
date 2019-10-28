using BusinessLayer.Model.Base;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.Model.Users
{
    public class UserItemModel : BaseModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public long Id { get; set; }
    }
}
