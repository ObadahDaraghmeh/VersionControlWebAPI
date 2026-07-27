using Microsoft.AspNetCore.Mvc;

namespace VersionControlWebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NameController : ControllerBase
{
    // GET: api/name
    // Returns the developer's name as JSON.
    [HttpGet]
    public IActionResult GetName()
    {
        var result = new { name = "Obadah Daraghmeh" };
        return Ok(result);
    }
}
