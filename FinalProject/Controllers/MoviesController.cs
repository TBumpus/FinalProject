using FinalProject.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetAllMovies")]
        public IActionResult GetAllMovies()
        {
            return Ok();
        }

        [HttpGet("GetRandomMovieFromThirdParty")]
        public IActionResult GetRandomMovieFromThirdParty()
        {
            return Ok();
        }

        [HttpGet("GetRandomMovieFromUserList")]
        public IActionResult GetRandomMovieFromUserList()
        {
            return Ok();
        }

        [HttpGet("GetMoviesByCategoryFromList")]
        public IActionResult GetMoviesByCategoryFromList()
        {
            return Ok();
        }

        [HttpGet("GetMovieByIdFromList")]
        public IActionResult GetMovieByIdFromList()
        {
            return Ok();
        }

        [HttpDelete("DeleteMovieFromList")]
        public IActionResult DeleteMovieFromList()
        {
            return Ok();
        }

        [HttpPost("AddMovieToList")]
        public IActionResult AddMovieToList()
        {
            return Ok();
        }

        [HttpPut("UpdateCategory")]
        public IActionResult UpdateCategory()
        {
            return Ok();
        }

        [HttpGet("SearchThirdParty")]
        public IActionResult SearchThirdParty()
        {
            return Ok();
        }
    }
}
