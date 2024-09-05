using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers;

public class ActivitiesController : BaseApiController
{
    public DataContext _context { get; }

    public ActivitiesController(DataContext context)
    {
        _context = context;
    }

    [HttpGet("activities")] //api/activities
    public async Task<ActionResult<List<Activity>>> GetActivities()
    {
        return await _context.Activities.ToListAsync();
    }

    [HttpGet("id")] //api/activities/id
    public async Task<ActionResult<List<Activity>>> GetActivity(Guid id)
    {
        return Ok(await _context.Activities.FindAsync(id));
    }


}
