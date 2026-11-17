using JobAgents.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Concurrent;

namespace JobAgents.Api.Controllers;

[Route("api/job-postings")]
[ApiController]
public class JobPostingsController : ControllerBase
{
    // TEMPORARY: moves to a DI service in step 1.3
    private static readonly ConcurrentDictionary<int, JobPosting> _postings = new();
    private static int _lastId = 0;

    [HttpGet]
    public IEnumerable<JobPosting> GetAll()
    {
        return _postings.Values.OrderBy(p => p.Id);
    }
    
    [HttpGet("{id:int}")]
    public ActionResult<JobPosting> GetById(int id)
    {
        if (_postings.TryGetValue(id, out var posting))
        {
            return posting;
        }
        return NotFound();
    }

    [HttpPost]
    public ActionResult<JobPosting> Post(JobPosting posting)
    {
        var id = Interlocked.Increment(ref _lastId);
        posting.Id = id;
        posting.CreatedAt = DateTimeOffset.UtcNow;
        _postings[id] = posting;
        return CreatedAtAction(nameof(GetById), new { id = posting.Id }, posting);
    }
}
