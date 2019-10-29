using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.AppContext;
using DataLayer.Enteties;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationApp.PresentationLayer.Controllers
{
   [Route("api/[controller]")]
    public class UsersController : Controller
    {
        ApplicationContext db;
        public UsersController(ApplicationContext context)
        {
            this.db = context;
            if (!db.Users.Any())
            {
                db.Users.Add(new ApplicationUser { Name = "Tom", Age = 26 });
                db.Users.Add(new ApplicationUser { Name = "Alice", Age = 31 });
                db.SaveChanges();
            }
        }
 
        [HttpGet]
        public IEnumerable<ApplicationUser> Get()
        {
            return db.Users.ToList();
        }
 
        // GET api/users/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            ApplicationUser user = db.Users.FirstOrDefault(x => x.Id == id);
            if (user == null)
                return NotFound();
            return new ObjectResult(user);
        }
 
        // POST api/users
        [HttpPost]
        public IActionResult Post([FromBody]ApplicationUser user)
        {
            if (user==null)
            {
                return BadRequest();
            }
 
            db.Users.Add(user);
            db.SaveChanges();
            return Ok(user);
        }
 
        // PUT api/users/
        [HttpPut]
        public IActionResult Put([FromBody]ApplicationUser user)
        {
            if (user==null)
            {
                return BadRequest();
            }
            if (!db.Users.Any(x => x.Id == user.Id))
            {
                return NotFound();
            }
 
            db.Update(user);
            db.SaveChanges();
            return Ok(user);
        }
 
        // DELETE api/users/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            ApplicationUser user = db.Users.FirstOrDefault(x => x.Id == id);
            if(user==null)
            {
                return NotFound();
            }
            db.Users.Remove(user);
            db.SaveChanges();
            return Ok(user);
        }
    }
}