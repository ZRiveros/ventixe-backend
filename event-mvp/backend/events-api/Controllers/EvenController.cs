using Microsoft.AspNetCore.Mvc;

namespace events_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        var events = new[]
        {
            new {
                Id = 1,
                Title = "Echo Beats Festival",
                Date = "2029-05-20",
                Location = "Sunset Park, Los Angeles, CA",
                Category = "Music",
                Price = 60
            },
            new {
                Id = 2,
                Title = "Symphony Under the Stars",
                Date = "2029-05-21",
                Location = "Sunset Park, Los Angeles, CA",
                Category = "Music",
                Price = 50
            }
        };

        return Ok(events);
    }
}
