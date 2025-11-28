using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using API.Data;
using API.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    // added to git hub
    [Route("api/[controller]")]  // localhost:5000/api/Members
    [ApiController]
    public class MembersController(AppDbContext context) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult <IReadOnlyList<AppUser>>> GetMembers()
        {
            var Members= await context.Users.ToListAsync();
            return Members;
        }

        [HttpGet("{id}")] // localhost:5000/api/Members/tdm-id
        public async Task<ActionResult<AppUser>>GeMember(string Id)
        {
            var Member= await context.Users.FindAsync(Id);
            if (Member == null) return NotFound();
            
             return Member;
        }
    }
}
