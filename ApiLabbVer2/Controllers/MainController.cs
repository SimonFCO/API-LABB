using ApiLabbVer2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiLabbVer2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public MainController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}/interests")]
        public async Task<IActionResult> GetPersoninterests(int id)
        {
            var person = await _context.Persons.FindAsync(id);
            if(person == null)
            {
                return NotFound($"Could not find person with id {id}");
            }

            var interestList = await (
                 from pi in _context.PersonInterests
                 where pi.PersonId == id

                 join i in _context.Interests on pi.Interestid equals i.Id

                 select new
                 {
                     InterestId = i.Id,
                     Title = i.Title,
                     Description = i.Description
                 }

                 ).ToListAsync();

            var response = new
            {
                PersonName = person.Name,
                Interests = interestList
            };

            return Ok(response);
        }
    }
}
