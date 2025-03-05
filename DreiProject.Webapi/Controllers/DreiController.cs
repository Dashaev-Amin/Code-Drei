using Microsoft.AspNetCore.Mvc;

namespace SpengernewsProject.Webapi.Controllers
{
    [ApiController]               // Muss bei jedem Controller stehen
    [Route("/api/[controller]")]  // Muss bei jedem Controller stehen
    public class DreiController : ControllerBase
    {
        private readonly DreiContext _db;

        public DreiController(DreiContext db)
        {
            _db = db;
        }
        // Reagiert auf GET /api/drei
        [HttpGet]
        public IActionResult GetAllNews()
        {
            return Ok(new string[] { "News 1", "News 2" });
        }
        // Reagiert z. B. auf /api/drei/14
        [HttpGet("{id:int}")]
        public IActionResult GetNewsDetail(int id)
        {
            if (id < 1000) { return NotFound(); }
            return Ok($"News {id}");
        }
    }
}