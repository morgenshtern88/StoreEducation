using Microsoft.AspNetCore.Identity;

namespace DataLayer.Enteties
{
    public class ApplicationUser :IdentityUser<long>
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
