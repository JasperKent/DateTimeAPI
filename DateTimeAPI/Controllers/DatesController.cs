using DateTimeAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DateTimeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatesController : ControllerBase
    {
        private readonly DateTimeContext _context;

        public DatesController(DateTimeContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Items);
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            DataItem item = new()
            {
                DateTime = DateTime.UtcNow,
                Date = DateOnly.FromDateTime(DateTime.UtcNow),
                Time = TimeOnly.FromDateTime(DateTime.UtcNow)
            };

            return Ok(item);
        }

        [HttpPost]
        public IActionResult Post(DataItem item)
        {
            _context.Add(item);
            _context.SaveChanges();

            return CreatedAtAction(nameof(Get), item);
        }
    }
}
