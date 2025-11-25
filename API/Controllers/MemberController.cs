using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using API.Data;
using API.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]  // localhost:5000/api/Members
    [ApiController]
    public class MembersController(AppDbContext context) : ControllerBase
    {
        [HttpGet]
        public ActionResult <IReadOnlyList<AppUser>> GetMembers()
        {
            var Members= context.Users.ToList();
            return Members;
        }

        [HttpGet("{id}")] // localhost:5000/api/Members/tdm-id
        public ActionResult<AppUser>GeMember(string Id)
        {
            var Member= context.Users.Find(Id);
            if (Member == null) return NotFound();
            
             return Member;
        }
    }
}
